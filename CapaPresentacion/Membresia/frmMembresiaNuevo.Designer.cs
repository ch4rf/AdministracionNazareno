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
            groupBox1 = new GroupBox();
            label19 = new Label();
            comboBox2 = new ComboBox();
            label14 = new Label();
            comboBox3 = new ComboBox();
            label13 = new Label();
            dateTimePicker4 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            txtTelefono = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            dtFechaNacimiento = new DateTimePicker();
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
            dgMiembros.CellContentDoubleClick += dgMiembros_CellContentDoubleClick;
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
            tabopage2.Controls.Add(groupBox1);
            tabopage2.Location = new Point(4, 24);
            tabopage2.Name = "tabopage2";
            tabopage2.Padding = new Padding(3);
            tabopage2.Size = new Size(1447, 746);
            tabopage2.TabIndex = 1;
            tabopage2.Text = "REGISTRAR";
            tabopage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(dateTimePicker4);
            groupBox1.Controls.Add(dateTimePicker3);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(textBox8);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dtFechaNacimiento);
            groupBox1.Controls.Add(txtDPI);
            groupBox1.Controls.Add(txtApellidos);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(label18);
            groupBox1.Location = new Point(48, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(911, 598);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "INFORMACION DE IDENTIDAD";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(682, 39);
            label19.Name = "label19";
            label19.Size = new Size(197, 15);
            label19.TabIndex = 29;
            label19.Text = "* Indica que el campo es obligatorio";
            label19.Click += label19_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(357, 491);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(267, 23);
            comboBox2.TabIndex = 28;
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
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(6, 60);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(267, 23);
            comboBox3.TabIndex = 26;
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
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new Point(361, 124);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(263, 23);
            dateTimePicker4.TabIndex = 23;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(366, 70);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(263, 23);
            dateTimePicker3.TabIndex = 22;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(2, 488);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(263, 23);
            dateTimePicker2.TabIndex = 21;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(361, 362);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(268, 87);
            textBox8.TabIndex = 20;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(361, 296);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(268, 23);
            textBox7.TabIndex = 19;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(361, 183);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(273, 78);
            textBox6.TabIndex = 18;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(5, 416);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(268, 23);
            textBox5.TabIndex = 17;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(5, 352);
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
            label10.Location = new Point(361, 106);
            label10.Name = "label10";
            label10.Size = new Size(89, 15);
            label10.TabIndex = 13;
            label10.Text = "FECHA RETIRO:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(361, 161);
            label9.Name = "label9";
            label9.Size = new Size(120, 15);
            label9.TabIndex = 12;
            label9.Text = "MOTIVO DEL RETIRO:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(369, 39);
            label8.Name = "label8";
            label8.Size = new Size(130, 15);
            label8.TabIndex = 11;
            label8.Text = "FECHA DE RECEPCION:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 460);
            label7.Name = "label7";
            label7.Size = new Size(126, 15);
            label7.TabIndex = 10;
            label7.Text = "FECHA DE BAUTISMO:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 398);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 9;
            label6.Text = "CORREO:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 334);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 8;
            label5.Text = "TELEFONO:";
            // 
            // dtFechaNacimiento
            // 
            dtFechaNacimiento.Location = new Point(5, 283);
            dtFechaNacimiento.Name = "dtFechaNacimiento";
            dtFechaNacimiento.Size = new Size(263, 23);
            dtFechaNacimiento.TabIndex = 7;
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
            label15.Size = new Size(139, 15);
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
            label17.Size = new Size(215, 15);
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
            ClientSize = new Size(1234, 611);
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
        private ComboBox comboBox2;
        private Label label14;
        private ComboBox comboBox3;
        private Label label13;
        private DateTimePicker dateTimePicker4;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker2;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox txtTelefono;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private DateTimePicker dtFechaNacimiento;
        private TextBox txtDPI;
        private TextBox txtApellidos;
        private TextBox txtNombre;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Button button2;
    }
}