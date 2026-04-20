using CapaDatos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            ConfigurarGrid();
            CargarCombos();

            // dtpDel muestra hoy — se usa para nueva actividad
            dtpDel.Value = DateTime.Today;
            // dtpAl muestra fin de mes actual
            dtpAl.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month,
                           DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month));

            dtpInicio.Value = DateTime.Today;
            dtpFinalizacion.Value = DateTime.Today.AddHours(23).AddMinutes(59);
            dtpInicio.Visible = false;
            dtpFinalizacion.Visible = false;
            label1.Visible = false;
            label2.Visible = false;

            // Al cargar muestra TODAS las actividades sin filtro de fecha
            MostrarTodas();

            btnNuevaActividad.Click -= btnNuevaActividad_Click;
            btnNuevaActividad.Click -= btnNuevaActividad_Click_v2;
            btnNuevaActividad.Click += btnNuevaActividad_Click_v2;

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
                Name = "colDuracion",
                DataPropertyName = "Duración",
                HeaderText = "Duración",
                Width = 130
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
            // cmbTipo
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

            // cmbHorario — sin fila vacía, siempre debe tener valor
            DataTable dtDuracion = objNeg.MostrarTiposDuracion();
            DataRow filaVacia = dtDuracion.NewRow();
            dtDuracion.Rows.InsertAt(filaVacia, 0);
            cmbHorario.DataSource = null;
            cmbHorario.DataSource = dtDuracion;
            cmbHorario.DisplayMember = "Descripcion";
            cmbHorario.ValueMember = "ID";
            cmbHorario.SelectedIndex = 0; // selecciona la fila vacía

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
                dtpInicio.Visible ? dtpInicio.Value.TimeOfDay : TimeSpan.Zero,
                dtpFinalizacion.Visible ? dtpFinalizacion.Value.TimeOfDay : new TimeSpan(23, 59, 59)
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

                if (fechaActual.Date != fechaAnterior.Date)
                {
                    int indexEncabezado = dg1.Rows.Add();
                    DataGridViewRow filaEncabezado = dg1.Rows[indexEncabezado];

                    filaEncabezado.Cells["colTipo"].Value =
                        "📅  " + fechaActual.ToString("dddd, dd 'de' MMMM 'de' yyyy",
                        new System.Globalization.CultureInfo("es-GT")).ToUpper();

                    filaEncabezado.DefaultCellStyle.BackColor = Color.FromArgb(33, 97, 140);
                    filaEncabezado.DefaultCellStyle.ForeColor = Color.White;
                    filaEncabezado.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    filaEncabezado.DefaultCellStyle.SelectionBackColor = Color.FromArgb(33, 97, 140);
                    filaEncabezado.DefaultCellStyle.SelectionForeColor = Color.White;
                    filaEncabezado.Tag = "encabezado";

                    fechaAnterior = fechaActual.Date;
                }

                int indexFila = dg1.Rows.Add();
                DataGridViewRow fila = dg1.Rows[indexFila];

                fila.Cells["colID"].Value = row["ID"];
                fila.Cells["colFecha"].Value = fechaActual.ToString("dd/MM/yyyy");
                fila.Cells["colTipo"].Value = row["Tipo"];
                fila.Cells["colMinisterio"].Value = row["Ministerio"];
                fila.Cells["colDuracion"].Value = row["Duración"];
                fila.Cells["colHoraInicio"].Value = row["Hora Inicio"];
                fila.Cells["colHoraFin"].Value = row["Hora Fin"];
                fila.Cells["colLugar"].Value = row["Lugar"];
                fila.Cells["colAnfitrion"].Value = row["Anfitrión"];

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

        }




        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            cmbTipo.SelectedIndex = 0;
            cmbMinisterio.SelectedIndex = 0;
            cmbLugar.SelectedIndex = 0;
            cmbAnfitrion.SelectedIndex = 0;
            cmbHorario.SelectedIndex = 0;
            dtpDel.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpAl.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month,
                              DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month));
            dtpInicio.Value = DateTime.Today;
            dtpFinalizacion.Value = DateTime.Today.AddHours(23).AddMinutes(59);
            // NO llama a Buscar() — el grid queda como estaba
        }

        private void frmActividades_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevaActividad_Click_v2(object sender, EventArgs e)
        {
            if (btnNuevaActividad.Tag?.ToString() == "guardando")
            {
                GuardarActividad();
            }
            else
            {
                // Limpia los campos para ingresar una nueva actividad
                cmbTipo.SelectedIndex = 0;
                cmbMinisterio.SelectedIndex = 0;
                cmbLugar.SelectedIndex = 0;
                cmbAnfitrion.SelectedIndex = 0;
                cmbHorario.SelectedIndex = 0;
                dtpDel.Value = DateTime.Today;
                dtpInicio.Value = DateTime.Today;
                dtpFinalizacion.Value = DateTime.Today.AddHours(1);

                btnNuevaActividad.Text = "💾 Guardar Actividad";
                btnNuevaActividad.Tag = "guardando";
            }

        }


        // ============================================================
        // LÓGICA DE GUARDAR
        // ============================================================
        private void GuardarActividad()
        {
            // ── Validaciones ──────────────────────────────────────────
            if (!(cmbTipo.SelectedValue is int))
            { MessageBox.Show("Selecciona un Tipo de Actividad.", "Aviso"); return; }

            if (!(cmbMinisterio.SelectedValue is int))
            { MessageBox.Show("Selecciona un Ministerio.", "Aviso"); return; }

            if (!(cmbLugar.SelectedValue is int))
            { MessageBox.Show("Selecciona un Lugar.", "Aviso"); return; }

            if (!(cmbHorario.SelectedValue is int))
            { MessageBox.Show("Selecciona un tipo de Horario.", "Aviso"); return; }

            // Si el horario requiere hora, validar que inicio < fin
            if (dtpInicio.Visible && dtpInicio.Value.TimeOfDay >= dtpFinalizacion.Value.TimeOfDay)
            { MessageBox.Show("La hora de inicio debe ser menor a la hora de finalización.", "Aviso"); return; }

            // ── Leer valores ──────────────────────────────────────────
            int idTipo = (int)cmbTipo.SelectedValue;
            int idMinisterio = (int)cmbMinisterio.SelectedValue;
            int idLugar = (int)cmbLugar.SelectedValue;
            int idTipoDuracion = (int)cmbHorario.SelectedValue;
            int? idAnfitrion = (cmbAnfitrion.SelectedValue is int a) ? a : (int?)null;

            // Si los dtp están visibles manda la hora, si no manda NULL
            TimeSpan? horaInicio = dtpInicio.Visible ? dtpInicio.Value.TimeOfDay : (TimeSpan?)null;
            TimeSpan? horaFin = dtpFinalizacion.Visible ? dtpFinalizacion.Value.TimeOfDay : (TimeSpan?)null;

            // ── Insertar ──────────────────────────────────────────────
            objNeg.InsertarActividad(
                idMinisterio,
                idTipo,
                dtpDel.Value.Date,
                idTipoDuracion,
                horaInicio,
                horaFin,
                idLugar,
                idAnfitrion
            );

            MessageBox.Show("✅ Actividad guardada correctamente.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Regresa el botón a su estado original y refresca el grid
            btnNuevaActividad.Text = "Nueva Actividad";
            btnNuevaActividad.Tag = null;
            Buscar(); // ← refresca SOLO al guardar
        }


        private void cmbHorario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHorario.SelectedValue is int idDuracion)
            {
                DataTable dt = objNeg.MostrarTiposDuracion();
                DataRow[] filas = dt.Select("ID = " + idDuracion);

                bool requiereHora = filas.Length > 0 && Convert.ToBoolean(filas[0]["Requiere_Hora"]);
                dtpInicio.Visible = requiereHora;
                dtpFinalizacion.Visible = requiereHora;
                label1.Visible = requiereHora;
                label2.Visible = requiereHora;
            }
        }

        private void dg1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void MostrarTodas()
        {
            // Busca sin filtro de fechas — manda un rango muy amplio
            DataTable dt = objNeg.BuscarActividades(
                "",       // sin texto
                null,     // todos los tipos
                null,     // todos los ministerios
                null,     // todos los lugares
                null,     // todos los anfitriones
                new DateTime(2000, 1, 1),   // desde el año 2000
                new DateTime(2099, 12, 31), // hasta el año 2099
                TimeSpan.Zero,
                new TimeSpan(23, 59, 59)
            );
            MostrarAgrupado(dt);
        }


    }
}