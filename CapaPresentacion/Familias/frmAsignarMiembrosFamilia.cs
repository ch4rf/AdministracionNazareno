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
    public partial class frmAsignarMiembrosFamilia : Form
    {
        private CN_Miembros objCN = new CN_Miembros();
        private DataTable tablaAsignados = new DataTable();
        private int _idFamilia;
        private string _ape1, _ape2; // Guardamos los apellidos de la familia

        public frmAsignarMiembrosFamilia(int idFamilia, string apellido1, string apellido2)
        {
            InitializeComponent();
            this._idFamilia = idFamilia;
            this._ape1 = apellido1;
            this._ape2 = apellido2;
        }

        private void frmAsignarMiembrosFamilia_Load(object sender, EventArgs e)
        {
            ConfigurarTablaTemporal();
            lblMostrar.Text = $"Mostrando personas con apellidos {_ape1} u {_ape2}"; 
            // Esto llamará a la base de datos buscando miembros que coincidan con uno u otro
            dgMiembrosAsignar.DataSource = objCN.BuscarMiembrosSinFamilia(_ape1, _ape2, ""); //
        }
        private void ConfigurarTablaTemporal()
        {
            // Creamos la estructura para el grid de abajo (dgMiembrosAsignados)
            if (tablaAsignados.Columns.Count == 0)
            {
                tablaAsignados.Columns.Add("ID");
                tablaAsignados.Columns.Add("Nombre");
                tablaAsignados.Columns.Add("Apellido");
                tablaAsignados.Columns.Add("Rol");
            }
            dgMiembrosAsignados.DataSource = tablaAsignados;
        }

        private void txtBuscarMiembros_TextChanged(object sender, EventArgs e)
        {
            // Ahora busca por NOMBRE dentro de los apellidos de la familia
            dgMiembrosAsignar.DataSource = objCN.BuscarMiembrosSinFamilia(_ape1, _ape2, txtBuscarMiembros.Text);
        }

        private void dgMiembrosAsignar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Extraemos datos asegurándote que los nombres coincidan con el SP de SQL
                string id = dgMiembrosAsignar.CurrentRow.Cells["ID"].Value.ToString();
                string nom = dgMiembrosAsignar.CurrentRow.Cells["Nombre"].Value.ToString();
                string ape = dgMiembrosAsignar.CurrentRow.Cells["Apellido"].Value.ToString();
                string rol = dgMiembrosAsignar.CurrentRow.Cells["Rol"].Value.ToString();

                foreach (DataRow row in tablaAsignados.Rows)
                {
                    if (row["ID"].ToString() == id) return;
                }

                tablaAsignados.Rows.Add(id, nom, ape, rol);
                ActualizarContador();
            }
        }
        private void ActualizarContador()
        {
            lblSeleccionados.Text = tablaAsignados.Rows.Count.ToString() + " Seleccionados";
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (tablaAsignados.Rows.Count == 0)
            {
                MessageBox.Show("Debes seleccionar al menos a una persona.");
                return;
            }

            try
            {
                // Recorremos la lista de abajo y actualizamos en la base de datos
                foreach (DataRow fila in tablaAsignados.Rows)
                {
                    int idMiem = Convert.ToInt32(fila["ID"]);
                    objCN.VincularMiembroAFamilia(idMiem, _idFamilia);
                }

                MessageBox.Show("¡Miembros asignados correctamente!");
                this.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tablaAsignados.Clear();
            txtBuscarMiembros.Clear();
            ActualizarContador();
        }

        private void lblMostrar_Click(object sender, EventArgs e)
        {

        }
    }
}
