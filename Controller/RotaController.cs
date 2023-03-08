using CantinaDoTioBill.Models;
using Microsoft.EntityFrameworkCore;

namespace CantinaDoTioBill.Controller
{
    public class RotaController
    {
        public static BancoContext db;

        static RotaController()
        {
            db = new BancoContext();
        }

        public static void Adicionar(Rota rota)
        {
            db.Rota.Add(rota);
            db.Entry(rota).State = rota.Id > 0 ? EntityState.Modified :
                EntityState.Added;
            db.SaveChanges();
        }

        public static Rota GetRota(int Id)
        {
            return db.Rota.Where(x => x.Id == Id).FirstOrDefault();
        }

        public static List<Cliente> ListaClientes()
        {
            return db.Cliente.ToList();
        }

        public static void Excluir(int Id)
        {
            Rota rota = GetRota(Id);
            db.Rota.Remove(rota);
            db.SaveChanges();
        }
    }
}
