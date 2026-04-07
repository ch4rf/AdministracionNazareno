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
    public partial class frmMinisterios : Form
    {
        public frmMinisterios()
        {
            InitializeComponent();
        }

        private void frmMinisterios_Load(object sender, EventArgs e)
        {
            try
            {
                CN_Miembros objLogica = new CN_Miembros();
                dgMinisterios.DataSource = objLogica.MostrarMinisterios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
