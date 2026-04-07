namespace CapaPresentacion.Mantenimiento
{
    partial class MantenimientoCatalogos
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
            btnActualizar = new Button();
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
            cmbCatalogos.Location = new Point(159, 50);
            cmbCatalogos.Name = "cmbCatalogos";
            cmbCatalogos.Size = new Size(121, 23);
            cmbCatalogos.TabIndex = 0;
            cmbCatalogos.SelectedIndexChanged += cmbCatalogos_SelectedIndexChanged;
            // 
            // gbMantenimiento
            // 
            gbMantenimiento.Controls.Add(dgDatos);
            gbMantenimiento.Controls.Add(btnEliminar);
            gbMantenimiento.Controls.Add(btnActualizar);
            gbMantenimiento.Controls.Add(btnGuardarNuevo);
            gbMantenimiento.Controls.Add(txtDescripcion);
            gbMantenimiento.Controls.Add(label2);
            gbMantenimiento.Controls.Add(label1);
            gbMantenimiento.Controls.Add(cmbCatalogos);
            gbMantenimiento.Location = new Point(60, 42);
            gbMantenimiento.Name = "gbMantenimiento";
            gbMantenimiento.Size = new Size(934, 610);
            gbMantenimiento.TabIndex = 1;
            gbMantenimiento.TabStop = false;
            gbMantenimiento.Text = "Mantenimiento";
            // 
            // dgDatos
            // 
            dgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDatos.Location = new Point(42, 183);
            dgDatos.Name = "dgDatos";
            dgDatos.Size = new Size(815, 370);
            dgDatos.TabIndex = 7;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(694, 102);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(101, 42);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(576, 102);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(101, 42);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnGuardarNuevo
            // 
            btnGuardarNuevo.Location = new Point(454, 102);
            btnGuardarNuevo.Name = "btnGuardarNuevo";
            btnGuardarNuevo.Size = new Size(101, 42);
            btnGuardarNuevo.TabIndex = 4;
            btnGuardarNuevo.Text = "Guardar Nuevo";
            btnGuardarNuevo.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(153, 113);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(273, 23);
            txtDescripcion.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 116);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 2;
            label2.Text = "Descripción/Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 53);
            label1.Name = "label1";
            label1.Size = new Size(127, 15);
            label1.TabIndex = 1;
            label1.Text = "Seleccione el catalogo:";
            // 
            // MantenimientoCatalogos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1061);
            Controls.Add(gbMantenimiento);
            Name = "MantenimientoCatalogos";
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
        private Button btnActualizar;
        private Button btnGuardarNuevo;
        private TextBox txtDescripcion;
        private Label label2;
        private DataGridView dgDatos;
    }
}