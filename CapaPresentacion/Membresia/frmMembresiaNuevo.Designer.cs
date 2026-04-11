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
            btnNuevo = new Button();
            button1 = new Button();
            btnEditar = new Button();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            txtBuscar = new TextBox();
            dgMiembros = new DataGridView();
            label1 = new Label();
            tabopage2 = new TabPage();
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
            tabMembresia.Name = "tabMembresia";
            tabMembresia.SelectedIndex = 0;
            tabMembresia.Size = new Size(1455, 774);
            tabMembresia.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnNuevo);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(btnEditar);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtBuscar);
            tabPage1.Controls.Add(dgMiembros);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1447, 746);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "MIEMBROS";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(898, 632);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(165, 33);
            btnNuevo.TabIndex = 33;
            btnNuevo.Text = "NUEVO REGISTRO";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1067, 581);
            button1.Name = "button1";
            button1.Size = new Size(165, 33);
            button1.TabIndex = 31;
            button1.Text = "ACTUALIZAR TABLA";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(1069, 632);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(165, 33);
            btnEditar.TabIndex = 32;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label4.Location = new Point(85, 581);
            label4.Name = "label4";
            label4.Size = new Size(230, 25);
            label4.TabIndex = 30;
            label4.Text = "TOTAL REGISTROS:";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ESTADO", "MINISTERIO" });
            comboBox1.Location = new Point(717, 95);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(222, 33);
            comboBox1.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label3.Location = new Point(635, 103);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 28;
            label3.Text = "POR:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label2.Location = new Point(82, 103);
            label2.Name = "label2";
            label2.Size = new Size(272, 25);
            label2.TabIndex = 27;
            label2.Text = "BUSCAR POR NOMBRE:";
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            txtBuscar.Location = new Point(360, 97);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(258, 31);
            txtBuscar.TabIndex = 26;
            // 
            // dgMiembros
            // 
            dgMiembros.AllowUserToAddRows = false;
            dgMiembros.AllowUserToDeleteRows = false;
            dgMiembros.AllowUserToResizeColumns = false;
            dgMiembros.AllowUserToResizeRows = false;
            dgMiembros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMiembros.Location = new Point(85, 146);
            dgMiembros.Name = "dgMiembros";
            dgMiembros.ReadOnly = true;
            dgMiembros.Size = new Size(1147, 420);
            dgMiembros.TabIndex = 25;
            dgMiembros.CellDoubleClick += dgMiembros_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(74, 23);
            label1.Name = "label1";
            label1.Size = new Size(286, 65);
            label1.TabIndex = 24;
            label1.Text = "MIEMBROS";
            // 
            // tabopage2
            // 
            tabopage2.Controls.Add(btnLimpiar);
            tabopage2.Controls.Add(btnGuardar);
            tabopage2.Controls.Add(groupBox1);
            tabopage2.Location = new Point(4, 24);
            tabopage2.Name = "tabopage2";
            tabopage2.Padding = new Padding(3);
            tabopage2.Size = new Size(1447, 746);
            tabopage2.TabIndex = 1;
            tabopage2.Text = "REGISTRAR";
            tabopage2.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(1114, 188);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(1114, 132);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
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
            groupBox1.Location = new Point(48, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(965, 598);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "INFORMACION DE IDENTIDAD";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(646, 320);
            label24.Name = "label24";
            label24.Size = new Size(79, 15);
            label24.TabIndex = 42;
            label24.Text = "asentamiento";
            // 
            // cmbAsentamiento
            // 
            cmbAsentamiento.FormattingEnabled = true;
            cmbAsentamiento.Location = new Point(644, 341);
            cmbAsentamiento.Name = "cmbAsentamiento";
            cmbAsentamiento.Size = new Size(267, 23);
            cmbAsentamiento.TabIndex = 41;
            // 
            // cmbTipoRecepcion
            // 
            cmbTipoRecepcion.FormattingEnabled = true;
            cmbTipoRecepcion.Location = new Point(357, 124);
            cmbTipoRecepcion.Name = "cmbTipoRecepcion";
            cmbTipoRecepcion.Size = new Size(267, 23);
            cmbTipoRecepcion.TabIndex = 40;
            // 
            // cmbRolFamiliar
            // 
            cmbRolFamiliar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRolFamiliar.FormattingEnabled = true;
            cmbRolFamiliar.Items.AddRange(new object[] { "Padre", "", "", "Madre", "", "", "Hijo", "", "", "Hija", "", "", "Abuelo", "", "", "Abuela", "", "", "Tío/a", "", "", "Otro" });
            cmbRolFamiliar.Location = new Point(0, 341);
            cmbRolFamiliar.Name = "cmbRolFamiliar";
            cmbRolFamiliar.Size = new Size(267, 23);
            cmbRolFamiliar.TabIndex = 39;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(0, 320);
            label23.Name = "label23";
            label23.Size = new Size(86, 15);
            label23.TabIndex = 38;
            label23.Text = "ROL FAMILIAR:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(357, 106);
            label22.Name = "label22";
            label22.Size = new Size(101, 15);
            label22.TabIndex = 37;
            label22.Text = "TIPO RECEPCION:";
            // 
            // dtpFechaRecepcion
            // 
            dtpFechaRecepcion.Location = new Point(357, 60);
            dtpFechaRecepcion.Name = "dtpFechaRecepcion";
            dtpFechaRecepcion.Size = new Size(263, 23);
            dtpFechaRecepcion.TabIndex = 36;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(644, 226);
            label21.Name = "label21";
            label21.Size = new Size(52, 15);
            label21.TabIndex = 35;
            label21.Text = "ESTADO:";
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(644, 244);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(267, 23);
            cmbEstado.TabIndex = 34;
            // 
            // cmbMotivoRetiro
            // 
            cmbMotivoRetiro.FormattingEnabled = true;
            cmbMotivoRetiro.Location = new Point(357, 228);
            cmbMotivoRetiro.Name = "cmbMotivoRetiro";
            cmbMotivoRetiro.Size = new Size(267, 23);
            cmbMotivoRetiro.TabIndex = 32;
            // 
            // cmbFamilia
            // 
            cmbFamilia.FormattingEnabled = true;
            cmbFamilia.Location = new Point(644, 106);
            cmbFamilia.Name = "cmbFamilia";
            cmbFamilia.Size = new Size(267, 23);
            cmbFamilia.TabIndex = 31;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(644, 85);
            label20.Name = "label20";
            label20.Size = new Size(54, 15);
            label20.TabIndex = 30;
            label20.Text = "FAMILIA:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(682, 39);
            label19.Name = "label19";
            label19.Size = new Size(197, 15);
            label19.TabIndex = 29;
            label19.Text = "* Indica que el campo es obligatorio";
            // 
            // cmbProfesion
            // 
            cmbProfesion.FormattingEnabled = true;
            cmbProfesion.Location = new Point(357, 491);
            cmbProfesion.Name = "cmbProfesion";
            cmbProfesion.Size = new Size(267, 23);
            cmbProfesion.TabIndex = 28;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(357, 470);
            label14.Name = "label14";
            label14.Size = new Size(72, 15);
            label14.TabIndex = 27;
            label14.Text = "PROFESION:";
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Items.AddRange(new object[] { "MASCULINO", "FEMENINO" });
            cmbGenero.Location = new Point(6, 60);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(267, 23);
            cmbGenero.TabIndex = 26;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 39);
            label13.Name = "label13";
            label13.Size = new Size(55, 15);
            label13.TabIndex = 24;
            label13.Text = "GENERO:";
            // 
            // dtpFechaRetiro
            // 
            dtpFechaRetiro.Location = new Point(357, 184);
            dtpFechaRetiro.Name = "dtpFechaRetiro";
            dtpFechaRetiro.Size = new Size(263, 23);
            dtpFechaRetiro.TabIndex = 23;
            // 
            // dtpFechaBautismo
            // 
            dtpFechaBautismo.Location = new Point(0, 520);
            dtpFechaBautismo.Name = "dtpFechaBautismo";
            dtpFechaBautismo.Size = new Size(263, 23);
            dtpFechaBautismo.TabIndex = 21;
            // 
            // txtReferenciaCasa
            // 
            txtReferenciaCasa.Location = new Point(361, 362);
            txtReferenciaCasa.Multiline = true;
            txtReferenciaCasa.Name = "txtReferenciaCasa";
            txtReferenciaCasa.Size = new Size(268, 87);
            txtReferenciaCasa.TabIndex = 20;
            // 
            // txtCalleAvenida
            // 
            txtCalleAvenida.Location = new Point(361, 296);
            txtCalleAvenida.Name = "txtCalleAvenida";
            txtCalleAvenida.Size = new Size(268, 23);
            txtCalleAvenida.TabIndex = 19;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(2, 462);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(268, 23);
            txtCorreo.TabIndex = 17;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(2, 398);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(268, 23);
            txtTelefono.TabIndex = 16;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(361, 344);
            label12.Name = "label12";
            label12.Size = new Size(109, 15);
            label12.TabIndex = 15;
            label12.Text = "REFERENCIA CASA:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(361, 275);
            label11.Name = "label11";
            label11.Size = new Size(97, 15);
            label11.TabIndex = 14;
            label11.Text = "CALLE/AVENIDA:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(357, 166);
            label10.Name = "label10";
            label10.Size = new Size(88, 15);
            label10.TabIndex = 13;
            label10.Text = "FECHA RETIRO:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(352, 210);
            label9.Name = "label9";
            label9.Size = new Size(118, 15);
            label9.TabIndex = 12;
            label9.Text = "MOTIVO DEL RETIRO:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(361, 39);
            label8.Name = "label8";
            label8.Size = new Size(130, 15);
            label8.TabIndex = 11;
            label8.Text = "FECHA DE RECEPCION:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(0, 494);
            label7.Name = "label7";
            label7.Size = new Size(125, 15);
            label7.TabIndex = 10;
            label7.Text = "FECHA DE BAUTISMO:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 444);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 9;
            label6.Text = "CORREO:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 380);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 8;
            label5.Text = "TELEFONO:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(5, 283);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(263, 23);
            dtpFechaNacimiento.TabIndex = 7;
            // 
            // txtDPI
            // 
            txtDPI.Location = new Point(8, 228);
            txtDPI.Name = "txtDPI";
            txtDPI.Size = new Size(265, 23);
            txtDPI.TabIndex = 6;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(5, 169);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(268, 23);
            txtApellidos.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(5, 114);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(268, 23);
            txtNombre.TabIndex = 4;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(8, 265);
            label15.Name = "label15";
            label15.Size = new Size(138, 15);
            label15.TabIndex = 3;
            label15.Text = "FECHA DE NACIMIENTO:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(8, 151);
            label16.Name = "label16";
            label16.Size = new Size(69, 15);
            label16.TabIndex = 2;
            label16.Text = "APELLIDOS:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(5, 210);
            label17.Name = "label17";
            label17.Size = new Size(213, 15);
            label17.TabIndex = 1;
            label17.Text = "DOCUMENTO DE IDENTIFICAION (DPI):";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(8, 96);
            label18.Name = "label18";
            label18.Size = new Size(65, 15);
            label18.TabIndex = 0;
            label18.Text = "NOMBRES:";
            // 
            // button2
            // 
            button2.Location = new Point(1782, 1006);
            button2.Name = "button2";
            button2.Size = new Size(110, 43);
            button2.TabIndex = 1;
            button2.Text = "Hola Mundo :D";
            button2.UseVisualStyleBackColor = true;
            // 
            // frmMembresiaNuevo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1353, 633);
            Controls.Add(button2);
            Controls.Add(tabMembresia);
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
        private ComboBox comboBox1;
        private Label label3;
        private Label label2;
        private TextBox txtBuscar;
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
    }
}