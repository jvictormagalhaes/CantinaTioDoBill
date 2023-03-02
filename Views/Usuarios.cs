using CantinaDoTioBill.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CantinaDoTioBill.View
{
    public partial class FrmUsuarios : Form
    {

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void bntAdicionar_Click(object sender, EventArgs e)
        {
            FrmCadastroUsuario cadastroUsuario = new FrmCadastroUsuario();
            cadastroUsuario.Show();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void lvUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void FrmUsuarios_Shown(object sender, EventArgs e)
        {
            
        }

        private void FrmUsuarios_VisibleChanged(object sender, EventArgs e)
        {
          
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            using (var db = new BancoContext())
            {
                var usuarios = db.Usuario.Select(x => x).ToList();
                dtvUsuarios.DataSource = usuarios;
            }
        }

        private void dtvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
