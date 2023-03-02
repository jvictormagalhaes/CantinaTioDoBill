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
            cadastroProdutos.ShowDialog();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
