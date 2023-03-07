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
                    if(form.ShowDialog() == DialogResult.OK)
                    {
                        using(var db = new BancoContext())
                        {
                            Rota rotas = new Rota();
                            rotas.NomeRota = form.txtNomeRota.Text;
                            rotas.Taxa = Convert.ToDouble(form.txtTaxa.Text, CultureInfo.InvariantCulture);

                            db.Rota.Add(rotas);
                            db.SaveChanges();

                            SimpleMessage.Inform("Rota adicionada!", "Informação");
                            AtualizarRotas(db);
                        }
                    }
                }
            }
            catch(Exception ex)
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
                                using (var db = new BancoContext())
                                {
                                    rota.NomeRota = form.txtNomeRota.Text;
                                    rota.Taxa = Convert.ToDouble(form.txtTaxa.Text.ToString(CultureInfo.InvariantCulture));
                                    db.Rota.Attach(rota);
                                    db.Entry(rota).State = EntityState.Modified;
                                    db.SaveChanges();

                                    SimpleMessage.Inform("Rota atualizada!", "Informação");
                                    AtualizarRotas(db);
                                }
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
                            using (var db = new BancoContext())
                            {
                                db.Rota.Attach(rota);
                                db.Entry(rota).State = EntityState.Deleted;
                                db.SaveChanges();

                                SimpleMessage.Inform("Rota excluída!", "Informação");
                                AtualizarRotas(db);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AtualizarRotas(BancoContext db)
        {
            if(dtvRotas.Rows.Count >= 0)
            {
                this.Cursor = Cursors.WaitCursor;
                var atualizar = db.Rota.Select(x => x).ToList();
                dtvRotas.DataSource = atualizar;
                this.Cursor = Cursors.Default;
            }
        }

        private void FrmRotas_Load(object sender, EventArgs e)
        {
            try
            {
                using (var db = new BancoContext())
                {
                    var rotas = db.Rota.Select(x => x).ToList();
                    dtvRotas.DataSource = rotas;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
