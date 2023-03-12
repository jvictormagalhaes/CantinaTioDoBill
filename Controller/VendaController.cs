using CantinaDoTioBill.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace CantinaDoTioBill.Controller
{
    public class VendaController
    {
        public static BancoContext db;

        static VendaController()
        {
            db = new BancoContext();
        }

        public static void ConcluirPedido(Venda venda)
        {
            db.Vendas.Attach(venda);
            db.Entry(venda).State = venda.Id > 0 ? EntityState.Modified :
                EntityState.Added;
            db.SaveChanges();
        }

        public static List<Venda> ListaVenda()
        {
            return db.Vendas.ToList();
        }

        public BindingSource binding;
        
        public BindingSource bindingSource()
        {
            binding = new BindingSource();
            binding.DataSource = ListaVenda();

            return binding;
        }
    }  
}
