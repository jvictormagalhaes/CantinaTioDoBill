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

namespace CantinaDoTioBill.Views
{
    public partial class FrmClienteAuxiliar : Form
    {
        public FrmClienteAuxiliar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void FrmClienteAuxiliar_Load(object sender, EventArgs e)
        {
            try
            {
                using (var db = new BancoContext())
                {
                    var clientes = db.Cliente.Select(x => x).ToList();
                    dtvClientesAuxiliar.DataSource = clientes;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
