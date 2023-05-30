namespace ControleRecursosDAE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void datashowMenuItem_Click(object sender, EventArgs e)
        {
            frmCadDatashow frm = new frmCadDatashow();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}