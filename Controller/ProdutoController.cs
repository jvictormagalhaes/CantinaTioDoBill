using CantinaDoTioBill.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantinaDoTioBill.Controller
{
    public class ProdutoController
    {
        public static BancoContext db;

        static ProdutoController()
        {
            db = new BancoContext();
        }

        public static void Adicionar(Produto produto)
        {
            db.Produto.Add(produto);
            db.Entry(produto).State = produto.Id > 0 ? EntityState.Modified :
                EntityState.Added;
            db.SaveChanges();
        }

        public static Produto GetProduto(int Id)
        {
            return db.Produto.Where(x => x.Id == Id).FirstOrDefault();
        }

        public static List<Produto> ListaProduto()
        {
            return db.Produto.ToList();
        }

        public static void Excluir(int Id)
        {
            Produto produto = GetProduto(Id);
            db.Produto.Remove(produto);
            db.SaveChanges();
        }
    }
}
