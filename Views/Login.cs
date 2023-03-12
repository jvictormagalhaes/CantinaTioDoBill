using CantinaDoTioBill.Controller;
using CantinaDoTioBill.Models;
using MessageUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CantinaDoTioBill
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string senha = txtSenha.Text;

            if(usuario == "admin" && txtSenha.Text == "admin")
            {
                SimpleMessage.Inform("Acesso Liberado ! ", "Acesso");
                FrmHome form = new FrmHome();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                if (ConsultaSenha())
                {
                    SimpleMessage.Inform("Acesso Liberado ! ", "Acesso"); 
                    FrmHome form = new FrmHome();
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                }
                else
                {
                    SimpleMessage.Error("Usuário ou senha incorretos !", "Erro");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            DialogResult Sair = MessageBox.Show("Deseja realmente sair ?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Sair == DialogResult.Yes)
            {
                Application.Exit();
            }
            else { };
        }

        public bool ConsultaSenha()
        {
            bool entrar = false;
            try
            {
                using (var db = new BancoContext())
                {
                   var Usuario = db.Usuario.FirstOrDefault(x => x.Username == txtUser.Text && x.Senha == txtSenha.Text);
                   if(Usuario != null)
                        entrar = true;
                   else
                        entrar = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return entrar;
        }
    }
}
