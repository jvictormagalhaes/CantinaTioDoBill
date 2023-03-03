using CantinaDoTioBill.Models;

namespace CantinaDoTioBill.View
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            using(var db = new BancoContext())
            {
                var clientes = db.Cliente.Select(x => x).ToList();
                dtvClientes.DataSource = clientes;
            }
        }

        private void bntAdicionar_Click(object sender, EventArgs e)
        {
            FrmCadastroCliente cadastroCliente = new FrmCadastroCliente();
            cadastroCliente.Show();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            using(var form = new FrmCadastroCliente())
            {
                form.Text = "Atualizar cliente";
                using (var db = new BancoContext())
                {

                }
            }
      
        }

        private void dtvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var db = new BancoContext())
            {
               

            }
        }
    }
}
