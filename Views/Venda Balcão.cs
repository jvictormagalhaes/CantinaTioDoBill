using CantinaDoTioBill.Models;
using CantinaDoTioBill.View;
using CantinaDoTioBill.Views;
using MessageUtils;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace CantinaDoTioBill
{
    public partial class FrmTelaVenda : Form
    {
        public FrmTelaVenda()
        {
            InitializeComponent();
        }

        private void FrmTelaVenda_Load(object sender, EventArgs e)
        {
            using(var db = new BancoContext())
            {
                var listaProdutos = db.Vendas.Select(x => x).ToList();
                dtvListaProdutos.DataSource = listaProdutos;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelecionarProduto_Click(object sender, EventArgs e)
        {
            using (var form = new FrmProdutoAuxiliar())
            {
                if(form.ShowDialog() == DialogResult.OK)
                {
                    DataGridViewRow linhaProduto = form.dtvProdutos.SelectedRows[0];
                    Produto produto = linhaProduto.DataBoundItem as Produto;

                    txtIdProduto.Text = produto.Id.ToString();
                    txtNomeProduto.Text = produto.Nome;
                    txtValorUnProduto.Text = produto.Preco.ToString();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using(var form = new FrmClienteAuxiliar())
            {
                if(form.ShowDialog() == DialogResult.OK)
                {
                    DataGridViewRow linhaCliente = form.dtvClientesAuxiliar.SelectedRows[0];
                    Cliente cliente = linhaCliente.DataBoundItem as Cliente;

                    txtIdCliente.Text = cliente.Id.ToString();
                    txtNomeCliente.Text = cliente.Nome;
                    txtEndereco.Text = cliente.Endereco;
                    txtNumeroCasa.Text = cliente.Numero;
                    txtBairro.Text = cliente.Bairro;
                    txtTelefone.Text = cliente.Telefone;
                }
            }


        }

        private void btnCadastrarNovoCliente_Click(object sender, EventArgs e)
        {
            FrmClientes novoCliente = new FrmClientes();
            novoCliente.Show();
        }

        private void btnSelecionarRota_Click(object sender, EventArgs e)
        {
            using (var form = new FrmRotaAuxiliar())
            {
                if(form.ShowDialog() == DialogResult.OK)
                {
                    DataGridViewRow linhaRota = form.dtvRotas.SelectedRows[0];
                    Rota rota = linhaRota.DataBoundItem as Rota;

                    txtNomeRota.Text = rota.NomeRota;
                    txtTaxaEntrega.Text = rota.Taxa.ToString();
                }
            }
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            using (var db = new BancoContext())
            {
                var telaVenda = new TelaVenda();
                telaVenda.NomeItem = txtNomeProduto.Text;
                telaVenda.IdProduto = Convert.ToInt32(txtIdProduto.Text);
                telaVenda.ValorUnitario = Convert.ToDouble(txtValorUnProduto.Text);
                telaVenda.Quantidade = Convert.ToInt32(txtQuantidadeProduto.Text);
                telaVenda.Total = Convert.ToDouble(txtTotal.Text);

                db.TelaVenda.Add(telaVenda);
                db.SaveChanges();

                AtualizarListaVendas(db);
            }
        }

        private void txtQuantidadeProduto_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantidadeProduto.Text == String.Empty)
            {
                txtQuantidadeProduto.Text = "";
            }
            else
            {
                double desconto = 2.5;
                double valorUn = Convert.ToDouble(txtValorUnProduto.Text);
                int quantidade = Convert.ToInt32(txtQuantidadeProduto.Text);
                txtTotal.Text = ((valorUn * Convert.ToInt16(txtQuantidadeProduto.Text)).ToString("F2")); 
                double total = quantidade;
                if (quantidade >= 5)
                    txtDesconto.Text = desconto.ToString();
                else
                    txtDesconto.Text = "0";
            }
        }

        private void btnRemoverProduto_Click(object sender, EventArgs e)
        {
            DataGridViewRow linha = null;
            if(dtvListaProdutos.SelectedRows.Count > 0)
            {
                linha = dtvListaProdutos.SelectedRows[0];
                TelaVenda telaVenda = linha.DataBoundItem as TelaVenda;
                
                if(SimpleMessage.Confirm("Deseja retirar o produto?","Exclusão de Produto")){
                    using(var db = new BancoContext())
                    {
                        db.TelaVenda.Attach(telaVenda);
                        db.Entry(telaVenda).State = EntityState.Deleted;
                        db.SaveChanges();

                        AtualizarListaVendas(db);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            if(SimpleMessage.Confirm("Deseja realmente cancelar a venda?", "Cancelamento"))
            {
                txtIdCliente.Text = String.Empty;
                txtNomeCliente.Text = String.Empty;
                txtEndereco.Text = String.Empty;
                txtNumeroCasa.Text = String.Empty;
                txtBairro.Text = String.Empty;
                txtTelefone.Text = String.Empty;
                txtIdProduto.Text = String.Empty;
                txtNomeProduto.Text = String.Empty;
                txtValorUnProduto.Text = String.Empty;
                txtQuantidadeProduto.Text = String.Empty;
                txtTotal.Text = String.Empty;
                dtvListaProdutos.DataSource = null;
            }
        }
        private void AtualizarListaVendas(BancoContext db)
        {
            this.Cursor = Cursors.WaitCursor;
            var atualizar = db.TelaVenda.Select(x => x).ToList();
            dtvListaProdutos.DataSource = atualizar;
            this.Cursor = Cursors.Default;
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }
    }
}
