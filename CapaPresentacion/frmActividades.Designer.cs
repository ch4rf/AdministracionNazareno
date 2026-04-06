namespace CapaPresentacion
{
    partial class frmActividades
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
            lbl1 = new Label();
            txt1 = new TextBox();
            lbl2 = new Label();
            cmbTipo = new ComboBox();
            cmbMinisterio = new ComboBox();
            lbl3 = new Label();
            lbl4 = new Label();
            dtpBuscar = new DateTimePicker();
            dtpHasta = new DateTimePicker();
            lbl5 = new Label();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            btnNuevaActividad = new Button();
            dg1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dg1).BeginInit();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(117, 119);
            lbl1.Margin = new Padding(4, 0, 4, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(71, 23);
            lbl1.TabIndex = 0;
            lbl1.Text = "Buscar";
            // 
            // txt1
            // 
            txt1.Location = new Point(120, 146);
            txt1.Margin = new Padding(4);
            txt1.Name = "txt1";
            txt1.Size = new Size(370, 30);
            txt1.TabIndex = 1;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(610, 119);
            lbl2.Margin = new Padding(4, 0, 4, 0);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(47, 23);
            lbl2.TabIndex = 2;
            lbl2.Text = "Tipo";
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(614, 145);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(370, 31);
            cmbTipo.TabIndex = 4;
            // 
            // cmbMinisterio
            // 
            cmbMinisterio.FormattingEnabled = true;
            cmbMinisterio.Location = new Point(1147, 145);
            cmbMinisterio.Name = "cmbMinisterio";
            cmbMinisterio.Size = new Size(370, 31);
            cmbMinisterio.TabIndex = 6;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(1143, 119);
            lbl3.Margin = new Padding(4, 0, 4, 0);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(94, 23);
            lbl3.TabIndex = 5;
            lbl3.Text = "Ministerio";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Location = new Point(117, 236);
            lbl4.Margin = new Padding(4, 0, 4, 0);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(71, 23);
            lbl4.TabIndex = 7;
            lbl4.Text = "Buscar";
            // 
            // dtpBuscar
            // 
            dtpBuscar.CustomFormat = "";
            dtpBuscar.Format = DateTimePickerFormat.Short;
            dtpBuscar.ImeMode = ImeMode.NoControl;
            dtpBuscar.Location = new Point(120, 274);
            dtpBuscar.Name = "dtpBuscar";
            dtpBuscar.Size = new Size(152, 30);
            dtpBuscar.TabIndex = 8;
            dtpBuscar.Value = new DateTime(2026, 4, 6, 0, 0, 0, 0);
            // 
            // dtpHasta
            // 
            dtpHasta.CustomFormat = "";
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.ImeMode = ImeMode.NoControl;
            dtpHasta.Location = new Point(338, 274);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(152, 30);
            dtpHasta.TabIndex = 10;
            dtpHasta.Value = new DateTime(2026, 4, 6, 0, 0, 0, 0);
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Location = new Point(335, 236);
            lbl5.Margin = new Padding(4, 0, 4, 0);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(61, 23);
            lbl5.TabIndex = 9;
            lbl5.Text = "Hasta";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(663, 260);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(131, 48);
            btnBuscar.TabIndex = 11;
            btnBuscar.Text = "Buscar1";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(853, 260);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(131, 48);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnNuevaActividad
            // 
            btnNuevaActividad.Location = new Point(120, 396);
            btnNuevaActividad.Name = "btnNuevaActividad";
            btnNuevaActividad.Size = new Size(370, 48);
            btnNuevaActividad.TabIndex = 13;
            btnNuevaActividad.Text = "Nueva Actividad";
            btnNuevaActividad.UseVisualStyleBackColor = true;
            // 
            // dg1
            // 
            dg1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg1.Location = new Point(120, 487);
            dg1.Name = "dg1";
            dg1.RowHeadersWidth = 51;
            dg1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg1.Size = new Size(1626, 452);
            dg1.TabIndex = 14;
            // 
            // frmActividades
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1011);
            Controls.Add(dg1);
            Controls.Add(btnNuevaActividad);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscar);
            Controls.Add(dtpHasta);
            Controls.Add(lbl5);
            Controls.Add(dtpBuscar);
            Controls.Add(lbl4);
            Controls.Add(cmbMinisterio);
            Controls.Add(lbl3);
            Controls.Add(cmbTipo);
            Controls.Add(lbl2);
            Controls.Add(txt1);
            Controls.Add(lbl1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmActividades";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actividades";
            Load += frmActividades_Load;
            ((System.ComponentModel.ISupportInitialize)dg1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private TextBox txt1;
        private Label lbl2;
        private ComboBox cmbTipo;
        private ComboBox cmbMinisterio;
        private Label lbl3;
        private Label lbl4;
        private DateTimePicker dtpBuscar;
        private DateTimePicker dtpHasta;
        private Label lbl5;
        private Button btnBuscar;
        private Button btnLimpiar;
        private Button btnNuevaActividad;
        private DataGridView dg1;
    }
}