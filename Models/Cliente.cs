
using System.ComponentModel.DataAnnotations;


namespace CantinaDoTioBill.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Nome { get; set; }
        [Required]
        public string Cpf { get; set; }
        [Required]
        public string Rg { get; set; }
        [Required]
        public string Telefone { get; set; }
        [Required]
        public string Endereco { get; set; }
        [Required]
        public string Bairro { get; set; }
        [Required]
        public string Numero { get; set; }


        public Cliente(int id, string nome, string cpf, string rg, string telefone, string endereco, string bairro)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            Telefone = telefone;
            Endereco = endereco;
            Bairro = bairro;
        }
        public Cliente()
        {

        }
    }
}
