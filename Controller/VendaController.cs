using CantinaDoTioBill.Models;
using Microsoft.EntityFrameworkCore;

namespace CantinaDoTioBill.Controller
{
    public class VendaController
    {
        public static BancoContext db;

        static VendaController()
        {
            db = new BancoContext();
        }

        public static void Concluir(Venda venda)
        {
            db.Vendas.Add(venda);
            db.Entry(venda).State = venda.Id > 0 ? EntityState.Modified :
                EntityState.Added;
            db.SaveChanges();
        }

        public static List<Venda> ListaVenda()
        {
            return db.Vendas.ToList();
        }
    }
}
