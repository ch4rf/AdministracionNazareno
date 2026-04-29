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

            btnRegresar.Visible = false;

            // Ocultar al inicio
            txtBuscar.Visible = false;
            lbl1.Visible = false; // lbl1 — cambia por el nombre real
            lbl5.Visible = false; // lbl5 — cambia por el nombre real  
            dtpAl.Visible = false;


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

            // cmbHorario — SIN fila vacía, todas son opciones válidas
            DataTable dtDuracion = objNeg.MostrarTiposDuracion();
                dtDuracion.Rows.InsertAt(dtDuracion.NewRow(), 0);
            cmbHorario.DataSource = null;
            cmbHorario.DataSource = dtDuracion;
            cmbHorario.DisplayMember = "Descripcion";
            cmbHorario.ValueMember = "ID";
            cmbHorario.SelectedIndex = 0; // selecciona la primera (Hora, ID=1)

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

        private bool filtrosVisibles = false;

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            filtrosVisibles = !filtrosVisibles;

            // Solo muestra/oculta estos 5 controles
            lbl1.Visible = filtrosVisibles; // Buscar
            txtBuscar.Visible = filtrosVisibles;
            lbl5.Visible = filtrosVisibles; // Al
            dtpAl.Visible = filtrosVisibles;

            // btnNuevaActividad se oculta cuando los filtros están visibles
            btnNuevaActividad.Visible = !filtrosVisibles;

            btnBuscar.Text = filtrosVisibles ? "🔼 Ocultar" : "🔍 Buscar";
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
            label1.Visible = false;
            label2.Visible = false;
            dtpInicio.Visible = false;
            dtpFinalizacion.Visible = false;
        }

        private void frmActividades_Click(object sender, EventArgs e)
        {

        }

        //btnNuevaActividad
        private void btnNuevaActividad_Click_v2(object sender, EventArgs e)
        {
            btnRegresar.Visible = true;
            if (btnNuevaActividad.Tag?.ToString() == "guardando")
            {
                GuardarActividad();
            }
            else if (btnNuevaActividad.Tag?.ToString() == "editando")
            {
                GuardarEdicion();
            }
            else
            {
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

            // Leer valores
            int idTipo = (int)cmbTipo.SelectedValue;
            int idMinisterio = (int)cmbMinisterio.SelectedValue;
            int idLugar = (int)cmbLugar.SelectedValue;
            int idTipoDuracion = (int)cmbHorario.SelectedValue;  // ← ahora es int directo, nunca null
            int? idAnfitrion = (cmbAnfitrion.SelectedValue is int a) ? a : (int?)null;

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
                    idMinisterio, idTipo,
                    dtpDel.Value.Date,
                    idTipoDuracion,
                    horaInicio, horaFin,
                    idLugar, idAnfitrion
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al guardar: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Primero resetea el botón
            btnNuevaActividad.Text = "Nueva Actividad";
            btnNuevaActividad.Tag = null;

            // Luego muestra el mensaje
            MessageBox.Show("✅ Actividad guardada correctamente.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Al último refresca el grid
            MostrarTodas();
        }


        private void GuardarEdicion()
        {
            btnRegresar.Visible = true;
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

            int idTipo = (int)cmbTipo.SelectedValue;
            int idMinisterio = (int)cmbMinisterio.SelectedValue;
            int idLugar = (int)cmbLugar.SelectedValue;
            int idTipoDuracion = (int)cmbHorario.SelectedValue;
            int? idAnfitrion = (cmbAnfitrion.SelectedValue is int a) ? a : (int?)null;

            TimeSpan? horaInicio = dtpInicio.Visible ? dtpInicio.Value.TimeOfDay : (TimeSpan?)null;
            TimeSpan? horaFin = dtpFinalizacion.Visible ? dtpFinalizacion.Value.TimeOfDay : (TimeSpan?)null;

            try
            {
                objNeg.EditarActividad(
                    idActividadEditando,
                    idMinisterio, idTipo,
                    dtpDel.Value.Date,
                    idTipoDuracion,
                    horaInicio, horaFin,
                    idLugar, idAnfitrion
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al editar: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnNuevaActividad.Text = "Nueva Actividad";
            btnNuevaActividad.Tag = null;
            idActividadEditando = 0;

            MessageBox.Show("✅ Actividad actualizada correctamente.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            MostrarTodas();
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                MostrarTodas();
            }
            else
            {
                DataTable dt = objNeg.BuscarActividades(
                    txtBuscar.Text,
                    null, null, null, null,
                    new DateTime(2000, 1, 1),
                    new DateTime(2099, 12, 31),
                    null, null
                );
                MostrarAgrupado(dt);
            }
        }

        //evento doble click para editar el dg1
        private int idActividadEditando = 0;
        private void dg1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnRegresar.Visible = true;
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dg1.Rows[e.RowIndex];

            // Si es fila de encabezado de fecha, ignorar
            if (fila.Tag?.ToString() == "encabezado") return;

            // Si la celda ID está vacía, ignorar
            if (fila.Cells["colID"].Value == null || fila.Cells["colID"].Value.ToString() == "") return;

            // Guardar el ID
            idActividadEditando = Convert.ToInt32(fila.Cells["colID"].Value);

            // ── Cargar fecha ──────────────────────────────────────────
            if (fila.Cells["colFecha"].Value != null)
                dtpDel.Value = Convert.ToDateTime(fila.Cells["colFecha"].Value);

            // ── Cargar Tipo ───────────────────────────────────────────
            string tipo = fila.Cells["colTipo"].Value?.ToString();
            foreach (DataRowView drv in cmbTipo.Items)
            {
                if (drv.Row["Descripcion"]?.ToString() == tipo)
                {
                    cmbTipo.SelectedItem = drv;
                    break;
                }
            }

            // ── Cargar Ministerio ─────────────────────────────────────
            string ministerio = fila.Cells["colMinisterio"].Value?.ToString();
            foreach (DataRowView drv in cmbMinisterio.Items)
            {
                if (drv.Row["Nombre"]?.ToString() == ministerio)
                {
                    cmbMinisterio.SelectedItem = drv;
                    break;
                }
            }

            // ── Cargar Duración / Horario ─────────────────────────────
            string duracion = fila.Cells["colDuracion"].Value?.ToString();
            foreach (DataRowView drv in cmbHorario.Items)
            {
                if (drv.Row["Descripcion"]?.ToString() == duracion)
                {
                    cmbHorario.SelectedItem = drv;
                    break;
                }
            }

            // ── Cargar Horas si están disponibles ─────────────────────
            if (fila.Cells["colHoraInicio"].Value != null &&
                fila.Cells["colHoraInicio"].Value.ToString() != "")
            {
                TimeSpan horaInicio = TimeSpan.Parse(fila.Cells["colHoraInicio"].Value.ToString());
                dtpInicio.Value = DateTime.Today.Add(horaInicio);
            }

            if (fila.Cells["colHoraFin"].Value != null &&
                fila.Cells["colHoraFin"].Value.ToString() != "")
            {
                TimeSpan horaFin = TimeSpan.Parse(fila.Cells["colHoraFin"].Value.ToString());
                dtpFinalizacion.Value = DateTime.Today.Add(horaFin);
            }

            // ── Cargar Lugar ──────────────────────────────────────────
            string lugar = fila.Cells["colLugar"].Value?.ToString();
            foreach (DataRowView drv in cmbLugar.Items)
            {
                if (drv.Row["Nombre"]?.ToString() == lugar)
                {
                    cmbLugar.SelectedItem = drv;
                    break;
                }
            }

            // ── Cargar Anfitrión ──────────────────────────────────────
            string anfitrion = fila.Cells["colAnfitrion"].Value?.ToString();
            if (anfitrion != "Sin anfitrión" && anfitrion != "")
            {
                foreach (DataRowView drv in cmbAnfitrion.Items)
                {
                    if (drv.Row["Nombres"]?.ToString() == anfitrion)
                    {
                        cmbAnfitrion.SelectedItem = drv;
                        break;
                    }
                }
            }

            // ── Cambiar botón a modo editar ───────────────────────────
            btnNuevaActividad.Text = "💾 Guardar Cambios";
            btnNuevaActividad.Tag = "editando";
            btnNuevaActividad.Visible = true;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            // Limpiar campos
            txtBuscar.Clear();
            cmbTipo.SelectedIndex = 0;
            cmbMinisterio.SelectedIndex = 0;
            cmbLugar.SelectedIndex = 0;
            cmbAnfitrion.SelectedIndex = 0;
            cmbHorario.SelectedIndex = 0;
            dtpDel.Value = DateTime.Today;
            dtpAl.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month,
                                    DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month));
            dtpInicio.Value = DateTime.Today;
            dtpFinalizacion.Value = DateTime.Today.AddHours(23).AddMinutes(59);

            // Resetear variable de edición
            idActividadEditando = 0;

            // Resetear botón Nueva Actividad
            btnNuevaActividad.Text = "Nueva Actividad";
            btnNuevaActividad.Tag = null;
            btnNuevaActividad.Visible = true;

            // Resetear btnBuscar
            filtrosVisibles = false;
            btnBuscar.Text = "🔍 Buscar";

            // Ocultar todo lo que inicia oculto
            lbl1.Visible = false;
            txtBuscar.Visible = false;
            lbl5.Visible = false;
            dtpAl.Visible = false;
            dtpInicio.Visible = false;
            dtpFinalizacion.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            cmbAnfitrion.Visible = false;
            label4.Visible = false;

            // Refrescar el grid con todas las actividades
            MostrarTodas();

            btnRegresar.Visible = false;
        }
    }
}