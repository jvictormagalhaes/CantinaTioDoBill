using CantinaDoTioBill.Controller;
using CantinaDoTioBill.Models;
using MessageUtils;
using Microsoft.EntityFrameworkCore;

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
            try
            {
                using (var form = new FrmCadastroUsuario())
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        Usuario usuario = new Usuario();
                        usuario.Nome = form.txtNome.Text;
                        usuario.Username = form.txtUsername.Text;
                        usuario.Senha = form.txtSenha.Text;

                        UsuarioController.Adicionar(usuario);
                        dtvUsuarios.DataSource = UsuarioController.ListaUsuario();
                        SimpleMessage.Inform("Usuário cadastrado com sucesso!", "Informação");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow linha = null;
                if (dtvUsuarios.SelectedRows.Count > 0)
                {
                    linha = dtvUsuarios.SelectedRows[0];
                    Usuario usuario = linha.DataBoundItem as Usuario;
                    if (SimpleMessage.Confirm("Deseja realmente excluir este usuário?", "Exclusão de Usuário."))
                    {
                        int idusuario = usuario.Id;
                        UsuarioController.Excluir(idusuario);
                        dtvUsuarios.DataSource = UsuarioController.ListaUsuario();

                        SimpleMessage.Inform("Usuário deletado com sucesso", "Informação");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmUsuarios_Shown(object sender, EventArgs e)
        {

        }

        private void FrmUsuarios_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                using (var db = new BancoContext())
                {
                    var usuarios = db.Usuario.Select(x => x).ToList();
                    dtvUsuarios.DataSource = usuarios;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow linha = null;
                if (dtvUsuarios.SelectedRows.Count > 0)
                {
                    linha = dtvUsuarios.SelectedRows[0];
                    Usuario usuario = linha.DataBoundItem as Usuario;

                    using (var form = new FrmCadastroUsuario())
                    {
                        form.Text = "Editar Usuário";
                        form.txtNome.Text = usuario.Nome;
                        form.txtUsername.Text = usuario.Username;
                        form.txtSenha.Text = usuario.Senha;

                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            usuario.Nome = form.txtNome.Text;
                            usuario.Username = form.txtUsername.Text;
                            usuario.Senha = form.txtSenha.Text;
                            
                            UsuarioController.Adicionar(usuario);
                            dtvUsuarios.DataSource = UsuarioController.ListaUsuario();
                            SimpleMessage.Inform("Usuário atualizado com sucesso", "Informação");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
