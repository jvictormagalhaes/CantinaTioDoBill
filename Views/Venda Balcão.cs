using CantinaDoTioBill.Models;
using CantinaDoTioBill.View;
using CantinaDoTioBill.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
