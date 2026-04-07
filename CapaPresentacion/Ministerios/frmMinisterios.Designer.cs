namespace CapaPresentacion
{
    partial class frmMinisterios
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
            dgMinisterios = new DataGridView();
            textBox1 = new TextBox();
            label2 = new Label();
            gbMinisterios = new GroupBox();
            btnNuevoMinisterio = new Button();
            groupBox1 = new GroupBox();
            dgMiembros = new DataGridView();
            btnAsignarMiebro = new Button();
            ((System.ComponentModel.ISupportInitialize)dgMinisterios).BeginInit();
            gbMinisterios.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgMiembros).BeginInit();
            SuspendLayout();
            // 
            // dgMinisterios
            // 
            dgMinisterios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMinisterios.Location = new Point(44, 86);
            dgMinisterios.Name = "dgMinisterios";
            dgMinisterios.ReadOnly = true;
            dgMinisterios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgMinisterios.Size = new Size(193, 345);
            dgMinisterios.TabIndex = 1;
            dgMinisterios.CellClick += dgMinisterios_CellClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(95, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(142, 23);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 57);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 3;
            label2.Text = "Buscar:";
            // 
            // gbMinisterios
            // 
            gbMinisterios.Controls.Add(btnNuevoMinisterio);
            gbMinisterios.Controls.Add(dgMinisterios);
            gbMinisterios.Controls.Add(label2);
            gbMinisterios.Controls.Add(textBox1);
            gbMinisterios.Location = new Point(12, 12);
            gbMinisterios.Name = "gbMinisterios";
            gbMinisterios.Size = new Size(268, 527);
            gbMinisterios.TabIndex = 4;
            gbMinisterios.TabStop = false;
            gbMinisterios.Text = "Ministerios";
            // 
            // btnNuevoMinisterio
            // 
            btnNuevoMinisterio.Location = new Point(55, 450);
            btnNuevoMinisterio.Name = "btnNuevoMinisterio";
            btnNuevoMinisterio.Size = new Size(149, 38);
            btnNuevoMinisterio.TabIndex = 4;
            btnNuevoMinisterio.Text = "+ Nuevo Ministerio";
            btnNuevoMinisterio.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAsignarMiebro);
            groupBox1.Controls.Add(dgMiembros);
            groupBox1.Location = new Point(286, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(912, 527);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Miembros por Ministerio";
            // 
            // dgMiembros
            // 
            dgMiembros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMiembros.Location = new Point(16, 86);
            dgMiembros.Name = "dgMiembros";
            dgMiembros.Size = new Size(861, 345);
            dgMiembros.TabIndex = 1;
            // 
            // btnAsignarMiebro
            // 
            btnAsignarMiebro.Location = new Point(16, 450);
            btnAsignarMiebro.Name = "btnAsignarMiebro";
            btnAsignarMiebro.Size = new Size(149, 38);
            btnAsignarMiebro.TabIndex = 5;
            btnAsignarMiebro.Text = "+ Asignar Miembro";
            btnAsignarMiebro.UseVisualStyleBackColor = true;
            // 
            // frmMinisterios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1904, 1061);
            Controls.Add(groupBox1);
            Controls.Add(gbMinisterios);
            Name = "frmMinisterios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMinisterios";
            Load += frmMinisterios_Load;
            ((System.ComponentModel.ISupportInitialize)dgMinisterios).EndInit();
            gbMinisterios.ResumeLayout(false);
            gbMinisterios.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgMiembros).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgMinisterios;
        private TextBox textBox1;
        private Label label2;
        private GroupBox gbMinisterios;
        private Button btnNuevoMinisterio;
        private GroupBox groupBox1;
        private DataGridView dgMiembros;
        private Button btnAsignarMiebro;
    }
}