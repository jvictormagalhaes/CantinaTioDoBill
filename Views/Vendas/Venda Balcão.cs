using CantinaDoTioBill.Controller;
using CantinaDoTioBill.Models;
using CantinaDoTioBill.View;
using CantinaDoTioBill.Views;
using MessageUtils;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
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
        { }

        //Fecha a Tela de Venda Balcão
        private void button3_Click(object sender, EventArgs e)
        {
            LimparDataGridView();
            this.Close();
        }

        //Adiciona o Produto com as informs no DataGridView
        private void btnSelecionarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                txtQuantidadeProduto.Text = string.Empty;
                txtTotal.Text = string.Empty;

                using (var form = new FrmProdutoAuxiliar())
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        DataGridViewRow linhaProduto = form.dtvProdutos.SelectedRows[0];
                        Produto produto = linhaProduto.DataBoundItem as Produto;

                        txtIdProduto.Text = produto.Id.ToString();
                        txtNomeProduto.Text = produto.Nome;
                        txtValorUnProduto.Text = produto.Preco.ToString("F2");


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new FrmClienteAuxiliar())
                {
                    if (form.ShowDialog() == DialogResult.OK)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCadastrarNovoCliente_Click(object sender, EventArgs e)
        {
            FrmClientes novoCliente = new FrmClientes();
            novoCliente.Show();
        }

        private void btnSelecionarRota_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new FrmRotaAuxiliar())
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        DataGridViewRow linhaRota = form.dtvRotas.SelectedRows[0];
                        Rota rota = linhaRota.DataBoundItem as Rota;

                        txtNomeRota.Text = rota.NomeRota;
                        txtTaxaEntrega.Text = rota.Taxa.ToString("F2");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            try
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

                    AtualizarListaVendas();
                    var subtotal = db.TelaVenda.Sum(x => x.Total);
                    lblTotalProduto.Text = subtotal.ToString("F2");
                    lblTotalVenda.Text = subtotal.ToString("F2");
                    lblTotalProduto.Visible = true;
                    lblTotalVenda.Visible = true;

                    int quantidade = db.TelaVenda.Sum(x => x.Quantidade);
                    DaDesconto(quantidade);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Preencha todos campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Pega o valor da quantidade, caso não tenha nada, coloca o valor 0
        private void txtQuantidadeProduto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (var db = new BancoContext())
                {
                    if (txtQuantidadeProduto.Text == String.Empty)
                    {
                        txtQuantidadeProduto.Text = "";
                    }
                    else
                    {
                        int quantidade = db.TelaVenda.Sum(x => x.Quantidade);
                        double valorUn = Convert.ToDouble(txtValorUnProduto.Text);
                        txtTotal.Text = ((valorUn * Convert.ToInt16(txtQuantidadeProduto.Text)).ToString("F2"));
                        DaDesconto(quantidade);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Remove produto selecionado no DataGridView
        private void btnRemoverProduto_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow linha = null;
                if (dtvListaProdutos.SelectedRows.Count > 0)
                {
                    linha = dtvListaProdutos.SelectedRows[0];
                    TelaVenda telaVenda = linha.DataBoundItem as TelaVenda;

                    if (SimpleMessage.Confirm("Deseja retirar o produto?", "Exclusão de Produto"))
                    {
                        using (var db = new BancoContext())
                        {
                            TelaVendaController.Excluir(telaVenda);
                            AtualizarListaVendas();
                            var subtotal = db.TelaVenda.Sum(x => x.Total);
                            lblTotalProduto.Text = subtotal.ToString("F2");

                            int quantidade = db.TelaVenda.Sum(x => x.Quantidade);
                            DaDesconto(quantidade);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Finaliza a venda salvando na tabela de Vendas com Status "C" - Concluida
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (SimpleMessage.Confirm("Deseja concluir a venda?", "Concluir Venda"))
                {
                    
                    double valorDesconto = 0;
                    if (txtDesconto.Text != "0")
                        valorDesconto = Math.Abs(Convert.ToDouble(lblTotalVenda.Text) - Convert.ToDouble(lblTotalProduto.Text));

                    Venda venda = new Venda();
                    venda.Data = DateTime.Now;
                    venda.Desconto = Math.Round(Convert.ToDouble(valorDesconto),3);
                    venda.Status = "F";
                    venda.Subtotal = Convert.ToDouble(lblTotalProduto.Text);
                    venda.TaxaEntrega = Convert.ToDouble(txtTaxaEntrega.Text);
                    venda.ValorTotal = Convert.ToDouble(lblTotalVenda.Text);
                    venda.ClienteNum = Convert.ToInt32(txtIdCliente.Text);

                    VendaController.Concluir(venda);

                    LimparTela();
                    LimparDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Faz o cancelamento do Pedido
        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            if (SimpleMessage.Confirm("Deseja cancelar a venda?", "Cancelar Venda"))
            {
                LimparTela(); //Limpa a tela de vendas
            }

            LimparDataGridView();
        }

        //Atualiza o DataGridView do Produtos na tela de Vendas
        private void AtualizarListaVendas()
        {
            this.Cursor = Cursors.WaitCursor;
            dtvListaProdutos.DataSource = TelaVendaController.ListaTelaVenda();
            dtvListaProdutos.Columns[0].Visible = false;
            this.Cursor = Cursors.Default;
        }

        //Aplica o desconto no Valor Total da Venda
        private void btnAplicarDesconto_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new BancoContext())
                {
                    int quantidade = db.TelaVenda.Sum(x => x.Quantidade);
                    double subtotal = db.TelaVenda.Sum(x => x.Total);
                    double taxa = Convert.ToDouble(txtTaxaEntrega.Text);
                    lblTotalVenda.Text = valorTotalVenda(subtotal, taxa, quantidade).ToString("F2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        { }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        { }

        //retorna o valor da venda com/sem desconto
        private double valorTotalVenda(double subtotal, double taxa, int quantidade)
        {
            if (quantidade >= 5)
            {
                subtotal = subtotal + taxa;
                subtotal = subtotal - (subtotal * 0.0215);
            }
            else
            {
                subtotal += taxa;
            }

            return Math.Abs(subtotal);
        }

        //Gera o valor do desconto
        private void DaDesconto(int quantidade)
        {
            if (quantidade >= 5)
            {
                txtDesconto.Text = "2.5";
            }
            else
            {
                txtDesconto.Text = "0";
            }
        }

        //Salvar o pedido e guarda na tabela Vendas com o Status "A" - Aberta;
        private void btnSalvarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                if (SimpleMessage.Confirm("Deseja salvar a venda?", "Salvar Venda"))
                {
                    double valorDesconto = 0;
                    if (txtDesconto.Text != "0")
                        valorDesconto = Math.Abs(Convert.ToDouble(lblTotalVenda.Text) - Convert.ToDouble(lblTotalProduto.Text));

                    Venda venda = new Venda();
                    venda.Data = DateTime.Now;
                    venda.Desconto = Convert.ToDouble(txtDesconto.Text);
                    venda.Status = "A";
                    venda.Subtotal = Convert.ToDouble(lblTotalProduto.Text);
                    venda.TaxaEntrega = Convert.ToDouble(txtTaxaEntrega.Text);
                    venda.ValorTotal = Convert.ToDouble(lblTotalVenda.Text);
                    venda.ClienteNum = Convert.ToInt32(txtIdCliente.Text);

                    VendaController.Concluir(venda);
                    SimpleMessage.Inform("Venda Salva !", "Informação");
                    LimparTela();
                    LimparDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Função para limpar toda a tela da Venda Balcão
        private void LimparTela()
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
            txtDesconto.Text = String.Empty;
            txtNomeRota.Text = String.Empty;
            txtTaxaEntrega.Text = String.Empty;
            lblTotalVenda.Text = String.Empty;
            lblTotalProduto.Text = String.Empty;
            dtvListaProdutos.DataSource = null;
        }

        //Faz limpeza da tabela TelaVenda no banco
        private void LimparDataGridView()
        {
            try
            {
                using (var db = new BancoContext())
                {
                    while (db.TelaVenda.Count() != 0)
                    {
                        TelaVenda linhaexcluir = db.TelaVenda.First();
                        db.Remove(linhaexcluir);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtvListaProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtQuantidadeProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtValorUnProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) & Strings.Asc(e.KeyChar) == 24)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }

        }

        private void txtNumeroCasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
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

        private void txtNomeCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTaxaEntrega_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
