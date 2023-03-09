using CantinaDoTioBill.Models;

namespace CantinaDoTioBill.Controller
{
    public class TelaVendaController
    {
        public static BancoContext db;

        static TelaVendaController()
        {
            db = new BancoContext();
        }

        public static List<TelaVenda> ListaTelaVenda()
        {
            return db.TelaVenda.ToList();
        }

        public static void Excluir(TelaVenda produto_venda)
        {
            db.TelaVenda.Remove(produto_venda);
            db.SaveChanges();
        }
    }
}
