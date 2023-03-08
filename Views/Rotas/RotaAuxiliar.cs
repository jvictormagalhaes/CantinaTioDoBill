using CantinaDoTioBill.Controller;
using CantinaDoTioBill.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CantinaDoTioBill.Views
{
    public partial class FrmRotaAuxiliar : Form
    {
        public FrmRotaAuxiliar()
        {
            InitializeComponent();
        }

        private void FrmRotaAuxiliar_Load(object sender, EventArgs e)
        {
            try
            {
                using (var db = new BancoContext())
                {
                    var rotas = db.Rota.Select(x => x).ToList();
                    dtvRotas.DataSource = rotas;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelecionarRota_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
