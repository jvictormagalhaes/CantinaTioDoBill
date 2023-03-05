using CantinaDoTioBill.Models;
using MessageUtils;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

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
            using (var db = new BancoContext())
            {
                FrmTelaVenda telaVenda = new FrmTelaVenda();
                telaVenda.Show();

                AtualizarVendas();
            }
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            using (var db = new BancoContext())
            {
                var vendas = db.Vendas.Select(x => x).ToList();
                dtvVendas.DataSource = vendas;
                var totalVendas = db.Vendas.Sum(x => x.ValorTotal);
                lblTotalVendas.Text = totalVendas.ToString();
                lblCifrao.Visible = true;
                lblTotalVendas.Visible = true;
            }
        }

        private void btnConcluirVenda_Click(object sender, EventArgs e)
        {
            DataGridViewRow linha = null;
            if (dtvVendas.SelectedRows.Count > 0)
            {
                linha = dtvVendas.SelectedRows[0];
                Venda venda = linha.DataBoundItem as Venda;
                if (SimpleMessage.Confirm("Deseja finalizar a venda?", "Concluir Venda."))
                {
                    using (var db = new BancoContext())
                    {
                        venda.Status = "F";
                        db.Attach(venda);
                        db.Entry(venda).State = EntityState.Modified;
                        db.SaveChanges();

                        SimpleMessage.Inform("Venda concluída com sucesso", "Informação");
                        AtualizarVendas();
                    }

                }

            }
        }

        private void btnCancelarVenda_Click(object sender, EventArgs e)
        {
            DataGridViewRow linha = null;
            if (dtvVendas.SelectedRows.Count > 0)
            {
                linha = dtvVendas.SelectedRows[0];
                Venda venda = linha.DataBoundItem as Venda;
                if (SimpleMessage.Confirm("Deseja realmente cancelar a venda?", "Cancelamento"))
                {
                    using (var db = new BancoContext())
                    {
                        venda.Status = "C";
                        db.Attach(venda);
                        db.Entry(venda).State = EntityState.Modified;
                        db.SaveChanges();

                        SimpleMessage.Inform("Venda cancelada com sucesso", "Informação");
                        AtualizarVendas();
                    }

                }

            }
        }

        public void AtualizarVendas()
        {
            using (var db = new BancoContext())
            {
                if (dtvVendas.Rows.Count > 0)
                {
                    this.Cursor = Cursors.WaitCursor;
                    var atualizar = db.Vendas.Select(x => x).ToList();
                    dtvVendas.DataSource = atualizar;
                    this.Cursor = Cursors.Default;
                }
            }
        }
    }
}
