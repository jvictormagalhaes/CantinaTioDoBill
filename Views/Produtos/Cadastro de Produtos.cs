using CantinaDoTioBill.Models;
using System.Globalization;

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
           DialogResult = DialogResult.OK;
        }

        private void txtEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtValorUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}
