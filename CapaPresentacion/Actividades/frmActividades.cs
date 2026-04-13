using CapaNegocio;
using System.Data;

namespace CapaPresentacion
{

    public partial class frmActividades : Form
    {
        CN_Actividades objNeg = new CN_Actividades();
        public frmActividades()
        {
            InitializeComponent();
        }

        private void frmActividades_Load(object sender, EventArgs e)
        {
            CargarCombos();
            ConfigurarGrid();

            // Rango de fechas por defecto: mes actual
            dtpDel.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpAl.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month,
                             DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month));

            // Horas por defecto: todo el día
            dtpInicio.Value = DateTime.Today;
            dtpFinalizacion.Value = DateTime.Today.AddHours(23).AddMinutes(59);

            Buscar();

        }

        private void ConfigurarGrid()
        {
            dg1.AutoGenerateColumns = false;
            dg1.AllowUserToAddRows = false;
            dg1.ReadOnly = true;
            dg1.RowHeadersVisible = false;
            dg1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg1.BackgroundColor = Color.White;
            dg1.BorderStyle = BorderStyle.None;
            dg1.GridColor = Color.LightGray;
            dg1.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            dg1.Columns.Clear();

            // Columna oculta para guardar el ID
            dg1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colID",
                DataPropertyName = "ID",
                HeaderText = "ID",
                Visible = false
            });

            dg1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colFecha",
                DataPropertyName = "Fecha",
                HeaderText = "Fecha",
                Width = 100
            });

            dg1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colTipo",
                DataPropertyName = "Tipo",
                HeaderText = "Tipo",
                Width = 150
            });

            dg1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colMinisterio",
                DataPropertyName = "Ministerio",
                HeaderText = "Ministerio",
                Width = 120
            });

            dg1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colHoraInicio",
                DataPropertyName = "Hora Inicio",
                HeaderText = "Inicio",
                Width = 80
            });

            dg1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colHoraFin",
                DataPropertyName = "Hora Fin",
                HeaderText = "Fin",
                Width = 80
            });

            dg1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colLugar",
                DataPropertyName = "Lugar",
                HeaderText = "Lugar",
                Width = 150
            });

            dg1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colAnfitrion",
                DataPropertyName = "Anfitrión",
                HeaderText = "Anfitrión",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }



        private void CargarCombos()
        {
            DataTable dtTipo = objNeg.MostrarTiposActividad();
            dtTipo.Rows.InsertAt(dtTipo.NewRow(), 0);
            cmbTipo.DataSource = dtTipo;
            cmbTipo.DisplayMember = "Descripcion";
            cmbTipo.ValueMember = "ID";

            // cmbMinisterio
            DataTable dtMin = objNeg.MostrarMinisterios();
            dtMin.Rows.InsertAt(dtMin.NewRow(), 0);
            cmbMinisterio.DataSource = dtMin;
            cmbMinisterio.DisplayMember = "Nombre";
            cmbMinisterio.ValueMember = "ID_Ministerio";

            // cmbLugar
            DataTable dtLugar = objNeg.MostrarLugares();
            dtLugar.Rows.InsertAt(dtLugar.NewRow(), 0);
            cmbLugar.DataSource = dtLugar;
            cmbLugar.DisplayMember = "Nombre";
            cmbLugar.ValueMember = "ID";

            // cmbAnfitrion
            DataTable dtMiembros = objNeg.MostrarMiembros();
            dtMiembros.Rows.InsertAt(dtMiembros.NewRow(), 0);
            cmbAnfitrion.DataSource = dtMiembros;
            cmbAnfitrion.DisplayMember = "Nombres";
            cmbAnfitrion.ValueMember = "ID";
        }


        private void Buscar()
        {
            int? idTipo = (cmbTipo.SelectedValue is int t) ? t : (int?)null;
            int? idMinisterio = (cmbMinisterio.SelectedValue is int m) ? m : (int?)null;
            int? idLugar = (cmbLugar.SelectedValue is int l) ? l : (int?)null;
            int? idAnfitrion = (cmbAnfitrion.SelectedValue is int a) ? a : (int?)null;

            DataTable dt = objNeg.BuscarActividades(
                txtBuscar.Text,
                idTipo, idMinisterio, idLugar, idAnfitrion,
                dtpDel.Value,
                dtpAl.Value,
                dtpInicio.Value.TimeOfDay,
                dtpFinalizacion.Value.TimeOfDay
            );

            MostrarAgrupado(dt);
        }


        private void MostrarAgrupado(DataTable dt)
        {
            dg1.Rows.Clear();

            DateTime fechaAnterior = DateTime.MinValue;

            foreach (DataRow row in dt.Rows)
            {
                DateTime fechaActual = Convert.ToDateTime(row["Fecha"]);

                // Si es una fecha nueva → insertar fila de encabezado
                if (fechaActual.Date != fechaAnterior.Date)
                {
                    int indexEncabezado = dg1.Rows.Add();
                    DataGridViewRow filaEncabezado = dg1.Rows[indexEncabezado];

                    // Mostrar la fecha en formato amigable en la columna Tipo
                    filaEncabezado.Cells["colTipo"].Value =
                        "📅  " + fechaActual.ToString("dddd, dd 'de' MMMM 'de' yyyy",
                        new System.Globalization.CultureInfo("es-GT")).ToUpper();

                    // Estilo del encabezado de fecha
                    filaEncabezado.DefaultCellStyle.BackColor = Color.FromArgb(33, 97, 140);
                    filaEncabezado.DefaultCellStyle.ForeColor = Color.White;
                    filaEncabezado.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    filaEncabezado.DefaultCellStyle.SelectionBackColor = Color.FromArgb(33, 97, 140);
                    filaEncabezado.DefaultCellStyle.SelectionForeColor = Color.White;
                    filaEncabezado.Tag = "encabezado"; // Marca para no seleccionarlo

                    fechaAnterior = fechaActual.Date;
                }

                // Insertar la fila de actividad normal
                int indexFila = dg1.Rows.Add();
                DataGridViewRow fila = dg1.Rows[indexFila];

                fila.Cells["colID"].Value = row["ID"];
                fila.Cells["colFecha"].Value = fechaActual.ToString("dd/MM/yyyy");
                fila.Cells["colTipo"].Value = row["Tipo"];
                fila.Cells["colMinisterio"].Value = row["Ministerio"];
                fila.Cells["colHoraInicio"].Value = row["Hora Inicio"];
                fila.Cells["colHoraFin"].Value = row["Hora Fin"];
                fila.Cells["colLugar"].Value = row["Lugar"];
                fila.Cells["colAnfitrion"].Value = row["Anfitrión"];

                // Estilo alternado para las filas de actividad
                fila.DefaultCellStyle.BackColor = (indexFila % 2 == 0)
                    ? Color.White
                    : Color.FromArgb(235, 245, 251);
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }


        private void btnNuevaActividad_Click(object sender, EventArgs e)
        {
            // Limpia los campos del panel de ingreso
            cmbTipo.SelectedIndex = 0;
            cmbMinisterio.SelectedIndex = 0;
            cmbLugar.SelectedIndex = 0;
            cmbAnfitrion.SelectedIndex = 0;
            dtpDel.Value = DateTime.Today;
            dtpInicio.Value = DateTime.Today;
            dtpFinalizacion.Value = DateTime.Today.AddHours(1);

            // Cambia el botón a modo "Guardar"
            btnNuevaActividad.Text = "Guardar Actividad";
            btnNuevaActividad.Tag = "guardando";
        }

        private void btnGuardarActividad_Click()
        {
            // Validaciones básicas
            if (cmbTipo.SelectedValue == null || !(cmbTipo.SelectedValue is int))
            { MessageBox.Show("Selecciona un Tipo de Actividad.", "Aviso"); return; }

            if (cmbMinisterio.SelectedValue == null || !(cmbMinisterio.SelectedValue is int))
            { MessageBox.Show("Selecciona un Ministerio.", "Aviso"); return; }

            if (cmbLugar.SelectedValue == null || !(cmbLugar.SelectedValue is int))
            { MessageBox.Show("Selecciona un Lugar.", "Aviso"); return; }

            if (dtpInicio.Value.TimeOfDay >= dtpFinalizacion.Value.TimeOfDay)
            { MessageBox.Show("La hora de inicio debe ser menor a la hora de finalización.", "Aviso"); return; }

            int idTipo = (int)cmbTipo.SelectedValue;
            int idMinisterio = (int)cmbMinisterio.SelectedValue;
            int idLugar = (int)cmbLugar.SelectedValue;
            int? idAnfitrion = (cmbAnfitrion.SelectedValue is int a) ? a : (int?)null;

            objNeg.InsertarActividad(
                idMinisterio,
                idTipo,
                dtpDel.Value.Date,
                dtpInicio.Value.TimeOfDay,
                dtpFinalizacion.Value.TimeOfDay,
                idLugar,
                idAnfitrion
            );

            MessageBox.Show("✅ Actividad guardada correctamente.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Regresa el botón a su estado original y refresca
            btnNuevaActividad.Text = "Nueva Actividad";
            btnNuevaActividad.Tag = null;
            Buscar();
        }


        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            cmbTipo.SelectedIndex = 0;
            cmbMinisterio.SelectedIndex = 0;
            cmbLugar.SelectedIndex = 0;
            cmbAnfitrion.SelectedIndex = 0;
            dtpDel.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpAl.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month,
                             DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month));
            dtpInicio.Value = DateTime.Today;
            dtpFinalizacion.Value = DateTime.Today.AddHours(23).AddMinutes(59);
            Buscar();
        }

        private void frmActividades_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevaActividad_Click_v2(object sender, EventArgs e)
        {
            if (btnNuevaActividad.Tag?.ToString() == "guardando")
                btnGuardarActividad_Click();
            else
            {
                cmbTipo.SelectedIndex = 0;
                cmbMinisterio.SelectedIndex = 0;
                cmbLugar.SelectedIndex = 0;
                cmbAnfitrion.SelectedIndex = 0;
                dtpDel.Value = DateTime.Today;
                dtpInicio.Value = DateTime.Today;
                dtpFinalizacion.Value = DateTime.Today.AddHours(1);

                btnNuevaActividad.Text = "💾 Guardar Actividad";
                btnNuevaActividad.Tag = "guardando";
            }

        }
    }
}
