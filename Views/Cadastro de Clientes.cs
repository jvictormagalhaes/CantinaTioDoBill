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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void bntSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new BancoContext())
                {
                    Cliente cliente = new Cliente();
                    cliente.Nome = txtNome.Text;
                    cliente.Cpf = txtCpf.Text;
                    cliente.Endereco = txtEndereco.Text;
                    cliente.Rg = txtRg.Text;
                    cliente.Telefone = txtTelefone.Text;
                    cliente.Bairro = txtBairro.Text;
                    cliente.Numero = txtNumero.Text;
                    db.Cliente.Add(cliente);
                    db.SaveChanges();

                    MessageBox.Show("Cliente Cadastrado com Sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
