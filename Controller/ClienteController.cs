using Microsoft.EntityFrameworkCore;
using CantinaDoTioBill.Models;

namespace CantinaDoTioBill.Controller
{
    public static class ClienteController
    {
        public static BancoContext db;

        static ClienteController()
        {
            db = new BancoContext();
        }

        public static void Adicionar(Cliente cliente)
        {
            db.Cliente.Add(cliente);
            db.Entry(cliente).State = cliente.Id > 0 ? EntityState.Modified :
                EntityState.Added;
            db.SaveChanges();
        }

        public static Cliente GetCliente(int Id)
        {
            return db.Cliente.Where(x => x.Id == Id).FirstOrDefault();
        }

        public static List<Cliente> ListaClientes()
        {
            return db.Cliente.ToList();
        }

        public static void Excluir(int Id)
        {
            Cliente cliente = GetCliente(Id);
            db.Cliente.Remove(cliente);
            db.SaveChanges();
        }

    }
}
