using CantinaDoTioBill.Models;
using MessageUtils;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Data;
using CantinaDoTioBill.Controller;

namespace CantinaDoTioBill.View
{
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void bntAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new FrmCadastroProdutos())
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        Produto produto = new Produto();
                        produto.Nome = form.txtNome.Text;
                        produto.Estoque = Convert.ToInt32(form.txtEstoque.Text);
                        produto.Preco = Convert.ToDouble(form.txtValorUnitario.Text, CultureInfo.InvariantCulture);

                        ProdutoController.Adicionar(produto);
                        dtvProdutos.DataSource = ProdutoController.ListaProduto();
                        MessageBox.Show("Produto Cadastrado com Sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dtvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            try
            {
                dtvProdutos.DataSource = ProdutoController.ListaProduto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow linha = null;
                if (dtvProdutos.SelectedRows.Count > 0)
                {
                    linha = dtvProdutos.SelectedRows[0];
                    Produto produto = linha.DataBoundItem as Produto;

                    using (var form = new FrmCadastroProdutos())
                    {
                        form.Text = "Editar Produto";
                        form.txtNome.Text = produto.Nome;
                        form.txtEstoque.Text = produto.Estoque.ToString();
                        form.txtValorUnitario.Text = produto.Preco.ToString("F2");

                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            produto.Nome = form.txtNome.Text;
                            produto.Estoque = Convert.ToInt32(form.txtEstoque.Text);
                            produto.Preco = Convert.ToDouble(form.txtValorUnitario.Text, CultureInfo.InvariantCulture);

                            ProdutoController.Adicionar(produto);
                            dtvProdutos.DataSource = ProdutoController.ListaProduto();
                            MessageBox.Show("Produto atualizado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow linha = null;
                if (dtvProdutos.SelectedRows.Count > 0)
                {
                    linha = dtvProdutos.SelectedRows[0];
                    Produto produto = linha.DataBoundItem as Produto;

                    if (SimpleMessage.Confirm("Deseja realmente excluir esse produto?", "Exclusão de Produto"))
                    {
                            ProdutoController.Excluir(produto.Id);
                            dtvProdutos.DataSource = ProdutoController.ListaProduto();
                            MessageBox.Show("Produto excluído com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AtualizarProdutos(BancoContext db)
        {
            if (dtvProdutos.Rows.Count >= 0)
            {
                this.Cursor = Cursors.WaitCursor;
                dtvProdutos.DataSource = ProdutoController.ListaProduto();
                this.Cursor = Cursors.Default;
            }
        }
    }
}
