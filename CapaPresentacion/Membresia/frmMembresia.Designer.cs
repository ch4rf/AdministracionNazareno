namespace CapaPresentacion
{
    partial class frmMembresia
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
            btnNuevo = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            button1 = new Button();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            txtBuscar = new TextBox();
            dgMiembros = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgMiembros).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 9);
            label1.Name = "label1";
            label1.Size = new Size(286, 65);
            label1.TabIndex = 3;
            label1.Text = "MIEMBROS";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(860, 618);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(165, 33);
            btnNuevo.TabIndex = 23;
            btnNuevo.Text = "NUEVO REGISTRO";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(1727, 1016);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(165, 33);
            btnEliminar.TabIndex = 22;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(1042, 618);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(165, 33);
            btnEditar.TabIndex = 21;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(1042, 566);
            button1.Name = "button1";
            button1.Size = new Size(165, 33);
            button1.TabIndex = 20;
            button1.Text = "ACTUALIZAR TABLA";
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label4.Location = new Point(58, 567);
            label4.Name = "label4";
            label4.Size = new Size(230, 25);
            label4.TabIndex = 19;
            label4.Text = "TOTAL REGISTROS:";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ESTADO", "MINISTERIO" });
            comboBox1.Location = new Point(690, 81);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(222, 33);
            comboBox1.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label3.Location = new Point(608, 89);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 17;
            label3.Text = "POR:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label2.Location = new Point(55, 89);
            label2.Name = "label2";
            label2.Size = new Size(272, 25);
            label2.TabIndex = 16;
            label2.Text = "BUSCAR POR NOMBRE:";
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            txtBuscar.Location = new Point(333, 83);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(258, 31);
            txtBuscar.TabIndex = 15;
            // 
            // dgMiembros
            // 
            dgMiembros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMiembros.Location = new Point(58, 132);
            dgMiembros.Name = "dgMiembros";
            dgMiembros.Size = new Size(1147, 420);
            dgMiembros.TabIndex = 14;
            // 
            // frmMembresia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1904, 1061);
            Controls.Add(btnNuevo);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtBuscar);
            Controls.Add(dgMiembros);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "frmMembresia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NUEVO REGISTRO";
            Load += frmMembresia_Load;
            ((System.ComponentModel.ISupportInitialize)dgMiembros).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button btnEditar;
        private Button button1;
        private Label label4;
        private ComboBox comboBox1;
        private Label label3;
        private Label label2;
        private TextBox txtBuscar;
        private DataGridView dgMiembros;
    }
}