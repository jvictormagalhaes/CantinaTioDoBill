using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CantinaDoTioBill.Models
{
    internal class Venda
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public bool Status { get; set; }
        [ForeignKey("Cliente")]
        public Cliente IdCliente { get; set; }
        [ForeignKey("Cliente")]
        public Cliente NomeCliente { get; set; }
        [Required]
        public double Subtotal { get; set; }
        [Required]
        public double Desconto { get; set; }
        [Required]
        public double TaxaEntrega { get; set; }
        [Required]
        public double ValorTotal { get; set; }
        [Required]
        public DateTime Data { get; set; }
        [Required]
        public List<Produto> produtos { get; set; }


        public Venda()
        {

        }

    }

    
}
