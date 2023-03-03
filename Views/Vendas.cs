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
    public partial class FrmVendas : Form
    {
        public FrmVendas()
        {
            InitializeComponent();
        }

        private void bntAdicionar_Click(object sender, EventArgs e)
        {
           
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
            }
        }

        private void btnConcluirVenda_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarVenda_Click(object sender, EventArgs e)
        {

        }
    }
}
