namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMembresia frmMembresia = new frmMembresia();
            frmMembresia.MdiParent = this;
            frmMembresia.Show();

        }

        private void registrarMiembroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrar frmRegistrar = new frmRegistrar();
            frmRegistrar.MdiParent = this;
            frmRegistrar.Show();
        }
    }
}
