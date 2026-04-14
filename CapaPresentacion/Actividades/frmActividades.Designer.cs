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
            txtBuscar = new TextBox();
            lbl2 = new Label();
            cmbTipo = new ComboBox();
            cmbMinisterio = new ComboBox();
            lbl3 = new Label();
            lbl4 = new Label();
            dtpDel = new DateTimePicker();
            dtpAl = new DateTimePicker();
            lbl5 = new Label();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            btnNuevaActividad = new Button();
            dg1 = new DataGridView();
            dtpFinalizacion = new DateTimePicker();
            label1 = new Label();
            dtpInicio = new DateTimePicker();
            label2 = new Label();
            cmbLugar = new ComboBox();
            label3 = new Label();
            cmbAnfitrion = new ComboBox();
            label4 = new Label();
            cmbHorario = new ComboBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dg1).BeginInit();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(146, 52);
            lbl1.Margin = new Padding(4, 0, 4, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(71, 23);
            lbl1.TabIndex = 0;
            lbl1.Text = "Buscar";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(149, 79);
            txtBuscar.Margin = new Padding(4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(370, 30);
            txtBuscar.TabIndex = 1;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(657, 52);
            lbl2.Margin = new Padding(4, 0, 4, 0);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(47, 23);
            lbl2.TabIndex = 2;
            lbl2.Text = "Tipo";
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(661, 78);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(370, 31);
            cmbTipo.TabIndex = 4;
            // 
            // cmbMinisterio
            // 
            cmbMinisterio.FormattingEnabled = true;
            cmbMinisterio.Location = new Point(1176, 78);
            cmbMinisterio.Name = "cmbMinisterio";
            cmbMinisterio.Size = new Size(370, 31);
            cmbMinisterio.TabIndex = 6;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(1172, 52);
            lbl3.Margin = new Padding(4, 0, 4, 0);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(94, 23);
            lbl3.TabIndex = 5;
            lbl3.Text = "Ministerio";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Location = new Point(146, 169);
            lbl4.Margin = new Padding(4, 0, 4, 0);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(45, 23);
            lbl4.TabIndex = 7;
            lbl4.Text = "Del:";
            // 
            // dtpDel
            // 
            dtpDel.CustomFormat = "";
            dtpDel.Format = DateTimePickerFormat.Short;
            dtpDel.ImeMode = ImeMode.NoControl;
            dtpDel.Location = new Point(149, 207);
            dtpDel.Name = "dtpDel";
            dtpDel.Size = new Size(152, 30);
            dtpDel.TabIndex = 8;
            dtpDel.Value = new DateTime(2026, 4, 6, 0, 0, 0, 0);
            // 
            // dtpAl
            // 
            dtpAl.CustomFormat = "";
            dtpAl.Format = DateTimePickerFormat.Short;
            dtpAl.ImeMode = ImeMode.NoControl;
            dtpAl.Location = new Point(367, 207);
            dtpAl.Name = "dtpAl";
            dtpAl.Size = new Size(152, 30);
            dtpAl.TabIndex = 10;
            dtpAl.Value = new DateTime(2026, 4, 6, 0, 0, 0, 0);
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Location = new Point(364, 169);
            lbl5.Margin = new Padding(4, 0, 4, 0);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(33, 23);
            lbl5.TabIndex = 9;
            lbl5.Text = "Al:";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(1321, 259);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(131, 48);
            btnBuscar.TabIndex = 11;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(1511, 259);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(131, 48);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // btnNuevaActividad
            // 
            btnNuevaActividad.Location = new Point(149, 418);
            btnNuevaActividad.Name = "btnNuevaActividad";
            btnNuevaActividad.Size = new Size(370, 48);
            btnNuevaActividad.TabIndex = 13;
            btnNuevaActividad.Text = "Nueva Actividad";
            btnNuevaActividad.UseVisualStyleBackColor = true;
            btnNuevaActividad.Click += btnNuevaActividad_Click_v2;
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
            dg1.CellContentClick += dg1_CellContentClick;
            // 
            // dtpFinalizacion
            // 
            dtpFinalizacion.CustomFormat = "HH:mm";
            dtpFinalizacion.Format = DateTimePickerFormat.Custom;
            dtpFinalizacion.ImeMode = ImeMode.NoControl;
            dtpFinalizacion.Location = new Point(1383, 207);
            dtpFinalizacion.Name = "dtpFinalizacion";
            dtpFinalizacion.ShowUpDown = true;
            dtpFinalizacion.Size = new Size(152, 30);
            dtpFinalizacion.TabIndex = 18;
            dtpFinalizacion.Value = new DateTime(2026, 4, 6, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1380, 169);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(192, 23);
            label1.TabIndex = 17;
            label1.Text = "Hora de Finalización:";
            // 
            // dtpInicio
            // 
            dtpInicio.CustomFormat = "HH:mm";
            dtpInicio.Format = DateTimePickerFormat.Custom;
            dtpInicio.ImeMode = ImeMode.NoControl;
            dtpInicio.Location = new Point(1165, 207);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.ShowUpDown = true;
            dtpInicio.Size = new Size(152, 30);
            dtpInicio.TabIndex = 16;
            dtpInicio.Value = new DateTime(2026, 4, 6, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1162, 169);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(137, 23);
            label2.TabIndex = 15;
            label2.Text = "Hora de Inicio:";
            // 
            // cmbLugar
            // 
            cmbLugar.FormattingEnabled = true;
            cmbLugar.Location = new Point(149, 323);
            cmbLugar.Name = "cmbLugar";
            cmbLugar.Size = new Size(370, 31);
            cmbLugar.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(145, 297);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 23);
            label3.TabIndex = 19;
            label3.Text = "Lugar";
            // 
            // cmbAnfitrion
            // 
            cmbAnfitrion.FormattingEnabled = true;
            cmbAnfitrion.Location = new Point(661, 323);
            cmbAnfitrion.Name = "cmbAnfitrion";
            cmbAnfitrion.Size = new Size(370, 31);
            cmbAnfitrion.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(657, 297);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(170, 23);
            label4.TabIndex = 21;
            label4.Text = "Miembro Anfritrión";
            // 
            // cmbHorario
            // 
            cmbHorario.FormattingEnabled = true;
            cmbHorario.Location = new Point(661, 206);
            cmbHorario.Name = "cmbHorario";
            cmbHorario.Size = new Size(370, 31);
            cmbHorario.TabIndex = 24;
            cmbHorario.SelectedIndexChanged += cmbHorario_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(657, 180);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(74, 23);
            label5.TabIndex = 23;
            label5.Text = "Horario";
            // 
            // frmActividades
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1011);
            Controls.Add(cmbHorario);
            Controls.Add(label5);
            Controls.Add(cmbAnfitrion);
            Controls.Add(label4);
            Controls.Add(cmbLugar);
            Controls.Add(label3);
            Controls.Add(dtpFinalizacion);
            Controls.Add(label1);
            Controls.Add(dtpInicio);
            Controls.Add(label2);
            Controls.Add(dg1);
            Controls.Add(btnNuevaActividad);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscar);
            Controls.Add(dtpAl);
            Controls.Add(lbl5);
            Controls.Add(dtpDel);
            Controls.Add(lbl4);
            Controls.Add(cmbMinisterio);
            Controls.Add(lbl3);
            Controls.Add(cmbTipo);
            Controls.Add(lbl2);
            Controls.Add(txtBuscar);
            Controls.Add(lbl1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmActividades";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actividades";
            Load += frmActividades_Load;
            Click += frmActividades_Click;
            ((System.ComponentModel.ISupportInitialize)dg1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private TextBox txtBuscar;
        private Label lbl2;
        private ComboBox cmbTipo;
        private ComboBox cmbMinisterio;
        private Label lbl3;
        private Label lbl4;
        private DateTimePicker dtpDel;
        private DateTimePicker dtpAl;
        private Label lbl5;
        private Button btnBuscar;
        private Button btnLimpiar;
        private Button btnNuevaActividad;
        private DataGridView dg1;
        private DateTimePicker dtpFinalizacion;
        private Label label1;
        private DateTimePicker dtpInicio;
        private Label label2;
        private ComboBox cmbLugar;
        private Label label3;
        private ComboBox cmbAnfitrion;
        private Label label4;
        private ComboBox cmbHorario;
        private Label label5;
    }
}