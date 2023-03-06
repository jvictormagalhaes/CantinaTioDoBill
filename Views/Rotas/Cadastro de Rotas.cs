
namespace CantinaDoTioBill.Views
{
    public partial class FrmCadastroRotas : Form
    {
        public FrmCadastroRotas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTaxa_Click(object sender, EventArgs e)
        {

        }

        private void txtTaxa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}
