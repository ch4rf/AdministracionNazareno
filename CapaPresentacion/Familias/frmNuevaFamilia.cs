using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CapaNegocio; // Importante para usar CN_Familias

namespace CapaPresentacion.Familias
{
    public partial class frmNuevaFamilia : Form
    {
        CN_Familias objetoCN = new CN_Familias();
        public frmNuevaFamilia()
        {
            InitializeComponent();
        }

        private void btnGuardarFam_Click(object sender, EventArgs e)
        {
            try
            {
                // Enviamos los datos a la Capa de Negocio
                objetoCN.GuardarNuevaFamilia(
                    txtPrimerApe.Text,
                    txtSegundoApe.Text,
                    txtNombreFam.Text,
                    txtDireccionFam.Text
                );

                MessageBox.Show("¡Familia guardada con éxito!", "Sistema Iglesia", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Opcional: Limpiar o cerrar el formulario
                Limpiar();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar la familia por: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPrimerApe_TextChanged(object sender, EventArgs e)
        {
            GenerarNombreFamilia();
        }

        private void txtSegundoApe_TextChanged(object sender, EventArgs e)
        {
            GenerarNombreFamilia();
        }
        private void GenerarNombreFamilia()
        {
            // Unimos los apellidos y quitamos espacios extra
            string ape1 = txtPrimerApe.Text.Trim();
            string ape2 = txtSegundoApe.Text.Trim();

            if (string.IsNullOrEmpty(ape1) && string.IsNullOrEmpty(ape2))
            {
                txtNombreFam.Text = "";
            }
            else
            {
                // Formato: Familia Apellido1 Apellido2
                txtNombreFam.Text = $"Familia {ape1} {ape2}".Trim();
            }
        }
        private void Limpiar()
        {
            txtPrimerApe.Clear();
            txtSegundoApe.Clear();
            txtNombreFam.Clear();
            txtDireccionFam.Clear();
            txtPrimerApe.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Close();
        }
    }
}
