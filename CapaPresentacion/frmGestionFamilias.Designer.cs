namespace CapaPresentacion
{
    partial class frmGestionFamilias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbDatosFamilia = new GroupBox();
            cmbEstado = new ComboBox();
            lblEstado = new Label();
            txtTelefonoFamiliar = new TextBox();
            lblTelefonoFamiliar = new Label();
            cmbDepartamento = new ComboBox();
            txtMunicipio = new TextBox();
            txtDireccion = new TextBox();
            lblDepartamento = new Label();
            lblMunicipio = new Label();
            lblDireccion = new Label();
            txtCodigoFamilia = new TextBox();
            lblCodigoFamilia = new Label();
            textBox1 = new TextBox();
            lblNombrefamilia = new Label();
            gbMiembros = new GroupBox();
            dgvDetalle = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            lblTotal = new Label();
            lblVisitas = new Label();
            lblActivos = new Label();
            lblBuscarMiembros = new Label();
            txtBuscarMiembro = new TextBox();
            lblRol = new Label();
            cmbRol = new ComboBox();
            btnAgregarLista = new Button();
            gbNotas = new GroupBox();
            txtNotas = new TextBox();
            btnGuardartodo = new Button();
            button1 = new Button();
            gbDatosFamilia.SuspendLayout();
            gbMiembros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            gbNotas.SuspendLayout();
            SuspendLayout();
            // 
            // gbDatosFamilia
            // 
            gbDatosFamilia.Controls.Add(cmbEstado);
            gbDatosFamilia.Controls.Add(lblEstado);
            gbDatosFamilia.Controls.Add(txtTelefonoFamiliar);
            gbDatosFamilia.Controls.Add(lblTelefonoFamiliar);
            gbDatosFamilia.Controls.Add(cmbDepartamento);
            gbDatosFamilia.Controls.Add(txtMunicipio);
            gbDatosFamilia.Controls.Add(txtDireccion);
            gbDatosFamilia.Controls.Add(lblDepartamento);
            gbDatosFamilia.Controls.Add(lblMunicipio);
            gbDatosFamilia.Controls.Add(lblDireccion);
            gbDatosFamilia.Controls.Add(txtCodigoFamilia);
            gbDatosFamilia.Controls.Add(lblCodigoFamilia);
            gbDatosFamilia.Controls.Add(textBox1);
            gbDatosFamilia.Controls.Add(lblNombrefamilia);
            gbDatosFamilia.Location = new Point(12, 12);
            gbDatosFamilia.Name = "gbDatosFamilia";
            gbDatosFamilia.Size = new Size(776, 149);
            gbDatosFamilia.TabIndex = 0;
            gbDatosFamilia.TabStop = false;
            gbDatosFamilia.Text = "Datos de la Familia";
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Activa ", "Inactiva", "En visita" });
            cmbEstado.Location = new Point(586, 108);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(169, 23);
            cmbEstado.TabIndex = 13;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(530, 111);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(45, 15);
            lblEstado.TabIndex = 12;
            lblEstado.Text = "Estado:";
            // 
            // txtTelefonoFamiliar
            // 
            txtTelefonoFamiliar.Location = new Point(121, 108);
            txtTelefonoFamiliar.Name = "txtTelefonoFamiliar";
            txtTelefonoFamiliar.Size = new Size(149, 23);
            txtTelefonoFamiliar.TabIndex = 11;
            // 
            // lblTelefonoFamiliar
            // 
            lblTelefonoFamiliar.AutoSize = true;
            lblTelefonoFamiliar.Location = new Point(16, 111);
            lblTelefonoFamiliar.Name = "lblTelefonoFamiliar";
            lblTelefonoFamiliar.Size = new Size(99, 15);
            lblTelefonoFamiliar.TabIndex = 10;
            lblTelefonoFamiliar.Text = "Telefono familiar:";
            // 
            // cmbDepartamento
            // 
            cmbDepartamento.FormattingEnabled = true;
            cmbDepartamento.Location = new Point(586, 67);
            cmbDepartamento.Name = "cmbDepartamento";
            cmbDepartamento.Size = new Size(169, 23);
            cmbDepartamento.TabIndex = 9;
            // 
            // txtMunicipio
            // 
            txtMunicipio.Location = new Point(327, 67);
            txtMunicipio.Name = "txtMunicipio";
            txtMunicipio.Size = new Size(144, 23);
            txtMunicipio.TabIndex = 8;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(85, 67);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(149, 23);
            txtDireccion.TabIndex = 7;
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.Location = new Point(489, 70);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(86, 15);
            lblDepartamento.TabIndex = 6;
            lblDepartamento.Text = "Departamento:";
            // 
            // lblMunicipio
            // 
            lblMunicipio.AutoSize = true;
            lblMunicipio.Location = new Point(257, 70);
            lblMunicipio.Name = "lblMunicipio";
            lblMunicipio.Size = new Size(64, 15);
            lblMunicipio.TabIndex = 5;
            lblMunicipio.Text = "Municipio:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(16, 70);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(63, 15);
            lblDireccion.TabIndex = 4;
            lblDireccion.Text = "Direccion: ";
            // 
            // txtCodigoFamilia
            // 
            txtCodigoFamilia.Location = new Point(623, 27);
            txtCodigoFamilia.Name = "txtCodigoFamilia";
            txtCodigoFamilia.Size = new Size(132, 23);
            txtCodigoFamilia.TabIndex = 3;
            // 
            // lblCodigoFamilia
            // 
            lblCodigoFamilia.AutoSize = true;
            lblCodigoFamilia.Location = new Point(501, 30);
            lblCodigoFamilia.Name = "lblCodigoFamilia";
            lblCodigoFamilia.Size = new Size(116, 15);
            lblCodigoFamilia.TabIndex = 2;
            lblCodigoFamilia.Text = "Codigo de la familia:";
            lblCodigoFamilia.Click += label1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(143, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(352, 23);
            textBox1.TabIndex = 1;
            // 
            // lblNombrefamilia
            // 
            lblNombrefamilia.AutoSize = true;
            lblNombrefamilia.Location = new Point(16, 30);
            lblNombrefamilia.Name = "lblNombrefamilia";
            lblNombrefamilia.Size = new Size(121, 15);
            lblNombrefamilia.TabIndex = 0;
            lblNombrefamilia.Text = "Nombre de la familia:";
            lblNombrefamilia.Click += label1_Click;
            // 
            // gbMiembros
            // 
            gbMiembros.Controls.Add(btnAgregarLista);
            gbMiembros.Controls.Add(cmbRol);
            gbMiembros.Controls.Add(lblRol);
            gbMiembros.Controls.Add(txtBuscarMiembro);
            gbMiembros.Controls.Add(lblBuscarMiembros);
            gbMiembros.Controls.Add(lblActivos);
            gbMiembros.Controls.Add(lblVisitas);
            gbMiembros.Controls.Add(dgvDetalle);
            gbMiembros.Controls.Add(lblTotal);
            gbMiembros.Location = new Point(12, 177);
            gbMiembros.Name = "gbMiembros";
            gbMiembros.Size = new Size(776, 193);
            gbMiembros.TabIndex = 1;
            gbMiembros.TabStop = false;
            gbMiembros.Text = "Miembros del nucleo familiar";
            gbMiembros.Enter += gbMiembros_Enter;
            // 
            // dgvDetalle
            // 
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Rol, Telefono });
            dgvDetalle.Location = new Point(143, 59);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.Size = new Size(435, 37);
            dgvDetalle.TabIndex = 4;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Rol
            // 
            Rol.HeaderText = "Rol";
            Rol.Name = "Rol";
            Rol.ReadOnly = true;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(257, 31);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(44, 15);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "TOTAL ";
            // 
            // lblVisitas
            // 
            lblVisitas.AutoSize = true;
            lblVisitas.Location = new Point(397, 31);
            lblVisitas.Name = "lblVisitas";
            lblVisitas.Size = new Size(46, 15);
            lblVisitas.TabIndex = 5;
            lblVisitas.Text = "VISITAS";
            // 
            // lblActivos
            // 
            lblActivos.AutoSize = true;
            lblActivos.Location = new Point(327, 31);
            lblActivos.Name = "lblActivos";
            lblActivos.Size = new Size(55, 15);
            lblActivos.TabIndex = 6;
            lblActivos.Text = "ACTIVOS";
            lblActivos.TextAlign = ContentAlignment.TopCenter;
            lblActivos.Click += label4_Click;
            // 
            // lblBuscarMiembros
            // 
            lblBuscarMiembros.AutoSize = true;
            lblBuscarMiembros.Location = new Point(16, 146);
            lblBuscarMiembros.Name = "lblBuscarMiembros";
            lblBuscarMiembros.Size = new Size(97, 15);
            lblBuscarMiembros.TabIndex = 14;
            lblBuscarMiembros.Text = "Buscar Miembro:";
            // 
            // txtBuscarMiembro
            // 
            txtBuscarMiembro.Location = new Point(119, 143);
            txtBuscarMiembro.Name = "txtBuscarMiembro";
            txtBuscarMiembro.Size = new Size(164, 23);
            txtBuscarMiembro.TabIndex = 14;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(304, 146);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(27, 15);
            lblRol.TabIndex = 15;
            lblRol.Text = "Rol:";
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Padre", "Madre ", "Hija", "Hijo" });
            cmbRol.Location = new Point(337, 143);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(169, 23);
            cmbRol.TabIndex = 14;
            // 
            // btnAgregarLista
            // 
            btnAgregarLista.Location = new Point(530, 135);
            btnAgregarLista.Name = "btnAgregarLista";
            btnAgregarLista.Size = new Size(98, 36);
            btnAgregarLista.TabIndex = 16;
            btnAgregarLista.Text = "+AGREGAR";
            btnAgregarLista.UseVisualStyleBackColor = true;
            // 
            // gbNotas
            // 
            gbNotas.Controls.Add(button1);
            gbNotas.Controls.Add(btnGuardartodo);
            gbNotas.Controls.Add(txtNotas);
            gbNotas.Location = new Point(12, 399);
            gbNotas.Name = "gbNotas";
            gbNotas.Size = new Size(776, 138);
            gbNotas.TabIndex = 2;
            gbNotas.TabStop = false;
            gbNotas.Text = "Notas y Observaciones";
            // 
            // txtNotas
            // 
            txtNotas.Location = new Point(16, 22);
            txtNotas.Multiline = true;
            txtNotas.Name = "txtNotas";
            txtNotas.Size = new Size(739, 63);
            txtNotas.TabIndex = 0;
            // 
            // btnGuardartodo
            // 
            btnGuardartodo.Location = new Point(586, 91);
            btnGuardartodo.Name = "btnGuardartodo";
            btnGuardartodo.Size = new Size(169, 36);
            btnGuardartodo.TabIndex = 17;
            btnGuardartodo.Text = "Guardar Nucleo Familiar";
            btnGuardartodo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(466, 91);
            button1.Name = "button1";
            button1.Size = new Size(114, 36);
            button1.TabIndex = 18;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmGestionFamilias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 555);
            Controls.Add(gbNotas);
            Controls.Add(gbMiembros);
            Controls.Add(gbDatosFamilia);
            ForeColor = SystemColors.ControlText;
            Name = "frmGestionFamilias";
            Text = "Gestión de Núcleos Familiares - Iglesia del Nazareno";
            gbDatosFamilia.ResumeLayout(false);
            gbDatosFamilia.PerformLayout();
            gbMiembros.ResumeLayout(false);
            gbMiembros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            gbNotas.ResumeLayout(false);
            gbNotas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbDatosFamilia;
        private Label lblNombrefamilia;
        private TextBox textBox1;
        private Label lblCodigoFamilia;
        private TextBox txtCodigoFamilia;
        private Label lblTelefonoFamiliar;
        private ComboBox cmbDepartamento;
        private TextBox txtMunicipio;
        private TextBox txtDireccion;
        private Label lblDepartamento;
        private Label lblMunicipio;
        private Label lblDireccion;
        private ComboBox cmbEstado;
        private Label lblEstado;
        private TextBox txtTelefonoFamiliar;
        private GroupBox gbMiembros;
        private Label label3;
        private Label label2;
        private Label lblTotal;
        private DataGridView dgvDetalle;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Rol;
        private DataGridViewTextBoxColumn Telefono;
        private Label lblActivos;
        private Label lblVisitas;
        private ComboBox cmbRol;
        private Label lblRol;
        private TextBox txtBuscarMiembro;
        private Label lblBuscarMiembros;
        private Button btnAgregarLista;
        private GroupBox gbNotas;
        private Button button1;
        private Button btnGuardartodo;
        private TextBox txtNotas;
    }
}