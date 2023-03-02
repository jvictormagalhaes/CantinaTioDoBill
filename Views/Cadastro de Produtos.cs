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
            try
            {
                using (var db = new BancoContext())
                {
                    Produto produto = new Produto();
                    produto.Nome = txtNome.Text;
                    produto.Estoque = Convert.ToInt32(txtEstoque.Text);
                    produto.Preco = Convert.ToDouble(txtPreco.Text);

                    db.Produto.Add(produto);
                    db.SaveChanges();

                    MessageBox.Show("Produto cadastrado com Sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
