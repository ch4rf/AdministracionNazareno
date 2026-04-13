namespace CapaPresentacion.Familias
{
    partial class frmNuevaFamilia
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
            lblPApellido = new Label();
            txtPrimerApe = new TextBox();
            txtSegundoApe = new TextBox();
            txtNombreFam = new TextBox();
            txtDireccionFam = new TextBox();
            btnLimpiar = new Button();
            btnGuardarFam = new Button();
            lblSApellido = new Label();
            lblNombreFam = new Label();
            lblDireccionFam = new Label();
            SuspendLayout();
            // 
            // lblPApellido
            // 
            lblPApellido.AutoSize = true;
            lblPApellido.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPApellido.Location = new Point(47, 69);
            lblPApellido.Name = "lblPApellido";
            lblPApellido.Size = new Size(102, 17);
            lblPApellido.TabIndex = 0;
            lblPApellido.Text = "Primer apellido:";
            // 
            // txtPrimerApe
            // 
            txtPrimerApe.Location = new Point(47, 89);
            txtPrimerApe.Name = "txtPrimerApe";
            txtPrimerApe.Size = new Size(153, 27);
            txtPrimerApe.TabIndex = 1;
            txtPrimerApe.TextChanged += txtPrimerApe_TextChanged;
            // 
            // txtSegundoApe
            // 
            txtSegundoApe.Location = new Point(211, 89);
            txtSegundoApe.Name = "txtSegundoApe";
            txtSegundoApe.Size = new Size(153, 27);
            txtSegundoApe.TabIndex = 3;
            txtSegundoApe.TextChanged += txtSegundoApe_TextChanged;
            // 
            // txtNombreFam
            // 
            txtNombreFam.Location = new Point(47, 163);
            txtNombreFam.Name = "txtNombreFam";
            txtNombreFam.ReadOnly = true;
            txtNombreFam.Size = new Size(317, 27);
            txtNombreFam.TabIndex = 5;
            // 
            // txtDireccionFam
            // 
            txtDireccionFam.Location = new Point(47, 233);
            txtDireccionFam.Name = "txtDireccionFam";
            txtDireccionFam.Size = new Size(317, 27);
            txtDireccionFam.TabIndex = 7;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(47, 277);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(153, 57);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardarFam
            // 
            btnGuardarFam.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardarFam.Location = new Point(211, 277);
            btnGuardarFam.Name = "btnGuardarFam";
            btnGuardarFam.Size = new Size(153, 57);
            btnGuardarFam.TabIndex = 9;
            btnGuardarFam.Text = "Guardar Familia";
            btnGuardarFam.UseVisualStyleBackColor = true;
            btnGuardarFam.Click += btnGuardarFam_Click;
            // 
            // lblSApellido
            // 
            lblSApellido.AutoSize = true;
            lblSApellido.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSApellido.Location = new Point(211, 69);
            lblSApellido.Name = "lblSApellido";
            lblSApellido.Size = new Size(116, 17);
            lblSApellido.TabIndex = 10;
            lblSApellido.Text = "Segundo apellido:";
            // 
            // lblNombreFam
            // 
            lblNombreFam.AutoSize = true;
            lblNombreFam.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreFam.Location = new Point(47, 143);
            lblNombreFam.Name = "lblNombreFam";
            lblNombreFam.Size = new Size(137, 17);
            lblNombreFam.TabIndex = 11;
            lblNombreFam.Text = "Nombre de la familia:";
            // 
            // lblDireccionFam
            // 
            lblDireccionFam.AutoSize = true;
            lblDireccionFam.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDireccionFam.Location = new Point(47, 213);
            lblDireccionFam.Name = "lblDireccionFam";
            lblDireccionFam.Size = new Size(121, 17);
            lblDireccionFam.TabIndex = 12;
            lblDireccionFam.Text = "Direccion principal:";
            // 
            // frmNuevaFamilia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 408);
            Controls.Add(lblDireccionFam);
            Controls.Add(lblNombreFam);
            Controls.Add(lblSApellido);
            Controls.Add(btnGuardarFam);
            Controls.Add(btnLimpiar);
            Controls.Add(txtDireccionFam);
            Controls.Add(txtNombreFam);
            Controls.Add(txtSegundoApe);
            Controls.Add(txtPrimerApe);
            Controls.Add(lblPApellido);
            Name = "frmNuevaFamilia";
            Text = "Nueva Familia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPApellido;
        private TextBox txtPrimerApe;
        private TextBox txtSegundoApe;
        private TextBox txtNombreFam;
        private TextBox txtDireccionFam;
        private Button btnLimpiar;
        private Button btnGuardarFam;
        private Label lblSApellido;
        private Label lblNombreFam;
        private Label lblDireccionFam;
    }
}