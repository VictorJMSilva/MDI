namespace MDI
{
    public partial class MDI : Form
    {
        FrmAgenda? Cadastro;
        FrmCEP? CEP;
        FrmSobre? Sobre;
        public MDI()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Cadastro == null)
            {
                Cadastro = new FrmAgenda();
                Cadastro.MdiParent = this;  
                Cadastro.WindowState = FormWindowState.Maximized;
                Cadastro.Show();
            }
            else
            {
                Cadastro.Activate();
            }
        }

        private void cEPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(CEP == null)
            {
                CEP = new FrmCEP();
                CEP.MdiParent = this;
                CEP.WindowState = FormWindowState.Maximized;    
                CEP.Show();
            }
            else
            {
                CEP.Activate(); 
            }
        }
        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Sobre == null)
            {
                Sobre = new FrmSobre();
                Sobre.ShowDialog();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}