
using MessageUtils;
using Microsoft.VisualBasic;

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
            if (VerificarCampoVazio() == true)
            {
                DialogResult = DialogResult.OK;
            }
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
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
        }

        private bool VerificarCampoVazio()
        {
            bool verificacao = true;

            if (txtNomeRota.Text.Length == 0 ||
                txtTaxa.Text.Length == 0)
            {
                SimpleMessage.Error("Há campo(os) em branco", "Erro");
                verificacao = false;
            }
            return verificacao;
        }
    }
}
