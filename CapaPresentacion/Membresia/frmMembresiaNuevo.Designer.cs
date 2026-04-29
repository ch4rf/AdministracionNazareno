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
            label4 = new Label();
            label2 = new Label();
            txtBuscarNombre = new TextBox();
            dgMiembros = new DataGridView();
            label1 = new Label();
            tabopage2 = new TabPage();
            gbInfoMembr = new GroupBox();
            label21 = new Label();
            cmbTipoRecepcion = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            cmbMotivoRetiro = new ComboBox();
            dtpFechaRetiro = new DateTimePicker();
            cmbEstado = new ComboBox();
            label22 = new Label();
            dtpFechaRecepcion = new DateTimePicker();
            label8 = new Label();
            groupBox2 = new GroupBox();
            label24 = new Label();
            txtCorreo = new TextBox();
            cmbAsentamiento = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            txtTelefono = new TextBox();
            txtReferenciaCasa = new TextBox();
            label11 = new Label();
            label12 = new Label();
            txtCalleAvenida = new TextBox();
            gbEDITABLES = new GroupBox();
            label20 = new Label();
            cmbProfesion = new ComboBox();
            label14 = new Label();
            cmbFamilia = new ComboBox();
            label23 = new Label();
            cmbRolFamiliar = new ComboBox();
            btnCancelar = new Button();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            groupBox1 = new GroupBox();
            cmbGenero = new ComboBox();
            label13 = new Label();
            dtpFechaBautismo = new DateTimePicker();
            label7 = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            txtDPI = new TextBox();
            txtApellidos = new TextBox();
            txtNombre = new TextBox();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            chkEsExistente = new CheckBox();
            tabMembresia.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgMiembros).BeginInit();
            tabopage2.SuspendLayout();
            gbInfoMembr.SuspendLayout();
            groupBox2.SuspendLayout();
            gbEDITABLES.SuspendLayout();
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
            tabMembresia.Size = new Size(1524, 639);
            tabMembresia.TabIndex = 0;
            tabMembresia.Selecting += tabMembresia_Selecting;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnNuevo);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtBuscarNombre);
            tabPage1.Controls.Add(dgMiembros);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1516, 611);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "MIEMBROS";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(1212, 89);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(142, 49);
            btnNuevo.TabIndex = 33;
            btnNuevo.Text = "NUEVO REGISTRO";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1360, 89);
            button1.Name = "button1";
            button1.Size = new Size(141, 49);
            button1.TabIndex = 31;
            button1.Text = "ACTUALIZAR TABLA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label4.Location = new Point(85, 581);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 63);
            label2.Name = "label2";
            label2.Size = new Size(208, 25);
            label2.TabIndex = 27;
            label2.Text = "BUSCAR POR NOMBRE:";
            // 
            // txtBuscarNombre
            // 
            txtBuscarNombre.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarNombre.Location = new Point(31, 91);
            txtBuscarNombre.Name = "txtBuscarNombre";
            txtBuscarNombre.Size = new Size(597, 35);
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
            dgMiembros.Location = new Point(31, 146);
            dgMiembros.Name = "dgMiembros";
            dgMiembros.ReadOnly = true;
            dgMiembros.RowHeadersWidth = 51;
            dgMiembros.Size = new Size(1470, 420);
            dgMiembros.TabIndex = 25;
            dgMiembros.CellContentClick += dgMiembros_CellContentClick;
            dgMiembros.CellDoubleClick += dgMiembros_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(162, 37);
            label1.TabIndex = 24;
            label1.Text = "MIEMBROS";
            // 
            // tabopage2
            // 
            tabopage2.Controls.Add(gbInfoMembr);
            tabopage2.Controls.Add(groupBox2);
            tabopage2.Controls.Add(gbEDITABLES);
            tabopage2.Controls.Add(btnCancelar);
            tabopage2.Controls.Add(btnLimpiar);
            tabopage2.Controls.Add(btnGuardar);
            tabopage2.Controls.Add(groupBox1);
            tabopage2.Location = new Point(4, 24);
            tabopage2.Name = "tabopage2";
            tabopage2.Padding = new Padding(3);
            tabopage2.Size = new Size(1516, 611);
            tabopage2.TabIndex = 1;
            tabopage2.Text = "           ";
            tabopage2.UseVisualStyleBackColor = true;
            tabopage2.Click += tabopage2_Click;
            // 
            // gbInfoMembr
            // 
            gbInfoMembr.Controls.Add(chkEsExistente);
            gbInfoMembr.Controls.Add(label21);
            gbInfoMembr.Controls.Add(cmbTipoRecepcion);
            gbInfoMembr.Controls.Add(label10);
            gbInfoMembr.Controls.Add(label9);
            gbInfoMembr.Controls.Add(cmbMotivoRetiro);
            gbInfoMembr.Controls.Add(dtpFechaRetiro);
            gbInfoMembr.Controls.Add(cmbEstado);
            gbInfoMembr.Controls.Add(label22);
            gbInfoMembr.Controls.Add(dtpFechaRecepcion);
            gbInfoMembr.Controls.Add(label8);
            gbInfoMembr.Location = new Point(667, 19);
            gbInfoMembr.Name = "gbInfoMembr";
            gbInfoMembr.Size = new Size(532, 254);
            gbInfoMembr.TabIndex = 38;
            gbInfoMembr.TabStop = false;
            gbInfoMembr.Text = "INFORMACIÓN DE MEMBRESÍA";
            gbInfoMembr.Enter += groupBox3_Enter;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(20, 173);
            label21.Name = "label21";
            label21.Size = new Size(53, 15);
            label21.TabIndex = 35;
            label21.Text = "ESTADO:";
            // 
            // cmbTipoRecepcion
            // 
            cmbTipoRecepcion.FormattingEnabled = true;
            cmbTipoRecepcion.Location = new Point(274, 62);
            cmbTipoRecepcion.Name = "cmbTipoRecepcion";
            cmbTipoRecepcion.Size = new Size(229, 23);
            cmbTipoRecepcion.TabIndex = 40;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 106);
            label10.Name = "label10";
            label10.Size = new Size(89, 15);
            label10.TabIndex = 13;
            label10.Text = "FECHA RETIRO:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(274, 106);
            label9.Name = "label9";
            label9.Size = new Size(120, 15);
            label9.TabIndex = 12;
            label9.Text = "MOTIVO DEL RETIRO:";
            // 
            // cmbMotivoRetiro
            // 
            cmbMotivoRetiro.FormattingEnabled = true;
            cmbMotivoRetiro.Location = new Point(274, 124);
            cmbMotivoRetiro.Name = "cmbMotivoRetiro";
            cmbMotivoRetiro.Size = new Size(229, 23);
            cmbMotivoRetiro.TabIndex = 32;
            // 
            // dtpFechaRetiro
            // 
            dtpFechaRetiro.Location = new Point(17, 124);
            dtpFechaRetiro.Name = "dtpFechaRetiro";
            dtpFechaRetiro.Size = new Size(232, 23);
            dtpFechaRetiro.TabIndex = 23;
            dtpFechaRetiro.ValueChanged += dtpFechaRetiro_ValueChanged;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(20, 191);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(229, 23);
            cmbEstado.TabIndex = 34;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(274, 44);
            label22.Name = "label22";
            label22.Size = new Size(102, 15);
            label22.TabIndex = 37;
            label22.Text = "TIPO RECEPCION:";
            // 
            // dtpFechaRecepcion
            // 
            dtpFechaRecepcion.Location = new Point(19, 62);
            dtpFechaRecepcion.Name = "dtpFechaRecepcion";
            dtpFechaRecepcion.Size = new Size(229, 23);
            dtpFechaRecepcion.TabIndex = 36;
            dtpFechaRecepcion.ValueChanged += dtpFechaRecepcion_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 41);
            label8.Name = "label8";
            label8.Size = new Size(130, 15);
            label8.TabIndex = 11;
            label8.Text = "FECHA DE RECEPCION:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label24);
            groupBox2.Controls.Add(txtCorreo);
            groupBox2.Controls.Add(cmbAsentamiento);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtTelefono);
            groupBox2.Controls.Add(txtReferenciaCasa);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(txtCalleAvenida);
            groupBox2.Location = new Point(48, 299);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(597, 240);
            groupBox2.TabIndex = 37;
            groupBox2.TabStop = false;
            groupBox2.Text = "CONTACTO Y UBICACIÓN";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(27, 96);
            label24.Name = "label24";
            label24.Size = new Size(97, 15);
            label24.TabIndex = 42;
            label24.Text = "ASENTAMIENTO:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(315, 50);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(259, 23);
            txtCorreo.TabIndex = 17;
            // 
            // cmbAsentamiento
            // 
            cmbAsentamiento.FormattingEnabled = true;
            cmbAsentamiento.Location = new Point(24, 114);
            cmbAsentamiento.Name = "cmbAsentamiento";
            cmbAsentamiento.Size = new Size(259, 23);
            cmbAsentamiento.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 32);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 8;
            label5.Text = "TELÉFONO:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(315, 32);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 9;
            label6.Text = "CORREO:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(24, 50);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(259, 23);
            txtTelefono.TabIndex = 16;
            // 
            // txtReferenciaCasa
            // 
            txtReferenciaCasa.Location = new Point(24, 173);
            txtReferenciaCasa.Multiline = true;
            txtReferenciaCasa.Name = "txtReferenciaCasa";
            txtReferenciaCasa.ScrollBars = ScrollBars.Both;
            txtReferenciaCasa.Size = new Size(550, 50);
            txtReferenciaCasa.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(315, 93);
            label11.Name = "label11";
            label11.Size = new Size(97, 15);
            label11.TabIndex = 14;
            label11.Text = "CALLE/AVENIDA:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(27, 155);
            label12.Name = "label12";
            label12.Size = new Size(109, 15);
            label12.TabIndex = 15;
            label12.Text = "REFERENCIA CASA:";
            // 
            // txtCalleAvenida
            // 
            txtCalleAvenida.Location = new Point(315, 114);
            txtCalleAvenida.Name = "txtCalleAvenida";
            txtCalleAvenida.Size = new Size(259, 23);
            txtCalleAvenida.TabIndex = 19;
            // 
            // gbEDITABLES
            // 
            gbEDITABLES.Controls.Add(label20);
            gbEDITABLES.Controls.Add(cmbProfesion);
            gbEDITABLES.Controls.Add(label14);
            gbEDITABLES.Controls.Add(cmbFamilia);
            gbEDITABLES.Controls.Add(label23);
            gbEDITABLES.Controls.Add(cmbRolFamiliar);
            gbEDITABLES.Location = new Point(667, 299);
            gbEDITABLES.Name = "gbEDITABLES";
            gbEDITABLES.Size = new Size(342, 240);
            gbEDITABLES.TabIndex = 36;
            gbEDITABLES.TabStop = false;
            gbEDITABLES.Text = "DETALLES ADICIONALES";
            gbEDITABLES.Enter += gbEDITABLES_Enter;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(20, 74);
            label20.Name = "label20";
            label20.Size = new Size(54, 15);
            label20.TabIndex = 30;
            label20.Text = "FAMILIA:";
            // 
            // cmbProfesion
            // 
            cmbProfesion.FormattingEnabled = true;
            cmbProfesion.Location = new Point(19, 50);
            cmbProfesion.Name = "cmbProfesion";
            cmbProfesion.Size = new Size(292, 23);
            cmbProfesion.TabIndex = 28;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(19, 30);
            label14.Name = "label14";
            label14.Size = new Size(72, 15);
            label14.TabIndex = 27;
            label14.Text = "PROFESION:";
            // 
            // cmbFamilia
            // 
            cmbFamilia.FormattingEnabled = true;
            cmbFamilia.Location = new Point(20, 95);
            cmbFamilia.Name = "cmbFamilia";
            cmbFamilia.Size = new Size(229, 23);
            cmbFamilia.TabIndex = 31;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(20, 133);
            label23.Name = "label23";
            label23.Size = new Size(86, 15);
            label23.TabIndex = 38;
            label23.Text = "ROL FAMILIAR:";
            // 
            // cmbRolFamiliar
            // 
            cmbRolFamiliar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRolFamiliar.FormattingEnabled = true;
            cmbRolFamiliar.Location = new Point(20, 154);
            cmbRolFamiliar.Name = "cmbRolFamiliar";
            cmbRolFamiliar.Size = new Size(216, 23);
            cmbRolFamiliar.TabIndex = 39;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(1041, 386);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(135, 61);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(1041, 472);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(135, 57);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(1041, 306);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(135, 61);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar Nuevo";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbGenero);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(dtpFechaBautismo);
            groupBox1.Controls.Add(label7);
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
            groupBox1.Size = new Size(597, 254);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "IDENTIDAD PERSONAL Y DATOS";
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(22, 118);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(265, 23);
            cmbGenero.TabIndex = 26;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(22, 97);
            label13.Name = "label13";
            label13.Size = new Size(55, 15);
            label13.TabIndex = 24;
            label13.Text = "GÉNERO:";
            // 
            // dtpFechaBautismo
            // 
            dtpFechaBautismo.Location = new Point(306, 191);
            dtpFechaBautismo.Name = "dtpFechaBautismo";
            dtpFechaBautismo.Size = new Size(263, 23);
            dtpFechaBautismo.TabIndex = 21;
            dtpFechaBautismo.ValueChanged += dtpFechaBautismo_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(306, 169);
            label7.Name = "label7";
            label7.Size = new Size(126, 15);
            label7.TabIndex = 10;
            label7.Text = "FECHA DE BAUTISMO:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(19, 191);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(263, 23);
            dtpFechaNacimiento.TabIndex = 7;
            dtpFechaNacimiento.ValueChanged += dtpFechaNacimiento_ValueChanged;
            // 
            // txtDPI
            // 
            txtDPI.Location = new Point(309, 118);
            txtDPI.Name = "txtDPI";
            txtDPI.Size = new Size(265, 23);
            txtDPI.TabIndex = 6;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(306, 50);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(268, 23);
            txtApellidos.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(19, 50);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(268, 23);
            txtNombre.TabIndex = 4;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(22, 173);
            label15.Name = "label15";
            label15.Size = new Size(139, 15);
            label15.TabIndex = 3;
            label15.Text = "FECHA DE NACIMIENTO:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(309, 32);
            label16.Name = "label16";
            label16.Size = new Size(69, 15);
            label16.TabIndex = 2;
            label16.Text = "APELLIDOS:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(309, 100);
            label17.Name = "label17";
            label17.Size = new Size(223, 15);
            label17.TabIndex = 1;
            label17.Text = "DOCUMENTO DE IDENTIFICACIÓN (DPI):";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(22, 32);
            label18.Name = "label18";
            label18.Size = new Size(65, 15);
            label18.TabIndex = 0;
            label18.Text = "NOMBRES:";
            // 
            // chkEsExistente
            // 
            chkEsExistente.AutoSize = true;
            chkEsExistente.Location = new Point(286, 187);
            chkEsExistente.Name = "chkEsExistente";
            chkEsExistente.Size = new Size(115, 19);
            chkEsExistente.TabIndex = 41;
            chkEsExistente.Text = "Usuario Existente";
            chkEsExistente.UseVisualStyleBackColor = true;
            chkEsExistente.CheckedChanged += chkEsExistente_CheckedChanged;
            // 
            // frmMembresiaNuevo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1569, 703);
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
            gbInfoMembr.ResumeLayout(false);
            gbInfoMembr.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            gbEDITABLES.ResumeLayout(false);
            gbEDITABLES.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabMembresia;
        private TabPage tabPage1;
        private TabPage tabopage2;
        private Label label4;
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
        private GroupBox gbEDITABLES;
        private Button btnNuevo;
        private Button button1;
        private Label label2;
        private TextBox txtBuscarNombre;
        private DataGridView dgMiembros;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox gbInfoMembr;
        private Label label20;
        private ComboBox cmbFamilia;
        private CheckBox chkEsExistente;
    }
}