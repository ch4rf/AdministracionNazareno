namespace CapaPresentacion.Familias
{
    partial class frmAsignarMiembrosFamilia
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
            lblMostrar = new Label();
            txtBuscarMiembros = new TextBox();
            dgMiembrosAsignar = new DataGridView();
            dgMiembrosAsignados = new DataGridView();
            lblSeleccionados = new Label();
            btnLimpiar = new Button();
            btnAsignar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgMiembrosAsignar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgMiembrosAsignados).BeginInit();
            SuspendLayout();
            // 
            // lblMostrar
            // 
            lblMostrar.AutoSize = true;
            lblMostrar.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMostrar.Location = new Point(49, 19);
            lblMostrar.Name = "lblMostrar";
            lblMostrar.Size = new Size(293, 17);
            lblMostrar.TabIndex = 0;
            lblMostrar.Text = "Mostrando personas con apellidos ape1 u ape2";
            lblMostrar.Click += lblMostrar_Click;
            // 
            // txtBuscarMiembros
            // 
            txtBuscarMiembros.Location = new Point(49, 42);
            txtBuscarMiembros.Name = "txtBuscarMiembros";
            txtBuscarMiembros.Size = new Size(424, 27);
            txtBuscarMiembros.TabIndex = 1;
            txtBuscarMiembros.TextChanged += txtBuscarMiembros_TextChanged;
            // 
            // dgMiembrosAsignar
            // 
            dgMiembrosAsignar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMiembrosAsignar.Location = new Point(49, 85);
            dgMiembrosAsignar.Name = "dgMiembrosAsignar";
            dgMiembrosAsignar.RowHeadersWidth = 51;
            dgMiembrosAsignar.Size = new Size(424, 188);
            dgMiembrosAsignar.TabIndex = 2;
            dgMiembrosAsignar.CellClick += dgMiembrosAsignar_CellContentClick;
            dgMiembrosAsignar.CellContentClick += dgMiembrosAsignar_CellContentClick;
            // 
            // dgMiembrosAsignados
            // 
            dgMiembrosAsignados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMiembrosAsignados.Location = new Point(49, 289);
            dgMiembrosAsignados.Name = "dgMiembrosAsignados";
            dgMiembrosAsignados.RowHeadersWidth = 51;
            dgMiembrosAsignados.Size = new Size(424, 188);
            dgMiembrosAsignados.TabIndex = 3;
            // 
            // lblSeleccionados
            // 
            lblSeleccionados.AutoSize = true;
            lblSeleccionados.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSeleccionados.Location = new Point(49, 500);
            lblSeleccionados.Name = "lblSeleccionados";
            lblSeleccionados.Size = new Size(0, 17);
            lblSeleccionados.TabIndex = 4;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(279, 483);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 46);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnAsignar
            // 
            btnAsignar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAsignar.Location = new Point(379, 483);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(94, 46);
            btnAsignar.TabIndex = 6;
            btnAsignar.Text = "Asignar";
            btnAsignar.UseVisualStyleBackColor = true;
            btnAsignar.Click += btnAsignar_Click;
            // 
            // frmAsignarMiembrosFamilia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 556);
            Controls.Add(btnAsignar);
            Controls.Add(btnLimpiar);
            Controls.Add(lblSeleccionados);
            Controls.Add(dgMiembrosAsignados);
            Controls.Add(dgMiembrosAsignar);
            Controls.Add(txtBuscarMiembros);
            Controls.Add(lblMostrar);
            Name = "frmAsignarMiembrosFamilia";
            Text = "Asignar Miembro a la familia";
            Load += frmAsignarMiembrosFamilia_Load;
            ((System.ComponentModel.ISupportInitialize)dgMiembrosAsignar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgMiembrosAsignados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMostrar;
        private TextBox txtBuscarMiembros;
        private DataGridView dgMiembrosAsignar;
        private DataGridView dgMiembrosAsignados;
        private Label lblSeleccionados;
        private Button btnLimpiar;
        private Button btnAsignar;
    }
}