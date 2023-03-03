using CantinaDoTioBill.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            FrmCadastroProdutos cadastroProdutos = new FrmCadastroProdutos();
            cadastroProdutos.Show();
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
            using (var db = new BancoContext())
            {
                var produtos = db.Produto.Select(x => x).ToList();
                dtvProdutos.DataSource = produtos;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
