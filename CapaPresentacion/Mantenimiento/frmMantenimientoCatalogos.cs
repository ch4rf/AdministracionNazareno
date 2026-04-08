using CapaDatos;
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
    public partial class frmMantenimientoCatalogos : Form
    {
        private string idSeleccionado = "";

        public frmMantenimientoCatalogos()
        {
            InitializeComponent();
        }

        private void MantenimientoCatalogos_Load(object sender, EventArgs e)
        {

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
                    CN_Profesiones logica = new CN_Profesiones();
                    dgDatos.DataSource = logica.Mostrar();
                }
                else if (seleccion == "Motivos de Retiro")
                {
                    CN_MotivosRetiro logica = new CN_MotivosRetiro();
                    dgDatos.DataSource = logica.Mostrar();
                }
                else if (seleccion == "Ministerios")
                {
                    CN_Ministerios logica = new CN_Ministerios();
                    dgDatos.DataSource = logica.Mostrar();
                }
                else if (seleccion == "Tipos de Recepción")
                {
                    CN_TiposRecepcion logica = new CN_TiposRecepcion();
                    dgDatos.DataSource = logica.Mostrar();
                }
                // ... (agregar los demás else if)

                // Limpiamos la caja de texto cada vez que cambiamos de tabla
                txtDescripcion.Clear();
                idSeleccionado = "";
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

        private void dgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnGuardarNuevo_Click(object sender, EventArgs e)
        {
            // Validar que no envíen el texto vacío
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("La descripción no puede estar vacía.");
                return;
            }

            try
            {
                string seleccion = cmbCatalogos.SelectedItem.ToString();

                // Lógica para Profesiones
                if (seleccion == "Profesiones")
                {
                    CN_Profesiones logica = new CN_Profesiones();

                    if (idSeleccionado == "") // ES NUEVO
                    {
                        logica.Insertar(txtDescripcion.Text);
                        MessageBox.Show("Profesión agregada correctamente.");
                    }
                    else // ESTÁ EDITANDO
                    {
                        logica.Editar(Convert.ToInt32(idSeleccionado), txtDescripcion.Text);
                        MessageBox.Show("Profesión actualizada.");
                    }
                }
                else if (seleccion == "Motivos de Retiro") // AGREGAS ESTO
                {
                    CN_MotivosRetiro logica = new CN_MotivosRetiro();

                    if (idSeleccionado == "") // ES NUEVO
                    {
                        logica.Insertar(txtDescripcion.Text);
                        MessageBox.Show("Motivo de retiro agregado.");
                    }
                    else // ESTÁ EDITANDO
                    {
                        logica.Editar(Convert.ToInt32(idSeleccionado), txtDescripcion.Text);
                        MessageBox.Show("Motivo de retiro actualizado.");
                    }
                }
                else if (seleccion == "Ministerios") // AGREGAS ESTO
                {
                    CN_Ministerios logica = new CN_Ministerios();

                    if (idSeleccionado == "") // ES NUEVO
                    {
                        logica.Insertar(txtDescripcion.Text);
                        MessageBox.Show("Ministerio nuevo agregado.");
                    }
                    else // ESTÁ EDITANDO
                    {
                        logica.Editar(Convert.ToInt32(idSeleccionado), txtDescripcion.Text);
                        MessageBox.Show("Ministerio actualizado.");
                    }
                }
                else if (seleccion == "Tipos de Recepción") // AGREGAS ESTO
                {
                    CN_TiposRecepcion logica = new CN_TiposRecepcion();

                    if (idSeleccionado == "") // ES NUEVO
                    {
                        logica.Insertar(txtDescripcion.Text);
                        MessageBox.Show("Tipo de recepción nueva agregada.");
                    }
                    else // ESTÁ EDITANDO
                    {
                        logica.Editar(Convert.ToInt32(idSeleccionado), txtDescripcion.Text);
                        MessageBox.Show("Tipo de recepción actualizada.");
                    }
                }

                // Refrescamos la tabla y limpiamos el texto
                ActualizarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btnGuardarNuevo.Text = "Guardar Nuevo";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == "")
            {
                MessageBox.Show("Seleccione un registro de la lista para eliminar.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("¿Está seguro de eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    string seleccion = cmbCatalogos.SelectedItem.ToString();

                    if (seleccion == "Profesiones")
                    {
                        CN_Profesiones logica = new CN_Profesiones();
                        logica.Eliminar(Convert.ToInt32(idSeleccionado));
                    }
                    else if (seleccion == "Motivos de Retiro") // AGREGAS ESTO
                    {
                        CN_MotivosRetiro logica = new CN_MotivosRetiro();
                        logica.Eliminar(Convert.ToInt32(idSeleccionado));
                    }
                    else if (seleccion == "Ministerios") // AGREGAS ESTO
                    {
                        CN_Ministerios logica = new CN_Ministerios();
                        logica.Eliminar(Convert.ToInt32(idSeleccionado));
                    }
                    else if (seleccion == "Tipos de Recepción") // AGREGAS ESTO
                    {
                        CN_TiposRecepcion logica = new CN_TiposRecepcion();
                        logica.Eliminar(Convert.ToInt32(idSeleccionado));
                    }

                    MessageBox.Show("Registro eliminado.");
                    ActualizarGrilla();
                }
                catch (Exception ex)
                {
                    // Aquí atrapará tu mensaje de error 547 personalizado
                    MessageBox.Show(ex.Message, "No se pudo eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            btnGuardarNuevo.Text = "Guardar Nuevo";
            txtDescripcion.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // 1. Limpiamos el texto visualmente
            txtDescripcion.Clear();

            // 2. MATAMOS AL FANTASMA: Vaciamos la variable global
            idSeleccionado = "";

            // 3. (Opcional pero elegante) Ponemos el cursor parpadeando ahí
            txtDescripcion.Focus();

            btnGuardarNuevo.Text = "Guardar Nuevo";
        }


        private void dgDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Si no hizo clic en los títulos
            {
                // Guardamos el ID (suponiendo que está en la columna 0)
                idSeleccionado = dgDatos.Rows[e.RowIndex].Cells[0].Value.ToString();

                // Ponemos la descripción en el TextBox (suponiendo que está en la columna 1)
                txtDescripcion.Text = dgDatos.Rows[e.RowIndex].Cells[1].Value.ToString();
            }

            btnGuardarNuevo.Text = "Actualizar";
        }
    }
}
