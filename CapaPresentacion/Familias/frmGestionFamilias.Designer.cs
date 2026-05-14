namespace CapaPresentacion.Familias
{
    partial class frmGestionFamilias
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
            gbMiembrosFamilia = new GroupBox();
            btnEliminar = new Button();
            btnAsignarMiembros = new Button();
            dgMiembrosFamilia = new DataGridView();
            gbFamilias = new GroupBox();
            btnEliminarFam = new Button();
            btnAgregarFamilia = new Button();
            dgFamilias = new DataGridView();
            txtBuscarFamilia = new TextBox();
            lblBuscar = new Label();
            gbMiembrosFamilia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgMiembrosFamilia).BeginInit();
            gbFamilias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgFamilias).BeginInit();
            SuspendLayout();
            // 
            // gbMiembrosFamilia
            // 
            gbMiembrosFamilia.Controls.Add(btnEliminar);
            gbMiembrosFamilia.Controls.Add(btnAsignarMiembros);
            gbMiembrosFamilia.Controls.Add(dgMiembrosFamilia);
            gbMiembrosFamilia.Location = new Point(453, 31);
            gbMiembrosFamilia.Name = "gbMiembrosFamilia";
            gbMiembrosFamilia.Size = new Size(890, 659);
            gbMiembrosFamilia.TabIndex = 1;
            gbMiembrosFamilia.TabStop = false;
            gbMiembrosFamilia.Text = "Miembros de la familia";
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(713, 579);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(171, 55);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar Miembro";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAsignarMiembros
            // 
            btnAsignarMiembros.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAsignarMiembros.Location = new Point(18, 579);
            btnAsignarMiembros.Name = "btnAsignarMiembros";
            btnAsignarMiembros.Size = new Size(185, 55);
            btnAsignarMiembros.TabIndex = 4;
            btnAsignarMiembros.Text = "+ Asignar Miembros";
            btnAsignarMiembros.UseVisualStyleBackColor = true;
            btnAsignarMiembros.Click += btnAsignarMiembros_Click;
            // 
            // dgMiembrosFamilia
            // 
            dgMiembrosFamilia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMiembrosFamilia.Location = new Point(18, 91);
            dgMiembrosFamilia.Name = "dgMiembrosFamilia";
            dgMiembrosFamilia.RowHeadersWidth = 51;
            dgMiembrosFamilia.Size = new Size(866, 481);
            dgMiembrosFamilia.TabIndex = 3;
            dgMiembrosFamilia.CellContentClick += dgMiembrosFamilia_CellContentClick;
            // 
            // gbFamilias
            // 
            gbFamilias.Controls.Add(btnEliminarFam);
            gbFamilias.Controls.Add(btnAgregarFamilia);
            gbFamilias.Controls.Add(dgFamilias);
            gbFamilias.Controls.Add(txtBuscarFamilia);
            gbFamilias.Controls.Add(lblBuscar);
            gbFamilias.Location = new Point(37, 31);
            gbFamilias.Name = "gbFamilias";
            gbFamilias.Size = new Size(395, 659);
            gbFamilias.TabIndex = 2;
            gbFamilias.TabStop = false;
            gbFamilias.Text = "Familias";
            gbFamilias.Enter += gbFamilias_Enter;
            // 
            // btnEliminarFam
            // 
            btnEliminarFam.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminarFam.Location = new Point(199, 579);
            btnEliminarFam.Name = "btnEliminarFam";
            btnEliminarFam.Size = new Size(190, 55);
            btnEliminarFam.TabIndex = 4;
            btnEliminarFam.Text = "- Eliminar Familia\r\n";
            btnEliminarFam.UseVisualStyleBackColor = true;
            btnEliminarFam.Click += btnEliminarFam_Click;
            // 
            // btnAgregarFamilia
            // 
            btnAgregarFamilia.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarFamilia.Location = new Point(6, 579);
            btnAgregarFamilia.Name = "btnAgregarFamilia";
            btnAgregarFamilia.Size = new Size(187, 55);
            btnAgregarFamilia.TabIndex = 3;
            btnAgregarFamilia.Text = "+ Agregar Familia";
            btnAgregarFamilia.UseVisualStyleBackColor = true;
            btnAgregarFamilia.Click += btnAgregarFamilia_Click;
            // 
            // dgFamilias
            // 
            dgFamilias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgFamilias.Location = new Point(6, 91);
            dgFamilias.Name = "dgFamilias";
            dgFamilias.RowHeadersWidth = 51;
            dgFamilias.Size = new Size(383, 481);
            dgFamilias.TabIndex = 2;
            dgFamilias.CellContentClick += dgFamilias_CellContentClick;
            // 
            // txtBuscarFamilia
            // 
            txtBuscarFamilia.Location = new Point(80, 59);
            txtBuscarFamilia.Name = "txtBuscarFamilia";
            txtBuscarFamilia.Size = new Size(309, 27);
            txtBuscarFamilia.TabIndex = 1;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscar.Location = new Point(6, 59);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(68, 23);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar:";
            // 
            // frmGestionFamilias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(gbFamilias);
            Controls.Add(gbMiembrosFamilia);
            Name = "frmGestionFamilias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmGestionFamilias";
            Load += frmGestionFamilias_Load;
            gbMiembrosFamilia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgMiembrosFamilia).EndInit();
            gbFamilias.ResumeLayout(false);
            gbFamilias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgFamilias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbMiembrosFamilia;
        private GroupBox gbFamilia;
        private GroupBox gbFamilias;
        private Label lblBuscar;
        private TextBox txtBuscarFamilia;
        private DataGridView dgMiembrosFamilia;
        private Button btnAgregarFamilia;
        private DataGridView dgFamilias;
        private Button btnEliminar;
        private Button btnAsignarMiembros;
        private Button btnEliminarFam;
    }
}