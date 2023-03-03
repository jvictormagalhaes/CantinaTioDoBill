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
            if(txtUser.Text == "admin" && txtSenha.Text == "admin")
            {
                MessageBox.Show("Acesso Liberado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                FrmHome hm = new FrmHome();
                hm.ShowDialog();

            }
            else
            {
              ConsultaSenha();
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
                    var user = db.Usuario.Select(x => x).ToList();
                    var senha = db.Usuario.Select(s => s).ToList();

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
