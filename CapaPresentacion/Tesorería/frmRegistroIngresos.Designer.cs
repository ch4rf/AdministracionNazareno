namespace CapaPresentacion.Tesorería
{
    partial class frmRegistroIngresos
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            groupBox2 = new GroupBox();
            label5 = new Label();
            label8 = new Label();
            comboBox3 = new ComboBox();
            groupBox3 = new GroupBox();
            comboBox5 = new ComboBox();
            comboBox6 = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            groupBox4 = new GroupBox();
            label9 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            label10 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label11 = new Label();
            comboBox4 = new ComboBox();
            Column6 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            label13 = new Label();
            label12 = new Label();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(487, 167);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS INGRESO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 66);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "Tipo Ingreso:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 98);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Monto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 131);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 2;
            label3.Text = "Método de Pago:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(123, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 30);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 4;
            label4.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(123, 22);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ofrenda Ordinaria", "Ofrenda Ministerio", "Diezmo", "Proyecto", "Donación" });
            comboBox1.Location = new Point(123, 58);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 23);
            comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Efectivo", "Transferencia", "Cheque" });
            comboBox2.Location = new Point(123, 123);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(200, 23);
            comboBox2.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(3, 185);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(487, 99);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "ORIGEN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 30);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 4;
            label5.Text = "¿Es Anónimo?:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 61);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 0;
            label8.Text = "Miembro:";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(123, 61);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(200, 23);
            comboBox3.TabIndex = 7;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboBox5);
            groupBox3.Controls.Add(comboBox6);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(3, 290);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(487, 99);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "DESTINO";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(123, 61);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(200, 23);
            comboBox5.TabIndex = 7;
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(123, 22);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(200, 23);
            comboBox6.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 30);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 4;
            label6.Text = "Ministerio:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 61);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 0;
            label7.Text = "Proyecto:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox2);
            groupBox4.Controls.Add(label9);
            groupBox4.Location = new Point(3, 395);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(487, 123);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "DETALLES";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 30);
            label9.Name = "label9";
            label9.Size = new Size(138, 15);
            label9.TabIndex = 4;
            label9.Text = "Descripción / Referencia:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(163, 22);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(277, 76);
            textBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(103, 540);
            button1.Name = "button1";
            button1.Size = new Size(106, 23);
            button1.TabIndex = 4;
            button1.Text = "Guardar Ingreso";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(232, 540);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column6, Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(560, 135);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(643, 383);
            dataGridView1.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(560, 14);
            label10.Name = "label10";
            label10.Size = new Size(464, 50);
            label10.TabIndex = 8;
            label10.Text = "INGRESOS REGISTRADOS";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(123, 29);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(35, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Si";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(171, 29);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(42, 19);
            checkBox2.TabIndex = 9;
            checkBox2.Text = "No";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(560, 95);
            label11.Name = "label11";
            label11.Size = new Size(119, 15);
            label11.TabIndex = 9;
            label11.Text = "Mostrar Ingresos Por:";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Ofrenda Ordinaria", "Ofrenda Ministerio", "Diezmo", "Proyecto", "Donación" });
            comboBox4.Location = new Point(685, 92);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(200, 23);
            comboBox4.TabIndex = 10;
            // 
            // Column6
            // 
            Column6.HeaderText = "Fecha";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Tipo";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Monto (Q)";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Origen";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Destino";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Referencia";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(1107, 548);
            label13.Name = "label13";
            label13.Size = new Size(74, 15);
            label13.TabIndex = 14;
            label13.Text = "Total Monto:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(981, 548);
            label12.Name = "label12";
            label12.Size = new Size(86, 15);
            label12.TabIndex = 13;
            label12.Text = "Total Registros:";
            // 
            // button3
            // 
            button3.Location = new Point(560, 540);
            button3.Name = "button3";
            button3.Size = new Size(129, 23);
            button3.TabIndex = 15;
            button3.Text = "Limpiar Registros";
            button3.UseVisualStyleBackColor = true;
            // 
            // frmRegistroIngresos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 634);
            Controls.Add(button3);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(comboBox4);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmRegistroIngresos";
            Text = "frmRegistroIngresos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox2;
        private Label label5;
        private Label label8;
        private ComboBox comboBox3;
        private GroupBox groupBox3;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private Label label6;
        private Label label7;
        private GroupBox groupBox4;
        private TextBox textBox2;
        private Label label9;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private Label label10;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label11;
        private ComboBox comboBox4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Label label13;
        private Label label12;
        private Button button3;
    }
}