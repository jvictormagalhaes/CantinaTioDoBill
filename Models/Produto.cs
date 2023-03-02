using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantinaDoTioBill.Models
{
    internal class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double ValCompra { get; set; }
        public double ValVenda { get; set; }
        public int Estoque { get; set; }

        public Produto(int id, string nome, double valCompra, double valVenda, int estoque)
        {
            Id = id;
            Nome = nome;
            ValCompra = valCompra;
            ValVenda = valVenda;
            Estoque = estoque;
        }

        public Produto()
        {

        }
    }
}
