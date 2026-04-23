namespace CapaPresentacion
{
    partial class Frm_Egresos
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            txtConcepto = new TextBox();
            numericUpDown2 = new NumericUpDown();
            txtMonto = new TextBox();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            dvgEgresos = new DataGridView();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgEgresos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(87, 121);
            label1.Name = "label1";
            label1.Size = new Size(40, 25);
            label1.TabIndex = 0;
            label1.Text = "No.";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(283, 121);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 1;
            label2.Text = "Concepto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(634, 121);
            label3.Name = "label3";
            label3.Size = new Size(94, 25);
            label3.TabIndex = 2;
            label3.Text = "No. Pagos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(841, 122);
            label4.Name = "label4";
            label4.Size = new Size(147, 25);
            label4.TabIndex = 3;
            label4.Text = "Monto Asignado";
            label4.Click += label4_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(87, 149);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(107, 27);
            numericUpDown1.TabIndex = 4;
            // 
            // txtConcepto
            // 
            txtConcepto.Location = new Point(277, 149);
            txtConcepto.Name = "txtConcepto";
            txtConcepto.Size = new Size(304, 27);
            txtConcepto.TabIndex = 5;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(634, 150);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(130, 27);
            numericUpDown2.TabIndex = 6;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(841, 150);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(282, 27);
            txtMonto.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(283, 235);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(168, 54);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar Registro";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(515, 235);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(168, 54);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar Campos";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(748, 235);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(170, 54);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dvgEgresos
            // 
            dvgEgresos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgEgresos.Location = new Point(40, 328);
            dvgEgresos.Name = "dvgEgresos";
            dvgEgresos.RowHeadersWidth = 51;
            dvgEgresos.Size = new Size(1144, 313);
            dvgEgresos.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(311, 22);
            label5.Name = "label5";
            label5.Size = new Size(507, 41);
            label5.TabIndex = 16;
            label5.Text = "Formulario de Registro de Egresos";
            label5.Click += label5_Click;
            // 
            // Frm_Egresos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 653);
            Controls.Add(label5);
            Controls.Add(dvgEgresos);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(txtMonto);
            Controls.Add(numericUpDown2);
            Controls.Add(txtConcepto);
            Controls.Add(numericUpDown1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Frm_Egresos";
            Text = "Frm_Egresos";
            Load += Frm_Egresos_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgEgresos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private TextBox txtConcepto;
        private NumericUpDown numericUpDown2;
        private TextBox txtMonto;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnEliminar;
        private DataGridView dvgEgresos;
        private Label label5;
    }
}