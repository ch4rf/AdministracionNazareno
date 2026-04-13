using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CapaPresentacion.Familias
{
    public partial class frmEditarMiembroFamilia : Form
    {
        private int idMiembroEditando;
        private CN_Familias negocio = new CN_Familias();

        public frmEditarMiembroFamilia(int id, string nom, string ape, string rol, string tel)
        {
            InitializeComponent();
            idMiembroEditando = id;
            txtNombres.Text = nom;
            txtApellidos.Text = ape;
            txtRole.Text = rol;
            txtTelefono.Text= tel;
            
        }

        private void frmEditarMiembroFamilia_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                // Asegúrate de que este método tenga los 5 parámetros en la capa de negocio
                negocio.EditarMiembro(idMiembroEditando, txtNombres.Text, txtApellidos.Text, txtRole.Text, txtTelefono.Text);
                MessageBox.Show("Guardado con éxito");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
