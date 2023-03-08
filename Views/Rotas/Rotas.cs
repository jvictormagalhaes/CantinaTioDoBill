using CantinaDoTioBill.Controller;
using CantinaDoTioBill.Models;
using MessageUtils;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Globalization;

namespace CantinaDoTioBill.Views
{
    public partial class FrmRotas : Form
    {
        public FrmRotas()
        {
            InitializeComponent();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new FrmCadastroRotas())
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {

                        Rota rotas = new Rota();
                        rotas.NomeRota = form.txtNomeRota.Text;
                        rotas.Taxa = Convert.ToDouble(form.txtTaxa.Text, CultureInfo.InvariantCulture);

                        RotaController.Adicionar(rotas);
                        dtvRotas.DataSource = RotaController.ListaRotas();
                        SimpleMessage.Inform("Rota adicionada!", "Informação");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow linha = null;
                if (dtvRotas.SelectedRows.Count > 0)
                {
                    linha = dtvRotas.SelectedRows[0];
                    Rota rota = linha.DataBoundItem as Rota;

                    using (var form = new FrmCadastroRotas())
                    {
                        form.Text = "Editar Rota";
                        form.txtNomeRota.Text = rota.NomeRota;
                        form.txtTaxa.Text = rota.Taxa.ToString("F2");

                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            try
                            {
                                rota.NomeRota = form.txtNomeRota.Text;
                                rota.Taxa = Convert.ToDouble(form.txtTaxa.Text.ToString(CultureInfo.InvariantCulture));
                                RotaController.Adicionar(rota);
                                dtvRotas.DataSource = RotaController.ListaRotas();
                                SimpleMessage.Inform("Rota atualizada!", "Informação");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow linha = null;
                if (dtvRotas.SelectedRows.Count > 0)
                {
                    linha = dtvRotas.SelectedRows[0];
                    Rota rota = linha.DataBoundItem as Rota;

                    if (SimpleMessage.Confirm("Deseja realmente excluir esta rota?", "Exclusão da rota"))
                    {
                        try
                        {
                            UsuarioController.Excluir(rota.Id);
                            dtvRotas.DataSource = RotaController.ListaRotas();
                            SimpleMessage.Inform("Rota excluída!", "Informação");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmRotas_Load(object sender, EventArgs e)
        {
            try
            {
                dtvRotas.DataSource = RotaController.ListaRotas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
