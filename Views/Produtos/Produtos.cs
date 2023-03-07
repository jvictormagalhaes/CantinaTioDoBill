using CantinaDoTioBill.Models;
using MessageUtils;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Data;

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
                        using (var db = new BancoContext())
                        {
                            Produto produto = new Produto();
                            produto.Nome = form.txtNome.Text;
                            produto.Estoque = Convert.ToInt32(form.txtEstoque.Text);
                            produto.Preco = Convert.ToDouble(form.txtValorUnitario.Text, CultureInfo.InvariantCulture);
                            db.Produto.Add(produto);
                            db.SaveChanges();
                            AtualizarProdutos(db);

                            MessageBox.Show("Cliente Cadastrado com Sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
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
                using (var db = new BancoContext())
                {
                    var produtos = db.Produto.Select(x => x).ToList();
                    dtvProdutos.DataSource = produtos;
                }
            }
            catch(Exception ex)
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
                            using (var db = new BancoContext())
                            {
                                produto.Nome = form.txtNome.Text;
                                produto.Estoque = Convert.ToInt32(form.txtEstoque.Text);
                                produto.Preco = Convert.ToDouble(form.txtValorUnitario.Text, CultureInfo.InvariantCulture);


                                db.Produto.Attach(produto);
                                db.Entry(produto).State = EntityState.Modified;
                                db.SaveChanges();

                                MessageBox.Show("Produto atualizado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                AtualizarProdutos(db);

                            }
                        }
                    }
                }
            }
            catch(Exception ex)
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
                        using (var db = new BancoContext())
                        {
                            db.Produto.Attach(produto);
                            db.Entry(produto).State = EntityState.Deleted;
                            db.SaveChanges();

                            MessageBox.Show("Produto excluído com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AtualizarProdutos(db);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AtualizarProdutos(BancoContext db)
        {
            if (dtvProdutos.Rows.Count >= 0)
            {
                this.Cursor = Cursors.WaitCursor;
                var atualizar = db.Produto.Select(x => x).ToList();
                dtvProdutos.DataSource = atualizar;
                this.Cursor = Cursors.Default;
            }
        }
    }
}
