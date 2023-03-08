﻿using CantinaDoTioBill.Controller;
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

namespace CantinaDoTioBill.Views
{
    public partial class FrmProdutoAuxiliar : Form
    {
        public FrmProdutoAuxiliar()
        {
            InitializeComponent();
        }

        private void ProdutoAuxiliar_Load(object sender, EventArgs e)
        {
            try
            {
                using (var db = new BancoContext())
                {
                    var produtos = db.Produto.Select(x => x).ToList();
                    dtvProdutos.DataSource = produtos;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelecionarProduto_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
