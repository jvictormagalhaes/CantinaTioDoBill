using CantinaDoTioBill.Controller;
using CantinaDoTioBill.Models;
using MessageUtils;
using Microsoft.EntityFrameworkCore;
using System.Data;


namespace CantinaDoTioBill.View
{
    public partial class FrmVendas : Form
    {
        public FrmVendas()
        {
            InitializeComponent();
        }

        private void bntAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new BancoContext())
                {
                    FrmTelaVenda telaVenda = new FrmTelaVenda();
                    telaVenda.Show();

                    AtualizarVendas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            try
            {
                using (var db = new BancoContext())
                {
                    var vendas = db.Vendas.Select(x => x).ToList();
                    dtvVendas.DataSource = vendas;
                    var totalVendasCanceladas = db.Vendas.Where(x => x.Status == "C").Sum(x => x.ValorTotal);
                    var totalVendasFinalizadas = db.Vendas.Where(x => x.Status == "F").Sum(x => x.ValorTotal);
                    lblTotalVendasFinalizadas.Text = totalVendasFinalizadas.ToString("F2");
                    lblTotalDeVendasCanceladas.Text = totalVendasCanceladas.ToString("F2");
                    lblCifraoF.Visible = true;
                    lblCifraoC.Visible = true;
                    lblTotalVendasFinalizadas.Visible = true;
                    lblTotalDeVendasCanceladas.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnConcluirVenda_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow linha = null;
                if (dtvVendas.SelectedRows.Count > 0)
                {
                    linha = dtvVendas.SelectedRows[0];
                    Venda venda = linha.DataBoundItem as Venda;
                    if (SimpleMessage.Confirm("Deseja finalizar a venda?", "Concluir Venda."))
                    {
                        if (venda.Status == "A")
                        {
                            using (var db = new BancoContext())
                            {
                                venda.Status = "F";
                                db.Vendas.Attach(venda);
                                db.Entry(venda).State = EntityState.Modified;
                                db.SaveChanges();
                                SimpleMessage.Inform("Venda concluída com sucesso", "Informação");
                                dtvVendas.DataSource = VendaController.ListaVenda();
                            }
                        }
                        else
                        {
                            if (venda.Status == "C")
                            {
                                SimpleMessage.Inform("Não é possivel finalizar uma venda cancelada!");
                            }
                            else
                            {
                                SimpleMessage.Inform("Venda já finalizada !");
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelarVenda_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow linha = null;
                if (dtvVendas.SelectedRows.Count > 0)
                {
                    linha = dtvVendas.SelectedRows[0];
                    Venda venda = linha.DataBoundItem as Venda;
                    if (SimpleMessage.Confirm("Deseja realmente cancelar a venda?", "Cancelamento"))
                    {
                        if (venda.Status == "A" || venda.Status == "F")
                        {
                            venda.Status = "C";
                            VendaController.ConcluirPedido(venda);
                            SimpleMessage.Inform("Venda cancelada com sucesso", "Informação");
                            dtvVendas.DataSource = VendaController.ListaVenda();
                            CalculaTotais();
                        }
                        else
                        {
                            SimpleMessage.Inform("Venda já cancelada");
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void AtualizarVendas()
        {
            try
            {
                if (dtvVendas.Rows.Count >= 0)
                {
                    this.Cursor = Cursors.WaitCursor;
                    dtvVendas.DataSource = VendaController.ListaVenda();
                    CalculaTotais();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Faz o calculo dos labels
        private void CalculaTotais()
        {
            try
            {
                using (var db = new BancoContext())
                {
                    var vendas = db.Vendas.Select(x => x).ToList();
                    dtvVendas.DataSource = vendas;
                    var totalVendasCanceladas = db.Vendas.Where(x => x.Status == "C").Sum(x => x.ValorTotal);
                    var totalVendasFinalizadas = db.Vendas.Where(x => x.Status == "F").Sum(x => x.ValorTotal);
                    lblTotalVendasFinalizadas.Text = totalVendasFinalizadas.ToString("F2");
                    lblTotalDeVendasCanceladas.Text = totalVendasCanceladas.ToString("F2");
                    lblCifraoF.Visible = true;
                    lblCifraoC.Visible = true;
                    lblTotalVendasFinalizadas.Visible = true;
                    lblTotalDeVendasCanceladas.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
