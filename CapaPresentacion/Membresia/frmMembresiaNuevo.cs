using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion.Membresia
{
    public partial class frmMembresiaNuevo : Form
    {
        public frmMembresiaNuevo()
        {
            InitializeComponent();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void formato()
        {
            dgMiembros.Columns[0].Visible = false; // Oculta la columna ID_Miembro
            dgMiembros.Columns[1].Width = 150; // Nombres


        }

        private void frmMembresiaNuevo_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            formato();
        }

        private void CargarGrilla()
        {
            try
            {
                CN_Miembros objLogica = new CN_Miembros();
                dgMiembros.DataSource = objLogica.MostrarMiembros();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgMiembros_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgMiembros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNombre.Text = Convert.ToString(dgMiembros.CurrentRow.Cells["Nombres"].Value);
                txtApellidos.Text = Convert.ToString(dgMiembros.CurrentRow.Cells["Apellidos"].Value);
                txtTelefono.Text = Convert.ToString(dgMiembros.CurrentRow.Cells["Teléfono"].Value);
                //dtpFechaNacimiento.Value = Convert.ToDateTime(dgMiembros.CurrentRow.Cells["FechaNacimiento"].Value);
                tabMembresia.SelectedIndex = 1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tabMembresia.SelectedIndex = 1;

        }
    }
}
