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
            chkEsExistente = new CheckBox();
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
            cmbProfesion = new ComboBox();
            label14 = new Label();
            cmbFamilia = new ComboBox();
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
            tabMembresia.Margin = new Padding(3, 4, 3, 4);
            tabMembresia.Name = "tabMembresia";
            tabMembresia.SelectedIndex = 0;
            tabMembresia.Size = new Size(1742, 852);
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
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(1734, 819);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "MIEMBROS";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(1385, 119);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(162, 65);
            btnNuevo.TabIndex = 33;
            btnNuevo.Text = "NUEVO REGISTRO";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1554, 119);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(161, 65);
            button1.TabIndex = 31;
            button1.Text = "ACTUALIZAR TABLA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label4.Location = new Point(97, 775);
            label4.Name = "label4";
            label4.Size = new Size(0, 31);
            label4.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 84);
            label2.Name = "label2";
            label2.Size = new Size(263, 32);
            label2.TabIndex = 27;
            label2.Text = "BUSCAR POR NOMBRE:";
            // 
            // txtBuscarNombre
            // 
            txtBuscarNombre.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarNombre.Location = new Point(35, 121);
            txtBuscarNombre.Margin = new Padding(3, 4, 3, 4);
            txtBuscarNombre.Name = "txtBuscarNombre";
            txtBuscarNombre.Size = new Size(682, 42);
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
            dgMiembros.Location = new Point(35, 195);
            dgMiembros.Margin = new Padding(3, 4, 3, 4);
            dgMiembros.Name = "dgMiembros";
            dgMiembros.ReadOnly = true;
            dgMiembros.RowHeadersWidth = 51;
            dgMiembros.Size = new Size(1680, 560);
            dgMiembros.TabIndex = 25;
            dgMiembros.CellContentClick += dgMiembros_CellContentClick;
            dgMiembros.CellDoubleClick += dgMiembros_CellDoubleClick;
            dgMiembros.RowPostPaint += dgMiembros_RowPostPaint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(204, 46);
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
            tabopage2.Location = new Point(4, 29);
            tabopage2.Margin = new Padding(3, 4, 3, 4);
            tabopage2.Name = "tabopage2";
            tabopage2.Padding = new Padding(3, 4, 3, 4);
            tabopage2.Size = new Size(1734, 819);
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
            gbInfoMembr.Location = new Point(762, 25);
            gbInfoMembr.Margin = new Padding(3, 4, 3, 4);
            gbInfoMembr.Name = "gbInfoMembr";
            gbInfoMembr.Padding = new Padding(3, 4, 3, 4);
            gbInfoMembr.Size = new Size(608, 339);
            gbInfoMembr.TabIndex = 38;
            gbInfoMembr.TabStop = false;
            gbInfoMembr.Text = "INFORMACIÓN DE MEMBRESÍA";
            gbInfoMembr.Enter += groupBox3_Enter;
            // 
            // chkEsExistente
            // 
            chkEsExistente.AutoSize = true;
            chkEsExistente.Location = new Point(327, 249);
            chkEsExistente.Margin = new Padding(3, 4, 3, 4);
            chkEsExistente.Name = "chkEsExistente";
            chkEsExistente.Size = new Size(144, 24);
            chkEsExistente.TabIndex = 41;
            chkEsExistente.Text = "Usuario Existente";
            chkEsExistente.UseVisualStyleBackColor = true;
            chkEsExistente.CheckedChanged += chkEsExistente_CheckedChanged;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(23, 231);
            label21.Name = "label21";
            label21.Size = new Size(67, 20);
            label21.TabIndex = 35;
            label21.Text = "ESTADO:";
            // 
            // cmbTipoRecepcion
            // 
            cmbTipoRecepcion.FormattingEnabled = true;
            cmbTipoRecepcion.Location = new Point(313, 83);
            cmbTipoRecepcion.Margin = new Padding(3, 4, 3, 4);
            cmbTipoRecepcion.Name = "cmbTipoRecepcion";
            cmbTipoRecepcion.Size = new Size(261, 28);
            cmbTipoRecepcion.TabIndex = 40;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(19, 141);
            label10.Name = "label10";
            label10.Size = new Size(110, 20);
            label10.TabIndex = 13;
            label10.Text = "FECHA RETIRO:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(313, 141);
            label9.Name = "label9";
            label9.Size = new Size(150, 20);
            label9.TabIndex = 12;
            label9.Text = "MOTIVO DEL RETIRO:";
            // 
            // cmbMotivoRetiro
            // 
            cmbMotivoRetiro.FormattingEnabled = true;
            cmbMotivoRetiro.Location = new Point(313, 165);
            cmbMotivoRetiro.Margin = new Padding(3, 4, 3, 4);
            cmbMotivoRetiro.Name = "cmbMotivoRetiro";
            cmbMotivoRetiro.Size = new Size(261, 28);
            cmbMotivoRetiro.TabIndex = 32;
            // 
            // dtpFechaRetiro
            // 
            dtpFechaRetiro.Location = new Point(19, 165);
            dtpFechaRetiro.Margin = new Padding(3, 4, 3, 4);
            dtpFechaRetiro.Name = "dtpFechaRetiro";
            dtpFechaRetiro.Size = new Size(265, 27);
            dtpFechaRetiro.TabIndex = 23;
            dtpFechaRetiro.ValueChanged += dtpFechaRetiro_ValueChanged;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(23, 255);
            cmbEstado.Margin = new Padding(3, 4, 3, 4);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(261, 28);
            cmbEstado.TabIndex = 34;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(313, 59);
            label22.Name = "label22";
            label22.Size = new Size(124, 20);
            label22.TabIndex = 37;
            label22.Text = "TIPO RECEPCION:";
            // 
            // dtpFechaRecepcion
            // 
            dtpFechaRecepcion.Location = new Point(22, 83);
            dtpFechaRecepcion.Margin = new Padding(3, 4, 3, 4);
            dtpFechaRecepcion.Name = "dtpFechaRecepcion";
            dtpFechaRecepcion.Size = new Size(261, 27);
            dtpFechaRecepcion.TabIndex = 36;
            dtpFechaRecepcion.ValueChanged += dtpFechaRecepcion_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 55);
            label8.Name = "label8";
            label8.Size = new Size(161, 20);
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
            groupBox2.Location = new Point(55, 399);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(682, 320);
            groupBox2.TabIndex = 37;
            groupBox2.TabStop = false;
            groupBox2.Text = "CONTACTO Y UBICACIÓN";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(31, 128);
            label24.Name = "label24";
            label24.Size = new Size(120, 20);
            label24.TabIndex = 42;
            label24.Text = "ASENTAMIENTO:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(360, 67);
            txtCorreo.Margin = new Padding(3, 4, 3, 4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(295, 27);
            txtCorreo.TabIndex = 17;
            // 
            // cmbAsentamiento
            // 
            cmbAsentamiento.FormattingEnabled = true;
            cmbAsentamiento.Location = new Point(27, 152);
            cmbAsentamiento.Margin = new Padding(3, 4, 3, 4);
            cmbAsentamiento.Name = "cmbAsentamiento";
            cmbAsentamiento.Size = new Size(295, 28);
            cmbAsentamiento.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 43);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 8;
            label5.Text = "TELÉFONO:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(360, 43);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 9;
            label6.Text = "CORREO:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(27, 67);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(295, 27);
            txtTelefono.TabIndex = 16;
            // 
            // txtReferenciaCasa
            // 
            txtReferenciaCasa.Location = new Point(27, 231);
            txtReferenciaCasa.Margin = new Padding(3, 4, 3, 4);
            txtReferenciaCasa.Multiline = true;
            txtReferenciaCasa.Name = "txtReferenciaCasa";
            txtReferenciaCasa.ScrollBars = ScrollBars.Both;
            txtReferenciaCasa.Size = new Size(628, 65);
            txtReferenciaCasa.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(360, 124);
            label11.Name = "label11";
            label11.Size = new Size(121, 20);
            label11.TabIndex = 14;
            label11.Text = "CALLE/AVENIDA:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(31, 207);
            label12.Name = "label12";
            label12.Size = new Size(136, 20);
            label12.TabIndex = 15;
            label12.Text = "REFERENCIA CASA:";
            // 
            // txtCalleAvenida
            // 
            txtCalleAvenida.Location = new Point(360, 152);
            txtCalleAvenida.Margin = new Padding(3, 4, 3, 4);
            txtCalleAvenida.Name = "txtCalleAvenida";
            txtCalleAvenida.Size = new Size(295, 27);
            txtCalleAvenida.TabIndex = 19;
            // 
            // gbEDITABLES
            // 
            gbEDITABLES.Controls.Add(cmbProfesion);
            gbEDITABLES.Controls.Add(label14);
            gbEDITABLES.Controls.Add(cmbFamilia);
            gbEDITABLES.Controls.Add(cmbRolFamiliar);
            gbEDITABLES.Location = new Point(762, 399);
            gbEDITABLES.Margin = new Padding(3, 4, 3, 4);
            gbEDITABLES.Name = "gbEDITABLES";
            gbEDITABLES.Padding = new Padding(3, 4, 3, 4);
            gbEDITABLES.Size = new Size(391, 320);
            gbEDITABLES.TabIndex = 36;
            gbEDITABLES.TabStop = false;
            gbEDITABLES.Text = "DETALLES ADICIONALES";
            gbEDITABLES.Enter += gbEDITABLES_Enter;
            // 
            // cmbProfesion
            // 
            cmbProfesion.FormattingEnabled = true;
            cmbProfesion.Location = new Point(22, 67);
            cmbProfesion.Margin = new Padding(3, 4, 3, 4);
            cmbProfesion.Name = "cmbProfesion";
            cmbProfesion.Size = new Size(333, 28);
            cmbProfesion.TabIndex = 28;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(22, 40);
            label14.Name = "label14";
            label14.Size = new Size(89, 20);
            label14.TabIndex = 27;
            label14.Text = "PROFESION:";
            // 
            // cmbFamilia
            // 
            cmbFamilia.FormattingEnabled = true;
            cmbFamilia.Location = new Point(19, 219);
            cmbFamilia.Margin = new Padding(3, 4, 3, 4);
            cmbFamilia.Name = "cmbFamilia";
            cmbFamilia.Size = new Size(261, 28);
            cmbFamilia.TabIndex = 31;
            // 
            // cmbRolFamiliar
            // 
            cmbRolFamiliar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRolFamiliar.FormattingEnabled = true;
            cmbRolFamiliar.Location = new Point(23, 255);
            cmbRolFamiliar.Margin = new Padding(3, 4, 3, 4);
            cmbRolFamiliar.Name = "cmbRolFamiliar";
            cmbRolFamiliar.Size = new Size(246, 28);
            cmbRolFamiliar.TabIndex = 39;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(1190, 515);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(154, 81);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(1190, 629);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(154, 76);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(1190, 408);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(154, 81);
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
            groupBox1.Location = new Point(55, 25);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(682, 339);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "IDENTIDAD PERSONAL Y DATOS";
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(25, 157);
            cmbGenero.Margin = new Padding(3, 4, 3, 4);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(302, 28);
            cmbGenero.TabIndex = 26;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(25, 129);
            label13.Name = "label13";
            label13.Size = new Size(69, 20);
            label13.TabIndex = 24;
            label13.Text = "GÉNERO:";
            // 
            // dtpFechaBautismo
            // 
            dtpFechaBautismo.Location = new Point(350, 255);
            dtpFechaBautismo.Margin = new Padding(3, 4, 3, 4);
            dtpFechaBautismo.Name = "dtpFechaBautismo";
            dtpFechaBautismo.Size = new Size(300, 27);
            dtpFechaBautismo.TabIndex = 21;
            dtpFechaBautismo.ValueChanged += dtpFechaBautismo_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(350, 225);
            label7.Name = "label7";
            label7.Size = new Size(157, 20);
            label7.TabIndex = 10;
            label7.Text = "FECHA DE BAUTISMO:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(22, 255);
            dtpFechaNacimiento.Margin = new Padding(3, 4, 3, 4);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(300, 27);
            dtpFechaNacimiento.TabIndex = 7;
            dtpFechaNacimiento.ValueChanged += dtpFechaNacimiento_ValueChanged;
            // 
            // txtDPI
            // 
            txtDPI.Location = new Point(353, 157);
            txtDPI.Margin = new Padding(3, 4, 3, 4);
            txtDPI.Name = "txtDPI";
            txtDPI.Size = new Size(302, 27);
            txtDPI.TabIndex = 6;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(350, 67);
            txtApellidos.Margin = new Padding(3, 4, 3, 4);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(306, 27);
            txtApellidos.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(22, 67);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(306, 27);
            txtNombre.TabIndex = 4;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(25, 231);
            label15.Name = "label15";
            label15.Size = new Size(172, 20);
            label15.TabIndex = 3;
            label15.Text = "FECHA DE NACIMIENTO:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(353, 43);
            label16.Name = "label16";
            label16.Size = new Size(86, 20);
            label16.TabIndex = 2;
            label16.Text = "APELLIDOS:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(353, 133);
            label17.Name = "label17";
            label17.Size = new Size(278, 20);
            label17.TabIndex = 1;
            label17.Text = "DOCUMENTO DE IDENTIFICACIÓN (DPI):";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(25, 43);
            label18.Name = "label18";
            label18.Size = new Size(81, 20);
            label18.TabIndex = 0;
            label18.Text = "NOMBRES:";
            // 
            // frmMembresiaNuevo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1793, 937);
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
        private ComboBox cmbFamilia;
        private CheckBox chkEsExistente;
    }
}