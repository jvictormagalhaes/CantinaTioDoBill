
using MessageUtils;

namespace CantinaDoTioBill
{
    public partial class FrmCadastroProdutos : Form
    {
        public FrmCadastroProdutos()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtNome.MaxLength = 100;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmCadastroProdutos_Load(object sender, EventArgs e)
        {

        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (VerificarCampoVazio() == true) {
                DialogResult = DialogResult.OK;
            }
        }

        private void txtEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtValorUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
        }

        private bool VerificarCampoVazio()
        {
            bool verificacao = true;

            if (txtNome.Text.Length == 0 ||
                txtValorUnitario.Text.Length == 0 ||
                txtEstoque.Text.Length == 0)
            {
                SimpleMessage.Error("Há campo(os) em branco!", " Erro");
                verificacao = false;
            }
            return verificacao;
        }

        private void txtValorUnitario_TextChanged(object sender, EventArgs e)
        {
            txtValorUnitario.MaxLength = 5;
        }

        private void txtEstoque_TextChanged(object sender, EventArgs e)
        {
            txtEstoque.MaxLength = 5;
        }
    }
}
