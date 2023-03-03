using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CantinaDoTioBill.Views
{
    public partial class FrmRotas : Form
    {
        public FrmRotas()
        {
            InitializeComponent();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntAdicionar_Click(object sender, EventArgs e)
        {
            FrmCadastroRotas cadRotas = new FrmCadastroRotas();
            cadRotas.Show();
        }
    }
}
