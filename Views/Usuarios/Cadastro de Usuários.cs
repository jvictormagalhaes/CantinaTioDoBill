using CantinaDoTioBill.Models;
using CantinaDoTioBill.View;
using MessageUtils;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
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
           if(VerificarCampoVazio() == true)
           {
                if (VerificarCampoVazio() == true) {
                    DialogResult = DialogResult.OK;
                }
           }
        }

        private void FrmCadastroUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
        }

        private bool VerificarCampoVazio()
        {
            bool verificacao = true;

            if(txtNome.Text.Length == 0 ||
               txtUsername.Text.Length == 0 ||
               txtSenha.Text.Length == 0) {
            
                SimpleMessage.Error("Ainda há campo(os) em branco", " Erro");
                verificacao = false;
            }
            return verificacao;
        }
    }
}
