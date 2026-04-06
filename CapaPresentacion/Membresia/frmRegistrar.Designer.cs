namespace CapaPresentacion
{
    partial class frmRegistrar
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(2, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1254, 694);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1246, 666);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "DATOS PERSONALES";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1246, 666);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "UBICACION Y CONTACTO";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1246, 666);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "PERFIL ECLESIASTICO";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1246, 666);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "FAMILIA";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(23, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(565, 488);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "INFORMACION DE IDENTIDAD";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(614, 29);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(567, 488);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "PERFIL DEMOGRAFICO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 71);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "NOMBRES:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 219);
            label2.Name = "label2";
            label2.Size = new Size(184, 15);
            label2.TabIndex = 1;
            label2.Text = "DOCUMENTO DE IDENTIFICAION:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 143);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 2;
            label3.Text = "APELLIDOS:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 324);
            label4.Name = "label4";
            label4.Size = new Size(135, 15);
            label4.TabIndex = 3;
            label4.Text = "FECHA DE NACIMIENTO";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(9, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(268, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 174);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(271, 23);
            textBox2.TabIndex = 5;
            // 
            // frmRegistrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 697);
            Controls.Add(tabControl1);
            Name = "frmRegistrar";
            Text = "frmRegistrar";
            Load += frmRegistrar_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}