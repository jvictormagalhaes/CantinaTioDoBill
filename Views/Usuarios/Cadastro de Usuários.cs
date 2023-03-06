using CantinaDoTioBill.Models;
using CantinaDoTioBill.View;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace CantinaDoTioBill
{
    public partial class FrmCadastroUsuario : Form
    {
        public FrmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void FrmCadastroUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Strings.Asc(e.KeyChar) >= 48 & Strings.Asc(e.KeyChar) <= 57))
            {
                e.Handled = true;
                e = null;
            }
        }
    }
}
