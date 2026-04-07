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
            frmActividades frmActividades = new frmActividades(); //prueba hecha por jquimy
            frmActividades.Show();                                  //prueba hecha por jquimy
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void gestionFamiliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionFamilias frm = new frmGestionFamilias();
            frm.MdiParent = this;
            frm.Show();
        }

        private void verMinisteriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMinisterios frmMinisterios = new frmMinisterios();
            frmMinisterios.MdiParent = this;
            frmMinisterios.Show();
        }
    }
}
