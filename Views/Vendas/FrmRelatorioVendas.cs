using CantinaDoTioBill.Controller;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CantinaDoTioBill.Views.Vendas
{
    public partial class FrmRelatorioVendas : Form
    {
        public FrmRelatorioVendas()
        {
            InitializeComponent();

            reportViewer1.LocalReport.ReportEmbeddedResource = "CantinaDoTioBill.Views.Vendas.RelatorioVendas.rdlc";
            reportViewer1.RefreshReport();
            
        }

        private void FrmRelatorioVendas_Load(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
