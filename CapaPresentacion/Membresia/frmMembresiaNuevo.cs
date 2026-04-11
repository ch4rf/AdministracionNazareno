using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CapaPresentacion.Membresia
{
    public partial class frmMembresiaNuevo : Form
    {
        // Variable global para saber si insertamos (0) o editamos (>0)
        private int idMiembroSeleccionado = 0;
        private CN_Miembros objMiembros = new CN_Miembros();

        public frmMembresiaNuevo()
        {
            InitializeComponent();
        }

        private void frmMembresiaNuevo_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            CargarCatalogos(); // Llena los ComboBoxes al iniciar
            formato();
        }

        private void formato()
        {
            // Oculta la columna ID (Asumiendo que es la primera)
            if (dgMiembros.Columns.Count > 0)
            {
                dgMiembros.Columns[0].Visible = false;
                dgMiembros.Columns[1].Width = 150; // Nombres
            }
        }

        private void CargarGrilla()
        {
            try
            {
                dgMiembros.DataSource = objMiembros.MostrarMiembros();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCatalogos()
        {
            try
            {
                /* NOTA: Aquí debes llamar a tus otros métodos de la Capa Negocio 
                   para llenar cada ComboBox. Ejemplo:
                   
                   cmbGenero.DataSource = objCatalogos.MostrarGeneros();
                   cmbGenero.DisplayMember = "Descripcion";
                   cmbGenero.ValueMember = "ID";
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar listas desplegables: " + ex.Message);
            }
        }

        // =========================================================
        // BOTÓN NUEVO
        // =========================================================
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            idMiembroSeleccionado = 0;
            LimpiarFormulario();
            tabMembresia.SelectedIndex = 1; // Pestaña de Registro
        }

        // =========================================================
        // DOBLE CLIC EN LA GRILLA (EDICIÓN)
        // =========================================================
        private void dgMiembros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                // 1. Obtener ID de la fila seleccionada
                idMiembroSeleccionado = Convert.ToInt32(dgMiembros.CurrentRow.Cells["ID"].Value);

                // 2. Buscar datos completos en la BD
                DataTable dt = objMiembros.BuscarMiembroPorID(idMiembroSeleccionado);

                if (dt.Rows.Count > 0)
                {
                    DataRow fila = dt.Rows[0];

                    // Cajas de texto
                    txtNombre.Text = fila["Nombres"].ToString();
                    txtApellidos.Text = fila["Apellidos"].ToString();
                    txtDPI.Text = fila["DPI"].ToString();
                    txtTelefono.Text = fila["Telefono"].ToString();
                    txtCorreo.Text = fila["Correo"].ToString();
                    txtCalleAvenida.Text = fila["Calle_Avenida"].ToString();
                    txtReferenciaCasa.Text = fila["Referencia_Casa"].ToString();

                    // ComboBoxes (Se posicionan por el ID)
                    if (fila["ID_Genero"] != DBNull.Value) cmbGenero.SelectedValue = Convert.ToInt32(fila["ID_Genero"]);
                    if (fila["ID_Profesion"] != DBNull.Value) cmbProfesion.SelectedValue = Convert.ToInt32(fila["ID_Profesion"]);
                    if (fila["ID_Familia"] != DBNull.Value) cmbFamilia.SelectedValue = Convert.ToInt32(fila["ID_Familia"]);
                    if (fila["ID_Estado"] != DBNull.Value) cmbEstado.SelectedValue = Convert.ToInt32(fila["ID_Estado"]);
                    if (fila["ID_Motivo_Retiro"] != DBNull.Value) cmbMotivoRetiro.SelectedValue = Convert.ToInt32(fila["ID_Motivo_Retiro"]);
                    if (fila["ID_Recepcion"] != DBNull.Value) cmbTipoRecepcion.SelectedValue = Convert.ToInt32(fila["ID_Recepcion"]);
                    if (fila["ID_Asentamiento"] != DBNull.Value) cmbAsentamiento.SelectedValue = Convert.ToInt32(fila["ID_Asentamiento"]);

                    // Rol Familiar (Texto manual en el combo)
                    if (fila["Rol_Familiar"] != DBNull.Value) cmbRolFamiliar.Text = fila["Rol_Familiar"].ToString();

                    // Calendarios
                    if (fila["Fecha_Nacimiento"] != DBNull.Value) dtpFechaNacimiento.Value = Convert.ToDateTime(fila["Fecha_Nacimiento"]);
                    if (fila["Fecha_Bautismo"] != DBNull.Value) dtpFechaBautismo.Value = Convert.ToDateTime(fila["Fecha_Bautismo"]);
                    if (fila["Fecha_Recepcion"] != DBNull.Value) dtpFechaRecepcion.Value = Convert.ToDateTime(fila["Fecha_Recepcion"]);
                    if (fila["Fecha_Retiro"] != DBNull.Value) dtpFechaRetiro.Value = Convert.ToDateTime(fila["Fecha_Retiro"]);
                }

                tabMembresia.SelectedIndex = 1; // Ir al formulario
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos para editar: " + ex.Message);
            }
        }

        // =========================================================
        // BOTÓN GUARDAR (INSERTAR / EDITAR)
        // =========================================================
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellidos.Text))
            {
                MessageBox.Show("Nombres y Apellidos son obligatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Extraer IDs de los Combos
                int idGen = cmbGenero.SelectedIndex > -1 ? Convert.ToInt32(cmbGenero.SelectedValue) : 0;
                int idProf = cmbProfesion.SelectedIndex > -1 ? Convert.ToInt32(cmbProfesion.SelectedValue) : 0;
                int idFam = cmbFamilia.SelectedIndex > -1 ? Convert.ToInt32(cmbFamilia.SelectedValue) : 0;
                int idEst = cmbEstado.SelectedIndex > -1 ? Convert.ToInt32(cmbEstado.SelectedValue) : 0;
                int idRec = cmbTipoRecepcion.SelectedIndex > -1 ? Convert.ToInt32(cmbTipoRecepcion.SelectedValue) : 0;
                int idMot = cmbMotivoRetiro.SelectedIndex > -1 ? Convert.ToInt32(cmbMotivoRetiro.SelectedValue) : 0;
                int idAse = cmbAsentamiento.SelectedIndex > -1 ? Convert.ToInt32(cmbAsentamiento.SelectedValue) : 0;

                string rol = cmbRolFamiliar.Text;

                if (idMiembroSeleccionado == 0)
                {
                    // INSERTAR (19 Parámetros)
                    objMiembros.InsertarMiembro(idFam, rol, txtDPI.Text, txtNombre.Text, txtApellidos.Text, idGen, dtpFechaNacimiento.Value, idProf, txtTelefono.Text, txtCorreo.Text, dtpFechaBautismo.Value, dtpFechaRecepcion.Value, idRec, idEst, idMot, dtpFechaRetiro.Value, idAse, txtCalleAvenida.Text, txtReferenciaCasa.Text);
                    MessageBox.Show("Miembro registrado con éxito.");
                }
                else
                {
                    // EDITAR (20 Parámetros incluyendo el ID)
                    objMiembros.EditarMiembro(idMiembroSeleccionado, idFam, rol, txtDPI.Text, txtNombre.Text, txtApellidos.Text, idGen, dtpFechaNacimiento.Value, idProf, txtTelefono.Text, txtCorreo.Text, dtpFechaBautismo.Value, dtpFechaRecepcion.Value, idRec, idEst, idMot, dtpFechaRetiro.Value, idAse, txtCalleAvenida.Text, txtReferenciaCasa.Text);
                    MessageBox.Show("Datos actualizados con éxito.");
                }

                LimpiarFormulario();
                CargarGrilla();
                tabMembresia.SelectedIndex = 0; // Regresar a la tabla
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        // =========================================================
        // BOTÓN LIMPIAR
        // =========================================================
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtApellidos.Clear();
            txtDPI.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtCalleAvenida.Clear();
            txtReferenciaCasa.Clear();

            cmbGenero.SelectedIndex = -1;
            cmbProfesion.SelectedIndex = -1;
            cmbFamilia.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
            cmbTipoRecepcion.SelectedIndex = -1;
            cmbMotivoRetiro.SelectedIndex = -1;
            cmbAsentamiento.SelectedIndex = -1;
            cmbRolFamiliar.SelectedIndex = -1;

            dtpFechaNacimiento.Value = DateTime.Now;
            dtpFechaBautismo.Value = DateTime.Now;
            dtpFechaRecepcion.Value = DateTime.Now;
            dtpFechaRetiro.Value = DateTime.Now;
        }
    }
}