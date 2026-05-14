namespace CapaPresentacion.Mantenimiento
{
    partial class frmMantenimientoCatalogos
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
            cmbCatalogos = new ComboBox();
            gbMantenimiento = new GroupBox();
            dgDatos = new DataGridView();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnGuardarNuevo = new Button();
            txtDescripcion = new TextBox();
            label2 = new Label();
            label1 = new Label();
            gbMantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgDatos).BeginInit();
            SuspendLayout();
            // 
            // cmbCatalogos
            // 
            cmbCatalogos.FormattingEnabled = true;
            cmbCatalogos.Items.AddRange(new object[] { "Profesiones", "Motivos de Retiro", "Tipos de Recepción", "Ministerios", "Tipos de Actividad", "Lugar", "Horario" });
            cmbCatalogos.Location = new Point(182, 67);
            cmbCatalogos.Margin = new Padding(3, 4, 3, 4);
            cmbCatalogos.Name = "cmbCatalogos";
            cmbCatalogos.Size = new Size(210, 28);
            cmbCatalogos.TabIndex = 0;
            cmbCatalogos.SelectedIndexChanged += cmbCatalogos_SelectedIndexChanged;
            // 
            // gbMantenimiento
            // 
            gbMantenimiento.Controls.Add(dgDatos);
            gbMantenimiento.Controls.Add(btnEliminar);
            gbMantenimiento.Controls.Add(btnLimpiar);
            gbMantenimiento.Controls.Add(btnGuardarNuevo);
            gbMantenimiento.Controls.Add(txtDescripcion);
            gbMantenimiento.Controls.Add(label2);
            gbMantenimiento.Controls.Add(label1);
            gbMantenimiento.Controls.Add(cmbCatalogos);
            gbMantenimiento.Location = new Point(69, 56);
            gbMantenimiento.Margin = new Padding(3, 4, 3, 4);
            gbMantenimiento.Name = "gbMantenimiento";
            gbMantenimiento.Padding = new Padding(3, 4, 3, 4);
            gbMantenimiento.Size = new Size(582, 813);
            gbMantenimiento.TabIndex = 1;
            gbMantenimiento.TabStop = false;
            gbMantenimiento.Text = "Mantenimiento";
            // 
            // dgDatos
            // 
            dgDatos.AllowUserToAddRows = false;
            dgDatos.AllowUserToDeleteRows = false;
            dgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDatos.Location = new Point(37, 229);
            dgDatos.Margin = new Padding(3, 4, 3, 4);
            dgDatos.Name = "dgDatos";
            dgDatos.RowHeadersWidth = 51;
            dgDatos.Size = new Size(362, 489);
            dgDatos.TabIndex = 7;
            dgDatos.CellClick += dgDatos_CellClick;
            dgDatos.CellContentClick += dgDatos_CellContentClick;
            dgDatos.CellDoubleClick += dgDatos_CellDoubleClick;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(430, 331);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(115, 56);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(406, 121);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(115, 56);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardarNuevo
            // 
            btnGuardarNuevo.Location = new Point(430, 267);
            btnGuardarNuevo.Margin = new Padding(3, 4, 3, 4);
            btnGuardarNuevo.Name = "btnGuardarNuevo";
            btnGuardarNuevo.Size = new Size(115, 56);
            btnGuardarNuevo.TabIndex = 4;
            btnGuardarNuevo.Text = "Guardar Nuevo";
            btnGuardarNuevo.UseVisualStyleBackColor = true;
            btnGuardarNuevo.Click += btnGuardarNuevo_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(182, 136);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(217, 27);
            txtDescripcion.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 140);
            label2.Name = "label2";
            label2.Size = new Size(151, 20);
            label2.TabIndex = 2;
            label2.Text = "Descripción/Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 71);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 1;
            label1.Text = "Seleccione el catalogo:";
            // 
            // frmMantenimientoCatalogos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1924, 1055);
            Controls.Add(gbMantenimiento);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMantenimientoCatalogos";
            Text = "MantenimientoCatalogos";
            Load += MantenimientoCatalogos_Load;
            gbMantenimiento.ResumeLayout(false);
            gbMantenimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbCatalogos;
        private GroupBox gbMantenimiento;
        private Label label1;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnGuardarNuevo;
        private TextBox txtDescripcion;
        private Label label2;
        private DataGridView dgDatos;
    }
}