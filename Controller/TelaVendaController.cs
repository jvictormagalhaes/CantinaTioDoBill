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

        public static List<Venda> ListaVenda()
        {
            return db.Vendas.ToList();
        }
    }
}
