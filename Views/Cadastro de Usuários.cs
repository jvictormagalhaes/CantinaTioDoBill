using CantinaDoTioBill.Models;
using CantinaDoTioBill.View;
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
            try
            {
                using (var db = new BancoContext())
                {
                    Usuario user = new Usuario();
                    user.Nome = txtNome.Text;
                    user.Username = txtUsername.Text;
                    user.Senha = txtSenha.Text;

                    db.Usuario.Add(user);
                    db.SaveChanges();

                    MessageBox.Show("Usuário cadastrado com Sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void rbStatusInativo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmCadastroUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
