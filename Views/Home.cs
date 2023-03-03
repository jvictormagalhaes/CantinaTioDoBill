using CantinaDoTioBill.View;
using CantinaDoTioBill.Views;

namespace CantinaDoTioBill
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult Sair = MessageBox.Show("Deseja realmente sair ?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Sair == DialogResult.Yes)
            {
                Application.Exit();
            }
            else { };
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios usuarios = new FrmUsuarios();
            usuarios.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmClientes clientes = new FrmClientes();
            clientes.Show();

        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdutos produtos = new FrmProdutos();
            produtos.Show();
        }

        private void vendaBalcãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTelaVenda vb = new FrmTelaVenda();
            vb.ShowDialog();
        }

        private void relatórioDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vendasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmVendas vendas = new FrmVendas();
            vendas.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmProdutos produtos = new FrmProdutos();
            produtos.ShowDialog();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuarios usuarios = new FrmUsuarios();
            usuarios.Show();
        }

        private void btnTelaVenda_Click(object sender, EventArgs e)
        {
            FrmTelaVenda telavendas = new FrmTelaVenda();
            telavendas.ShowDialog();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FrmClientes clientes = new FrmClientes();
            clientes.Show();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            FrmVendas vendas = new FrmVendas();
            vendas.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void rotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRotas rotas = new FrmRotas();
            rotas.Show();
        }
    }
}
