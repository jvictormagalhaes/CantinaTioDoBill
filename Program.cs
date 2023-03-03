using CantinaDoTioBill.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CantinaDoTioBill
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

          //  FrmLogin login = new FrmLogin();
           // if (login.ShowDialog() == DialogResult.OK)
          //  {
                Application.Run(new FrmProdutos());
           // }
        }
    }
}
