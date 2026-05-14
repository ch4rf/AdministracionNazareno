using CapaNegocio;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CapaPresentacion.Familias
{
    public partial class frmGestionFamilias : Form
    {
        int idFamiliaSeleccionada = 0;
        CN_Familias objetoCN = new CN_Familias();
        private bool seleccionandoFamilia = false;
        public frmGestionFamilias()
        {
            InitializeComponent();
        }

        private void frmGestionFamilias_Load(object sender, EventArgs e)
        {
            RefrescarDatos();
            btnEliminar.Enabled = false;
            btnAsignarMiembros.Enabled = false;
        }

        private void btnAsignarMiembros_Click(object sender, EventArgs e)
        {

            if (idFamiliaSeleccionada > 0)
            {
                // 1. Obtenemos el nombre: "Familia Caal Perez"
                string nombreCompleto = dgFamilias.CurrentRow.Cells[1].Value.ToString();

                // 2. Quitamos la palabra "Familia " para que quede solo "Caal Perez"
                string soloApellidos = nombreCompleto.Replace("Familia ", "").Trim();

                // 3. Dividimos el texto por los espacios en blanco
                string[] partes = soloApellidos.Split(' ');

                string ape1 = "";
                string ape2 = "";

                // Si hay al menos dos palabras (ej: "Caal" y "Perez")
                if (partes.Length >= 2)
                {
                    ape1 = partes[0]; // Caal
                    ape2 = partes[1]; // Perez
                }
                else if (partes.Length == 1)
                {
                    ape1 = partes[0];
                }

                // 4. Ahora sí mandamos los apellidos por separado al constructor
                frmAsignarMiembrosFamilia frm = new frmAsignarMiembrosFamilia(idFamiliaSeleccionada, ape1, ape2);

                frm.ShowDialog();

                CargarMiembrosDeLaFamilia(idFamiliaSeleccionada);
            }
        }

        private void btnAgregarFamilia_Click(object sender, EventArgs e)
        {
            frmNuevaFamilia ventana = new frmNuevaFamilia();
            ventana.ShowDialog();
            RefrescarDatos();
        }


        public void RefrescarDatos()
        {
            try
            {
                // dgFamilias es el nombre de tu DataGridView
                dgFamilias.DataSource = objetoCN.MostrarFamilias();

                // Opcional: Ajustar el ancho de las columnas automáticamente
                dgFamilias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las familias: " + ex.Message);
            }
        }

        private void dgFamilias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // 1. Tu lógica actual
                idFamiliaSeleccionada = Convert.ToInt32(dgFamilias.Rows[e.RowIndex].Cells["ID"].Value);
                CargarMiembrosDeLaFamilia(idFamiliaSeleccionada);

                // 2. NUEVA LÍNEA: Avisamos al formulario que seleccionamos una familia
                seleccionandoFamilia = true;
                btnEliminar.Enabled = true;
                btnAsignarMiembros.Enabled = true;
            }
        }
        private void CargarMiembrosDeLaFamilia(int id)
        {
            CN_Miembros objMiembros = new CN_Miembros();
            // dgvDetalleMiembros es el nombre de tu Grid de la derecha
            dgMiembrosFamilia.DataSource = objMiembros.FiltrarMiembrosPorFamilia(id);
        }

        private void dgMiembrosFamilia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validamos que el clic sea en una fila válida (no en el encabezado)
            if (e.RowIndex >= 0)
            {
                // Al seleccionar una fila, activamos el botón
                btnEliminar.Enabled = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Usamos el nombre real de tu grid: dgMiembrosFamilia
            if (dgMiembrosFamilia.CurrentRow != null)
            {
                // Asegúrate de que el índice [0] sea el ID. 
                // Si tu columna se llama "ID", usa Cells["ID"]
                int idMiembro = Convert.ToInt32(dgMiembrosFamilia.CurrentRow.Cells[0].Value);

                // AQUÍ: Cambia 'objCN' por el nombre del objeto que tú declaraste en tu formulario
                // Si tu objeto se llama 'negocio', usa 'negocio.QuitarMiembro(idMiembro);'
                objetoCN.QuitarMiembro(idMiembro);

                MessageBox.Show("Miembro eliminado correctamente.");

                // Refrescar usando tu método existente
                CargarMiembrosDeLaFamilia(idFamiliaSeleccionada);
            }
        }

        private void btnEliminarFam_Click(object sender, EventArgs e)
        {
            if (dgFamilias.CurrentRow != null) // Asegúrate que sea el nombre de tu Grid de familias
            {
                int idFamilia = Convert.ToInt32(dgFamilias.CurrentRow.Cells["ID"].Value);
                string nombreFamilia = dgFamilias.CurrentRow.Cells["Nombre de Familia"].Value.ToString();

                // 1. Preguntar si está seguro
                DialogResult confirmacion = MessageBox.Show(
                    $"¿Está seguro de eliminar a la {nombreFamilia}?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    // 2. Llamar a la capa de negocio
                    string resultado = objetoCN.BorrarFamilia(idFamilia);

                    if (resultado == "OK")
                    {
                        MessageBox.Show("Familia eliminada correctamente.");
                        RefrescarDatos();
                    }
                    else
                    {
                        // 3. Si tiene miembros, lanzamos el aviso
                        MessageBox.Show(resultado, "Acción no permitida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void gbFamilias_Enter(object sender, EventArgs e)
        {

        }
    }
}
