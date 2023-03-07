
using MessageUtils;


namespace CantinaDoTioBill
{
    public partial class FrmCadastroCliente : Form
    {
        public FrmCadastroCliente()
        {
            InitializeComponent();
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void FrmCadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void bntSalvar_Click(object sender, EventArgs e)
        {
            if(VerificarCampoVazio() == true)
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void btnSalvar_Leave(object sender, EventArgs e)
        {
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void lvlNumero_Click(object sender, EventArgs e)
        {

        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBairro_Click(object sender, EventArgs e)
        {

        }

        private void txtRg_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRg_Click(object sender, EventArgs e)
        {

        }

        private void lblCpf_Click(object sender, EventArgs e)
        {

        }

        private void lblEndereco_Click(object sender, EventArgs e)
        {

        }

        private void lblTelefone_Click(object sender, EventArgs e)
        {

        }

        private void FrmCadastroCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtRg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private bool VerificarCampoVazio()
        {
            bool verificacao = true;

            if (txtNome.Text.Length == 0 ||
                txtCpf.Text.Length == 0 ||
                txtRg.Text.Length == 0 ||
                txtRg.Text.Length == 0 ||
                txtEndereco.Text.Length == 0 ||
                txtTelefone.Text.Length == 0 ||
                txtNumero.Text.Length == 0 ||
                txtBairro.Text.Length == 0
                ) 
            {
                SimpleMessage.Error("Ainda há campo(os) em branco", "Erro");
                verificacao = false;
            }
            return verificacao;
        }
    }
}
