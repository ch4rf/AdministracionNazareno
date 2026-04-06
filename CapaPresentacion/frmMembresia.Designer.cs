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
            dgMiembros = new DataGridView();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgMiembros).BeginInit();
            SuspendLayout();
            // 
            // dgMiembros
            // 
            dgMiembros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMiembros.Location = new Point(56, 286);
            dgMiembros.Name = "dgMiembros";
            dgMiembros.Size = new Size(1147, 420);
            dgMiembros.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 197);
            label1.Name = "label1";
            label1.Size = new Size(380, 86);
            label1.TabIndex = 3;
            label1.Text = "MIEMBROS";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            textBox1.Location = new Point(945, 233);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(258, 31);
            textBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label2.Location = new Point(827, 236);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 6;
            label2.Text = "BUSCAR:";
            // 
            // frmMembresia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(dgMiembros);
            Controls.Add(label1);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "frmMembresia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MEMBRESIA";
            Load += frmMembresia_Load;
            ((System.ComponentModel.ISupportInitialize)dgMiembros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgMiembros;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
    }
}