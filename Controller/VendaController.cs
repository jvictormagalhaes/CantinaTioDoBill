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

        public static void Adicionar(Venda venda)
        {
            db.Vendas.Add(venda);
            db.Entry(venda).State = venda.Id > 0 ? EntityState.Modified :
                EntityState.Added;
            db.SaveChanges();
        }

        public static Venda GetVenda(int Id)
        {
            return db.Vendas.Where(x => x.Id == Id).FirstOrDefault();
        }

        public static List<Venda> ListaVenda()
        {
            return db.Vendas.ToList();
        }

        public static void Excluir(int Id)
        {
            Venda venda = GetVenda(Id);
            db.Vendas.Remove(venda);
            db.SaveChanges();
        }
    }
}
