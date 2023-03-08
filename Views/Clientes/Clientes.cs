﻿using CantinaDoTioBill.Controller;
using CantinaDoTioBill.Models;
using MessageUtils;
using Microsoft.EntityFrameworkCore;

namespace CantinaDoTioBill.View
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            try
            {
                using (var db = new BancoContext())
                {
                    var clientes = db.Cliente.Select(x => x).ToList();
                    dtvClientes.DataSource = clientes;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bntAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new FrmCadastroCliente())
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {

                        Cliente cliente = new Cliente();
                        cliente.Nome = form.txtNome.Text;
                        cliente.Cpf = form.txtCpf.Text;
                        cliente.Endereco = form.txtEndereco.Text;
                        cliente.Rg = form.txtRg.Text;
                        cliente.Telefone = form.txtTelefone.Text;
                        cliente.Bairro = form.txtBairro.Text;
                        cliente.Numero = form.txtNumero.Text;

                        ClienteController.Adicionar(cliente);
                        dtvClientes.DataSource = ClienteController.ListaClientes();
                        MessageBox.Show("Cliente Cadastrado com Sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow linha = null;
                if (dtvClientes.SelectedRows.Count > 0)
                {
                    linha = dtvClientes.SelectedRows[0];
                    Cliente cliente = linha.DataBoundItem as Cliente;

                    using (var form = new FrmCadastroCliente())
                    {
                        form.Text = "Editar Cliente";
                        form.txtNome.Text = cliente.Nome;
                        form.txtCpf.Text = cliente.Cpf;
                        form.txtRg.Text = cliente.Rg;
                        form.txtEndereco.Text = cliente.Endereco;
                        form.txtTelefone.Text = cliente.Telefone;
                        form.txtBairro.Text = cliente.Bairro;
                        form.txtNumero.Text = cliente.Numero;

                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            using (var db = new BancoContext())
                            {
                                cliente.Nome = form.txtNome.Text;
                                cliente.Cpf = form.txtCpf.Text;
                                cliente.Endereco = form.txtEndereco.Text;
                                cliente.Rg = form.txtRg.Text;
                                cliente.Telefone = form.txtTelefone.Text;
                                cliente.Bairro = form.txtBairro.Text;
                                cliente.Numero = form.txtNumero.Text;

                                db.Cliente.Attach(cliente);
                                db.Entry(cliente).State = EntityState.Modified;
                                db.SaveChanges();

                                MessageBox.Show("Cliente atualizado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                AtualizarCliente(db);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dtvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AtualizarCliente(BancoContext db)
        {
            if (dtvClientes.Rows.Count >= 0)
            {
                this.Cursor = Cursors.WaitCursor;
                var atualizar = db.Cliente.Select(x => x).ToList();
                dtvClientes.DataSource = atualizar;
                this.Cursor = Cursors.Default;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow linha = null;
                if (dtvClientes.SelectedRows.Count > 0)
                {
                    linha = dtvClientes.SelectedRows[0];
                    Cliente cliente = linha.DataBoundItem as Cliente;
                    if (SimpleMessage.Confirm("Deseja realmente excluir o cliente?", "Exclusão de Produto"))
                    {
                        using (var db = new BancoContext())
                        {
                            db.Cliente.Attach(cliente);
                            db.Entry(cliente).State = EntityState.Deleted;
                            db.SaveChanges();

                            MessageBox.Show("Cliente excluído com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AtualizarCliente(db);
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
