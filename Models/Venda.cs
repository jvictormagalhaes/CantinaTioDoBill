using System.ComponentModel.DataAnnotations;


namespace CantinaDoTioBill.Models
{
    public class Venda
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public double Subtotal { get; set; }
        [Required]
        public int ClienteNum { get; set; }  //Id cliente
        [Required]
        public double Desconto { get; set; }
        [Required]
        public double TaxaEntrega { get; set; }
        [Required]
        public double ValorTotal { get; set; }
        [Required]
        public DateTime Data { get; set; }

        public Venda()
        {

        }

    }

    
}
