namespace CapaPresentacion.Familias
{
    partial class frmEditarMiembroFamilia
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
            lblRol = new Label();
            lblApellido = new Label();
            btnGuardarCambios = new Button();
            btnCancelar = new Button();
            txtTelefono = new TextBox();
            txtNombres = new TextBox();
            lblNombre = new Label();
            lblTelefono = new Label();
            txtApellidos = new TextBox();
            txtRole = new TextBox();
            SuspendLayout();
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRol.Location = new Point(73, 155);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(30, 17);
            lblRol.TabIndex = 21;
            lblRol.Text = "Rol:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(251, 84);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(60, 17);
            lblApellido.TabIndex = 20;
            lblApellido.Text = "Apellido:";
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardarCambios.Location = new Point(240, 263);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(153, 57);
            btnGuardarCambios.TabIndex = 19;
            btnGuardarCambios.Text = "Guardar Cambios";
            btnGuardarCambios.UseVisualStyleBackColor = true;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(76, 263);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(153, 57);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(251, 175);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(170, 27);
            txtTelefono.TabIndex = 16;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(75, 104);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(170, 27);
            txtNombres.TabIndex = 14;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(75, 84);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(61, 17);
            lblNombre.TabIndex = 13;
            lblNombre.Text = "Nombre:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(251, 155);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(62, 17);
            lblTelefono.TabIndex = 24;
            lblTelefono.Text = "Telefono:";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(251, 104);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(170, 27);
            txtApellidos.TabIndex = 25;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(75, 175);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(170, 27);
            txtRole.TabIndex = 26;
            // 
            // frmEditarMiembroFamilia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 418);
            Controls.Add(txtRole);
            Controls.Add(txtApellidos);
            Controls.Add(lblTelefono);
            Controls.Add(lblRol);
            Controls.Add(lblApellido);
            Controls.Add(btnGuardarCambios);
            Controls.Add(btnCancelar);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombres);
            Controls.Add(lblNombre);
            Name = "frmEditarMiembroFamilia";
            Text = "Editar miembro de la familia";
            Load += frmEditarMiembroFamilia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblRol;
        private Label lblApellido;
        private Button btnGuardarCambios;
        private Button btnCancelar;
        private TextBox txtTelefono;
        private TextBox txtRol;
        private TextBox txtSegundoApe;
        private TextBox txtNombres;
        private Label lblNombre;
        private Label lblTelefono;
       
        private TextBox txtApellidos;
        private TextBox txtRole;
    }
}