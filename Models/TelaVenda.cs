
using System.ComponentModel.DataAnnotations;

namespace CantinaDoTioBill.Models
{
    internal class TelaVenda
    {
        [Key,Required]
        public int IdItem { get; set; }
        [Required]
        public string NomeItem { get; set; }
        [Required]
        public int IdProduto { get; set; }
        [Required]
        public double ValorUnitario { get; set; }
        [Required]
        public int Quantidade { get; set; }
        [Required]
        public double Total { get; set; }
    }
}
