namespace CapaPresentacion.Membresia
{
    partial class frmMembresiaNuevo
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
            tabMembresia = new TabControl();
            tabPage1 = new TabPage();
            btnBuscar = new Button();
            btnNuevo = new Button();
            button1 = new Button();
            btnEditar = new Button();
            label4 = new Label();
            cbmFiltro = new ComboBox();
            label2 = new Label();
            txtBuscarNombre = new TextBox();
            dgMiembros = new DataGridView();
            label1 = new Label();
            tabopage2 = new TabPage();
            btnCancelar = new Button();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            groupBox1 = new GroupBox();
            label24 = new Label();
            cmbAsentamiento = new ComboBox();
            cmbTipoRecepcion = new ComboBox();
            cmbRolFamiliar = new ComboBox();
            label23 = new Label();
            label22 = new Label();
            dtpFechaRecepcion = new DateTimePicker();
            label21 = new Label();
            cmbEstado = new ComboBox();
            cmbMotivoRetiro = new ComboBox();
            cmbFamilia = new ComboBox();
            label20 = new Label();
            label19 = new Label();
            cmbProfesion = new ComboBox();
            label14 = new Label();
            cmbGenero = new ComboBox();
            label13 = new Label();
            dtpFechaRetiro = new DateTimePicker();
            dtpFechaBautismo = new DateTimePicker();
            txtReferenciaCasa = new TextBox();
            txtCalleAvenida = new TextBox();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            txtDPI = new TextBox();
            txtApellidos = new TextBox();
            txtNombre = new TextBox();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            button2 = new Button();
            cbmBuscarEstado = new ComboBox();
            cbmBuscarMinisterio = new ComboBox();
            tabMembresia.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgMiembros).BeginInit();
            tabopage2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabMembresia
            // 
            tabMembresia.Controls.Add(tabPage1);
            tabMembresia.Controls.Add(tabopage2);
            tabMembresia.Location = new Point(0, 1);
            tabMembresia.Margin = new Padding(3, 4, 3, 4);
            tabMembresia.Name = "tabMembresia";
            tabMembresia.SelectedIndex = 0;
            tabMembresia.Size = new Size(1663, 1032);
            tabMembresia.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(cbmBuscarMinisterio);
            tabPage1.Controls.Add(cbmBuscarEstado);
            tabPage1.Controls.Add(btnBuscar);
            tabPage1.Controls.Add(btnNuevo);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(btnEditar);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(cbmFiltro);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtBuscarNombre);
            tabPage1.Controls.Add(dgMiembros);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(1655, 999);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "MIEMBROS";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(1185, 128);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 34;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(1026, 843);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(189, 44);
            btnNuevo.TabIndex = 33;
            btnNuevo.Text = "NUEVO REGISTRO";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1219, 775);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(189, 44);
            button1.TabIndex = 31;
            button1.Text = "ACTUALIZAR TABLA";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(1222, 843);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(189, 44);
            btnEditar.TabIndex = 32;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label4.Location = new Point(97, 775);
            label4.Name = "label4";
            label4.Size = new Size(294, 31);
            label4.TabIndex = 30;
            label4.Text = "TOTAL REGISTROS:";
            // 
            // cbmFiltro
            // 
            cbmFiltro.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbmFiltro.FormattingEnabled = true;
            cbmFiltro.Items.AddRange(new object[] { "NOMBRE", "ESTADO", "MINISTERIO" });
            cbmFiltro.Location = new Point(325, 128);
            cbmFiltro.Margin = new Padding(3, 4, 3, 4);
            cbmFiltro.Name = "cbmFiltro";
            cbmFiltro.Size = new Size(253, 40);
            cbmFiltro.TabIndex = 29;
            cbmFiltro.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label2.Location = new Point(94, 137);
            label2.Name = "label2";
            label2.Size = new Size(213, 31);
            label2.TabIndex = 27;
            label2.Text = "BUSCAR POR:";
            // 
            // txtBuscarNombre
            // 
            txtBuscarNombre.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            txtBuscarNombre.Location = new Point(637, 128);
            txtBuscarNombre.Margin = new Padding(3, 4, 3, 4);
            txtBuscarNombre.Name = "txtBuscarNombre";
            txtBuscarNombre.Size = new Size(476, 37);
            txtBuscarNombre.TabIndex = 26;
            txtBuscarNombre.TextChanged += txtBuscar_TextChanged;
            // 
            // dgMiembros
            // 
            dgMiembros.AllowUserToAddRows = false;
            dgMiembros.AllowUserToDeleteRows = false;
            dgMiembros.AllowUserToResizeColumns = false;
            dgMiembros.AllowUserToResizeRows = false;
            dgMiembros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMiembros.Location = new Point(97, 195);
            dgMiembros.Margin = new Padding(3, 4, 3, 4);
            dgMiembros.Name = "dgMiembros";
            dgMiembros.ReadOnly = true;
            dgMiembros.RowHeadersWidth = 51;
            dgMiembros.Size = new Size(1311, 560);
            dgMiembros.TabIndex = 25;
            dgMiembros.CellContentClick += dgMiembros_CellContentClick;
            dgMiembros.CellDoubleClick += dgMiembros_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(85, 31);
            label1.Name = "label1";
            label1.Size = new Size(355, 81);
            label1.TabIndex = 24;
            label1.Text = "MIEMBROS";
            // 
            // tabopage2
            // 
            tabopage2.Controls.Add(btnCancelar);
            tabopage2.Controls.Add(btnLimpiar);
            tabopage2.Controls.Add(btnGuardar);
            tabopage2.Controls.Add(groupBox1);
            tabopage2.Location = new Point(4, 29);
            tabopage2.Margin = new Padding(3, 4, 3, 4);
            tabopage2.Name = "tabopage2";
            tabopage2.Padding = new Padding(3, 4, 3, 4);
            tabopage2.Size = new Size(1655, 999);
            tabopage2.TabIndex = 1;
            tabopage2.Text = "REGISTRAR";
            tabopage2.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(1285, 332);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(1273, 251);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(86, 31);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(1273, 176);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 31);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label24);
            groupBox1.Controls.Add(cmbAsentamiento);
            groupBox1.Controls.Add(cmbTipoRecepcion);
            groupBox1.Controls.Add(cmbRolFamiliar);
            groupBox1.Controls.Add(label23);
            groupBox1.Controls.Add(label22);
            groupBox1.Controls.Add(dtpFechaRecepcion);
            groupBox1.Controls.Add(label21);
            groupBox1.Controls.Add(cmbEstado);
            groupBox1.Controls.Add(cmbMotivoRetiro);
            groupBox1.Controls.Add(cmbFamilia);
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(cmbProfesion);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(cmbGenero);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(dtpFechaRetiro);
            groupBox1.Controls.Add(dtpFechaBautismo);
            groupBox1.Controls.Add(txtReferenciaCasa);
            groupBox1.Controls.Add(txtCalleAvenida);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dtpFechaNacimiento);
            groupBox1.Controls.Add(txtDPI);
            groupBox1.Controls.Add(txtApellidos);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(label18);
            groupBox1.Location = new Point(55, 25);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1103, 797);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "INFORMACION DE IDENTIDAD";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(738, 427);
            label24.Name = "label24";
            label24.Size = new Size(99, 20);
            label24.TabIndex = 42;
            label24.Text = "asentamiento";
            // 
            // cmbAsentamiento
            // 
            cmbAsentamiento.FormattingEnabled = true;
            cmbAsentamiento.Location = new Point(736, 455);
            cmbAsentamiento.Margin = new Padding(3, 4, 3, 4);
            cmbAsentamiento.Name = "cmbAsentamiento";
            cmbAsentamiento.Size = new Size(305, 28);
            cmbAsentamiento.TabIndex = 41;
            // 
            // cmbTipoRecepcion
            // 
            cmbTipoRecepcion.FormattingEnabled = true;
            cmbTipoRecepcion.Location = new Point(408, 165);
            cmbTipoRecepcion.Margin = new Padding(3, 4, 3, 4);
            cmbTipoRecepcion.Name = "cmbTipoRecepcion";
            cmbTipoRecepcion.Size = new Size(305, 28);
            cmbTipoRecepcion.TabIndex = 40;
            // 
            // cmbRolFamiliar
            // 
            cmbRolFamiliar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRolFamiliar.FormattingEnabled = true;
            cmbRolFamiliar.Items.AddRange(new object[] { "Padre", "", "", "Madre", "", "", "Hijo", "", "", "Hija", "", "", "Abuelo", "", "", "Abuela", "", "", "Tío/a", "", "", "Otro" });
            cmbRolFamiliar.Location = new Point(0, 455);
            cmbRolFamiliar.Margin = new Padding(3, 4, 3, 4);
            cmbRolFamiliar.Name = "cmbRolFamiliar";
            cmbRolFamiliar.Size = new Size(305, 28);
            cmbRolFamiliar.TabIndex = 39;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(0, 427);
            label23.Name = "label23";
            label23.Size = new Size(106, 20);
            label23.TabIndex = 38;
            label23.Text = "ROL FAMILIAR:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(408, 141);
            label22.Name = "label22";
            label22.Size = new Size(124, 20);
            label22.TabIndex = 37;
            label22.Text = "TIPO RECEPCION:";
            // 
            // dtpFechaRecepcion
            // 
            dtpFechaRecepcion.Location = new Point(408, 80);
            dtpFechaRecepcion.Margin = new Padding(3, 4, 3, 4);
            dtpFechaRecepcion.Name = "dtpFechaRecepcion";
            dtpFechaRecepcion.Size = new Size(300, 27);
            dtpFechaRecepcion.TabIndex = 36;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(736, 301);
            label21.Name = "label21";
            label21.Size = new Size(67, 20);
            label21.TabIndex = 35;
            label21.Text = "ESTADO:";
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(736, 325);
            cmbEstado.Margin = new Padding(3, 4, 3, 4);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(305, 28);
            cmbEstado.TabIndex = 34;
            // 
            // cmbMotivoRetiro
            // 
            cmbMotivoRetiro.FormattingEnabled = true;
            cmbMotivoRetiro.Location = new Point(408, 304);
            cmbMotivoRetiro.Margin = new Padding(3, 4, 3, 4);
            cmbMotivoRetiro.Name = "cmbMotivoRetiro";
            cmbMotivoRetiro.Size = new Size(305, 28);
            cmbMotivoRetiro.TabIndex = 32;
            // 
            // cmbFamilia
            // 
            cmbFamilia.FormattingEnabled = true;
            cmbFamilia.Location = new Point(736, 141);
            cmbFamilia.Margin = new Padding(3, 4, 3, 4);
            cmbFamilia.Name = "cmbFamilia";
            cmbFamilia.Size = new Size(305, 28);
            cmbFamilia.TabIndex = 31;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(736, 113);
            label20.Name = "label20";
            label20.Size = new Size(66, 20);
            label20.TabIndex = 30;
            label20.Text = "FAMILIA:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(779, 52);
            label19.Name = "label19";
            label19.Size = new Size(251, 20);
            label19.TabIndex = 29;
            label19.Text = "* Indica que el campo es obligatorio";
            // 
            // cmbProfesion
            // 
            cmbProfesion.FormattingEnabled = true;
            cmbProfesion.Location = new Point(408, 655);
            cmbProfesion.Margin = new Padding(3, 4, 3, 4);
            cmbProfesion.Name = "cmbProfesion";
            cmbProfesion.Size = new Size(305, 28);
            cmbProfesion.TabIndex = 28;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(408, 627);
            label14.Name = "label14";
            label14.Size = new Size(89, 20);
            label14.TabIndex = 27;
            label14.Text = "PROFESION:";
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Items.AddRange(new object[] { "MASCULINO", "FEMENINO" });
            cmbGenero.Location = new Point(7, 80);
            cmbGenero.Margin = new Padding(3, 4, 3, 4);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(305, 28);
            cmbGenero.TabIndex = 26;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(7, 52);
            label13.Name = "label13";
            label13.Size = new Size(69, 20);
            label13.TabIndex = 24;
            label13.Text = "GENERO:";
            // 
            // dtpFechaRetiro
            // 
            dtpFechaRetiro.Location = new Point(408, 245);
            dtpFechaRetiro.Margin = new Padding(3, 4, 3, 4);
            dtpFechaRetiro.Name = "dtpFechaRetiro";
            dtpFechaRetiro.Size = new Size(300, 27);
            dtpFechaRetiro.TabIndex = 23;
            // 
            // dtpFechaBautismo
            // 
            dtpFechaBautismo.Location = new Point(0, 693);
            dtpFechaBautismo.Margin = new Padding(3, 4, 3, 4);
            dtpFechaBautismo.Name = "dtpFechaBautismo";
            dtpFechaBautismo.Size = new Size(300, 27);
            dtpFechaBautismo.TabIndex = 21;
            // 
            // txtReferenciaCasa
            // 
            txtReferenciaCasa.Location = new Point(413, 483);
            txtReferenciaCasa.Margin = new Padding(3, 4, 3, 4);
            txtReferenciaCasa.Multiline = true;
            txtReferenciaCasa.Name = "txtReferenciaCasa";
            txtReferenciaCasa.Size = new Size(306, 115);
            txtReferenciaCasa.TabIndex = 20;
            // 
            // txtCalleAvenida
            // 
            txtCalleAvenida.Location = new Point(413, 395);
            txtCalleAvenida.Margin = new Padding(3, 4, 3, 4);
            txtCalleAvenida.Name = "txtCalleAvenida";
            txtCalleAvenida.Size = new Size(306, 27);
            txtCalleAvenida.TabIndex = 19;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(2, 616);
            txtCorreo.Margin = new Padding(3, 4, 3, 4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(306, 27);
            txtCorreo.TabIndex = 17;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(2, 531);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(306, 27);
            txtTelefono.TabIndex = 16;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(413, 459);
            label12.Name = "label12";
            label12.Size = new Size(136, 20);
            label12.TabIndex = 15;
            label12.Text = "REFERENCIA CASA:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(413, 367);
            label11.Name = "label11";
            label11.Size = new Size(121, 20);
            label11.TabIndex = 14;
            label11.Text = "CALLE/AVENIDA:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(408, 221);
            label10.Name = "label10";
            label10.Size = new Size(110, 20);
            label10.TabIndex = 13;
            label10.Text = "FECHA RETIRO:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(402, 280);
            label9.Name = "label9";
            label9.Size = new Size(150, 20);
            label9.TabIndex = 12;
            label9.Text = "MOTIVO DEL RETIRO:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(413, 52);
            label8.Name = "label8";
            label8.Size = new Size(161, 20);
            label8.TabIndex = 11;
            label8.Text = "FECHA DE RECEPCION:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(0, 659);
            label7.Name = "label7";
            label7.Size = new Size(157, 20);
            label7.TabIndex = 10;
            label7.Text = "FECHA DE BAUTISMO:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 592);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 9;
            label6.Text = "CORREO:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 507);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 8;
            label5.Text = "TELEFONO:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(6, 377);
            dtpFechaNacimiento.Margin = new Padding(3, 4, 3, 4);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(300, 27);
            dtpFechaNacimiento.TabIndex = 7;
            // 
            // txtDPI
            // 
            txtDPI.Location = new Point(9, 304);
            txtDPI.Margin = new Padding(3, 4, 3, 4);
            txtDPI.Name = "txtDPI";
            txtDPI.Size = new Size(302, 27);
            txtDPI.TabIndex = 6;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(6, 225);
            txtApellidos.Margin = new Padding(3, 4, 3, 4);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(306, 27);
            txtApellidos.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(6, 152);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(306, 27);
            txtNombre.TabIndex = 4;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(9, 353);
            label15.Name = "label15";
            label15.Size = new Size(172, 20);
            label15.TabIndex = 3;
            label15.Text = "FECHA DE NACIMIENTO:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(9, 201);
            label16.Name = "label16";
            label16.Size = new Size(86, 20);
            label16.TabIndex = 2;
            label16.Text = "APELLIDOS:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(6, 280);
            label17.Name = "label17";
            label17.Size = new Size(269, 20);
            label17.TabIndex = 1;
            label17.Text = "DOCUMENTO DE IDENTIFICAION (DPI):";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(9, 128);
            label18.Name = "label18";
            label18.Size = new Size(81, 20);
            label18.TabIndex = 0;
            label18.Text = "NOMBRES:";
            // 
            // button2
            // 
            button2.Location = new Point(2037, 1341);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(126, 57);
            button2.TabIndex = 1;
            button2.Text = "Hola Mundo :D";
            button2.UseVisualStyleBackColor = true;
            // 
            // cbmBuscarEstado
            // 
            cbmBuscarEstado.FormattingEnabled = true;
            cbmBuscarEstado.Location = new Point(636, 130);
            cbmBuscarEstado.Name = "cbmBuscarEstado";
            cbmBuscarEstado.Size = new Size(477, 28);
            cbmBuscarEstado.TabIndex = 35;
            // 
            // cbmBuscarMinisterio
            // 
            cbmBuscarMinisterio.FormattingEnabled = true;
            cbmBuscarMinisterio.Location = new Point(634, 129);
            cbmBuscarMinisterio.Name = "cbmBuscarMinisterio";
            cbmBuscarMinisterio.Size = new Size(479, 28);
            cbmBuscarMinisterio.TabIndex = 36;
            // 
            // frmMembresiaNuevo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1546, 844);
            Controls.Add(button2);
            Controls.Add(tabMembresia);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMembresiaNuevo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMembresiaNuevo";
            Load += frmMembresiaNuevo_Load;
            tabMembresia.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgMiembros).EndInit();
            tabopage2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabMembresia;
        private TabPage tabPage1;
        private TabPage tabopage2;
        private Button btnNuevo;
        private Button btnEditar;
        private Button button1;
        private Label label4;
        private ComboBox cbmFiltro;
        private Label label2;
        private TextBox txtBuscarNombre;
        private DataGridView dgMiembros;
        private Label label1;
        private GroupBox groupBox1;
        private ComboBox cmbProfesion;
        private Label label14;
        private ComboBox cmbGenero;
        private Label label13;
        private DateTimePicker dtpFechaRetiro;
        private DateTimePicker dtpFechaBautismo;
        private TextBox txtReferenciaCasa;
        private TextBox txtCalleAvenida;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private DateTimePicker dtpFechaNacimiento;
        private TextBox txtDPI;
        private TextBox txtApellidos;
        private TextBox txtNombre;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Button button2;
        private ComboBox cmbFamilia;
        private Label label20;
        private ComboBox cmbMotivoRetiro;
        private Label label21;
        private ComboBox cmbEstado;
        private ComboBox cmbRolFamiliar;
        private Label label23;
        private Label label22;
        private DateTimePicker dtpFechaRecepcion;
        private ComboBox cmbTipoRecepcion;
        private Button btnLimpiar;
        private Button btnGuardar;
        private ComboBox cmbAsentamiento;
        private Label label24;
        private Button btnCancelar;
        private Button btnBuscar;
        private ComboBox cbmBuscarMinisterio;
        private ComboBox cbmBuscarEstado;
    }
}