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

        private void dgMinisterios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1. Verificamos que no haya hecho clic en los títulos de las columnas (índice -1)
            if (e.RowIndex >= 0)
            {
                // 2. Extraemos el ID del ministerio de la fila seleccionada
                // Suponiendo que la columna 0 es el ID_Ministerio oculto
                int idMinisterio = Convert.ToInt32(dgMinisterios.Rows[e.RowIndex].Cells[0].Value);
                CN_Miembros objLogica = new CN_Miembros();


                // 4. Llenamos el Grid de la derecha al instante
                dgMiembros.DataSource = objLogica.MostrarMiembrosPorMinisterio(idMinisterio);
            }
        }

    }
}
