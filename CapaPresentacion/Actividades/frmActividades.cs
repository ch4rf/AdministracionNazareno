using CapaDatos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace CapaPresentacion
{

    public partial class frmActividades : Form
    {
        CN_Actividades objNeg = new CN_Actividades();
        public frmActividades()
        {
            InitializeComponent();
        }
        //carga el formulario
        private void frmActividades_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();
            CargarCombos();
            // Inicia oculto — se muestra solo si el lugar lo requiere
            cmbAnfitrion.Visible = false;
            label4.Visible = false;



            // dtpDel muestra hoy (fecha de la nueva actividad)
            dtpDel.Value = DateTime.Today;
            // dtpAl muestra fin del mes actual (para el filtro)
            dtpAl.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month,
                          DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month));

            dtpInicio.Value = DateTime.Today;
            dtpFinalizacion.Value = DateTime.Today.AddHours(23).AddMinutes(59);

            // Los dtp de hora inician ocultos
            dtpInicio.Visible = false;
            dtpFinalizacion.Visible = false;
            label1.Visible = false;
            label2.Visible = false;

            // Muestra todas las actividades al abrir
            MostrarTodas();

            // Asegura que solo btnNuevaActividad_Click_v2 maneje el click
            btnNuevaActividad.Click -= btnNuevaActividad_Click;
            btnNuevaActividad.Click -= btnNuevaActividad_Click_v2;
            btnNuevaActividad.Click += btnNuevaActividad_Click_v2;
        }

        //configurar columnas del datagridview
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


        //cargar combos
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

            // cmbHorario — con fila vacía al inicio
            DataTable dtDuracion = objNeg.MostrarTiposDuracion();
            dtDuracion.Rows.InsertAt(dtDuracion.NewRow(), 0);
            cmbHorario.DataSource = null;
            cmbHorario.DataSource = dtDuracion;
            cmbHorario.DisplayMember = "Descripcion";
            cmbHorario.ValueMember = "ID";
            cmbHorario.SelectedIndex = 0;

        }

        //MOSTRAR TODAS (sin filtro — al cargar y al limpiar)
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

        //Buscar los filtros del formulario
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
                dtpInicio.Visible ? dtpInicio.Value.TimeOfDay : (TimeSpan?)null,
                dtpFinalizacion.Visible ? dtpFinalizacion.Value.TimeOfDay : (TimeSpan?)null
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

        //btnBuscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }


        private void btnNuevaActividad_Click(object sender, EventArgs e)
        {

        }



        //btnLimpiar
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
            MostrarTodas();
        }

        private void frmActividades_Click(object sender, EventArgs e)
        {

        }

        //btnNuevaActividad
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
            // Validaciones
            if (!(cmbTipo.SelectedValue is int))
            { MessageBox.Show("Selecciona un Tipo de Actividad.", "Aviso"); return; }

            if (!(cmbMinisterio.SelectedValue is int))
            { MessageBox.Show("Selecciona un Ministerio.", "Aviso"); return; }

            if (!(cmbLugar.SelectedValue is int))
            { MessageBox.Show("Selecciona un Lugar.", "Aviso"); return; }

            if (!(cmbHorario.SelectedValue is int))
            { MessageBox.Show("Selecciona un tipo de Horario.", "Aviso"); return; }

            if (dtpInicio.Visible && dtpInicio.Value.TimeOfDay >= dtpFinalizacion.Value.TimeOfDay)
            { MessageBox.Show("La hora de inicio debe ser menor a la hora de finalización.", "Aviso"); return; }

            // 1. Leer valores básicos
            int idTipo = (int)cmbTipo.SelectedValue;
            int idMinisterio = (int)cmbMinisterio.SelectedValue;
            int idLugar = (int)cmbLugar.SelectedValue;
            int? idTipoDuracion = (cmbHorario.SelectedValue is int d) ? d : (int?)null;
            int? idAnfitrion = (cmbAnfitrion.Visible && cmbAnfitrion.SelectedValue is int a) ? a : (int?)null;

            // 2. Lógica Refinada para las Horas
            TimeSpan? horaInicio = null;
            TimeSpan? horaFin = null;

            // Solo tomamos el tiempo de los DTP si están visibles (es decir, si NO es Indefinido)
            if (dtpInicio.Visible)
            {
                horaInicio = dtpInicio.Value.TimeOfDay;
                horaFin = dtpFinalizacion.Value.TimeOfDay;
            }

            try
            {
                // 3. Llamada al Negocio
                objNeg.InsertarActividad(
                    idMinisterio,
                    idTipo,
                    dtpDel.Value.Date, // Asegúrate de que dtpDel sea el de la fecha de la actividad
                    idTipoDuracion,
                    horaInicio,
                    horaFin,
                    idLugar,
                    idAnfitrion
                );

                MessageBox.Show("✅ Actividad guardada correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpieza y refresco
                btnNuevaActividad.Text = "Nueva Actividad";
                btnNuevaActividad.Tag = null;
                MostrarTodas();
            }
            catch (Exception ex)
            {
                // El error probablemente viene de aquí si los parámetros no aceptan nulos
                MessageBox.Show("❌ Error al guardar: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //cmbHorario
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
            else
            {
                dtpInicio.Visible = false;
                dtpFinalizacion.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
            }
        }

        private void dg1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbLugar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLugar.SelectedValue is int idLugar)
            {
                // Busca si ese lugar requiere anfitrión
                DataTable dt = objNeg.MostrarLugares();
                DataRow[] filas = dt.Select("ID = " + idLugar);

                bool requiereAnfitrion = filas.Length > 0
                    && Convert.ToBoolean(filas[0]["Requiere_Anfitrion"]);

                cmbAnfitrion.Visible = requiereAnfitrion;
                label4.Visible = requiereAnfitrion;
                // Si no requiere, limpia la selección
                if (!requiereAnfitrion)
                    cmbAnfitrion.SelectedIndex = 0;
            }
            else
            {
                // Fila vacía — ocultar anfitrión
                cmbAnfitrion.Visible = false;
                label4.Visible = false;
            }
        }
    }
}