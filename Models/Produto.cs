using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantinaDoTioBill.Models
{
    internal class Produto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public double ValCompra { get; set; }
        [Required]
        public double ValVenda { get; set; }
        [Required]
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
