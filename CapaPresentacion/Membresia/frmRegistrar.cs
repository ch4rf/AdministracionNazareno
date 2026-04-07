using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmRegistrar : Form
    {
        // Variable global para saber en qué modo estamos trabajando
        private int idMiembro = 0;

        // Constructor 1: Se ejecuta cuando presionas NUEVO
        public frmRegistrar()
        {
            InitializeComponent();
            idMiembro = 0; // 0 significa que vamos a insertar un registro nuevo
        }

        // Constructor 2: Se ejecuta cuando presionas EDITAR
        public frmRegistrar(int idSeleccionado)
        {
            InitializeComponent();
            idMiembro = idSeleccionado; // Guardamos el ID que viene de la grilla

            // Aquí en el futuro llamaremos a un método que busque los datos de este ID 
            // en la base de datos y llene los TextBoxes automáticamente.
        }

        private void frmRegistrar_Load(object sender, EventArgs e)
        {
            if (idMiembro != 0)
            {
                // MODO EDICIÓN: Cambiamos el título de la ventana para que el usuario lo sepa
                this.Text = "Editar Miembro - ID: " + idMiembro.ToString();
            }
            else
            {
                // MODO NUEVO
                this.Text = "Registrar Nuevo Miembro";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
