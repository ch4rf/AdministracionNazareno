using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CapaPresentacion.Mantenimiento
{
    public partial class MantenimientoCatalogos : Form
    {
        public MantenimientoCatalogos()
        {
            InitializeComponent();
        }

        private void MantenimientoCatalogos_Load(object sender, EventArgs e)
        {
            // Llenamos el ComboBox a mano con los nombres de los catálogos
            cmbCatalogos.Items.Add("Profesiones");
            cmbCatalogos.Items.Add("Motivos de Retiro");
            cmbCatalogos.Items.Add("Tipos de Recepción");
            cmbCatalogos.Items.Add("Ministerios");

            // Seleccionamos el primero por defecto
            cmbCatalogos.SelectedIndex = 0;
        }

        // Función maestra para cargar los datos dependiendo de qué catálogo esté seleccionado
        private void ActualizarGrilla()
        {
            try
            {
                string seleccion = cmbCatalogos.SelectedItem.ToString();

                if (seleccion == "Profesiones")
                {
                    CN_Catalogo logica = new CN_Catalogo();
                    dgDatos.DataSource = logica.Mostrar();
                }
                else if (seleccion == "Motivos de Retiro")
                {
                    // CL_MotivosRetiro logica = new CL_MotivosRetiro();
                    // dgvDatos.DataSource = logica.Mostrar();
                }
                // ... (agregar los demás else if)

                // Limpiamos la caja de texto cada vez que cambiamos de tabla
                txtDescripcion.Clear();
                //idSeleccionado = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbCatalogos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }
    }
}
