namespace CapaPresentacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            miembrosToolStripMenuItem = new ToolStripMenuItem();
            verToolStripMenuItem = new ToolStripMenuItem();
            gestionFamiliaToolStripMenuItem = new ToolStripMenuItem();
            ministeriosToolStripMenuItem = new ToolStripMenuItem();
            verMinisteriosToolStripMenuItem = new ToolStripMenuItem();
            actividadesToolStripMenuItem = new ToolStripMenuItem();
            verActividadesToolStripMenuItem = new ToolStripMenuItem();
            catalogosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { miembrosToolStripMenuItem, ministeriosToolStripMenuItem, actividadesToolStripMenuItem, catalogosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // miembrosToolStripMenuItem
            // 
            miembrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { verToolStripMenuItem, gestionFamiliaToolStripMenuItem });
            miembrosToolStripMenuItem.Name = "miembrosToolStripMenuItem";
            miembrosToolStripMenuItem.Size = new Size(90, 24);
            miembrosToolStripMenuItem.Text = "Miembros";
            // 
            // verToolStripMenuItem
            // 
            verToolStripMenuItem.Name = "verToolStripMenuItem";
            verToolStripMenuItem.Size = new Size(224, 26);
            verToolStripMenuItem.Text = "Ver Miembros";
            verToolStripMenuItem.Click += verToolStripMenuItem_Click;
            // 
            // gestionFamiliaToolStripMenuItem
            // 
            gestionFamiliaToolStripMenuItem.Name = "gestionFamiliaToolStripMenuItem";
            gestionFamiliaToolStripMenuItem.Size = new Size(224, 26);
            gestionFamiliaToolStripMenuItem.Text = "Gestion Familia";
            gestionFamiliaToolStripMenuItem.Click += gestionFamiliaToolStripMenuItem_Click;
            // 
            // ministeriosToolStripMenuItem
            // 
            ministeriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { verMinisteriosToolStripMenuItem });
            ministeriosToolStripMenuItem.Name = "ministeriosToolStripMenuItem";
            ministeriosToolStripMenuItem.Size = new Size(95, 24);
            ministeriosToolStripMenuItem.Text = "Ministerios";
            // 
            // verMinisteriosToolStripMenuItem
            // 
            verMinisteriosToolStripMenuItem.Name = "verMinisteriosToolStripMenuItem";
            verMinisteriosToolStripMenuItem.Size = new Size(189, 26);
            verMinisteriosToolStripMenuItem.Text = "Ver Ministerios";
            verMinisteriosToolStripMenuItem.Click += verMinisteriosToolStripMenuItem_Click;
            // 
            // actividadesToolStripMenuItem
            // 
            actividadesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { verActividadesToolStripMenuItem });
            actividadesToolStripMenuItem.Name = "actividadesToolStripMenuItem";
            actividadesToolStripMenuItem.Size = new Size(100, 24);
            actividadesToolStripMenuItem.Text = "Actividades";
            // 
            // verActividadesToolStripMenuItem
            // 
            verActividadesToolStripMenuItem.Name = "verActividadesToolStripMenuItem";
            verActividadesToolStripMenuItem.Size = new Size(194, 26);
            verActividadesToolStripMenuItem.Text = "Ver Actividades";
            verActividadesToolStripMenuItem.Click += verActividadesToolStripMenuItem_Click;
            // 
            // catalogosToolStripMenuItem
            // 
            catalogosToolStripMenuItem.Name = "catalogosToolStripMenuItem";
            catalogosToolStripMenuItem.Size = new Size(90, 24);
            catalogosToolStripMenuItem.Text = "Catalogos";
            catalogosToolStripMenuItem.Click += catalogosToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem miembrosToolStripMenuItem;
        private ToolStripMenuItem verToolStripMenuItem;
        private ToolStripMenuItem gestionFamiliaToolStripMenuItem;
        private ToolStripMenuItem ministeriosToolStripMenuItem;
        private ToolStripMenuItem verMinisteriosToolStripMenuItem;
        private ToolStripMenuItem actividadesToolStripMenuItem;
        private ToolStripMenuItem verActividadesToolStripMenuItem;
        private ToolStripMenuItem catalogosToolStripMenuItem;
    }
}
