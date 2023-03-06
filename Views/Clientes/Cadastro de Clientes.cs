using CantinaDoTioBill.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Xsl;

namespace CantinaDoTioBill
{
    public partial class FrmCadastroCliente : Form
    {
        public FrmCadastroCliente()
        {
            InitializeComponent();
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void FrmCadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void bntSalvar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnSalvar_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void lvlNumero_Click(object sender, EventArgs e)
        {

        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBairro_Click(object sender, EventArgs e)
        {

        }

        private void txtRg_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRg_Click(object sender, EventArgs e)
        {

        }

        private void lblCpf_Click(object sender, EventArgs e)
        {

        }

        private void lblEndereco_Click(object sender, EventArgs e)
        {

        }

        private void lblTelefone_Click(object sender, EventArgs e)
        {

        }

        private void FrmCadastroCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtRg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Strings.Asc(e.KeyChar) >= 48 & Strings.Asc(e.KeyChar) <= 57))
            {
                e.Handled = true;
                e = null;
            }
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
