using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmMembresia : Form
    {
        public frmMembresia()
        {
            InitializeComponent();
        }

        private void frmMembresia_Load(object sender, EventArgs e)
        {
            CargarGrilla();
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

        private void label3_Click(object sender, EventArgs e)
        {
            // Vacio
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmRegistrar formRegistro = new frmRegistrar();
            formRegistro.ShowDialog();
            CargarGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgMiembros.SelectedRows.Count > 0)
            {
                int idSeleccionado = Convert.ToInt32(dgMiembros.CurrentRow.Cells["ID_Miembro"].Value);
                frmRegistrar formRegistro = new frmRegistrar(idSeleccionado);
                formRegistro.ShowDialog();
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione toda la fila del miembro que desea editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgMiembros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}