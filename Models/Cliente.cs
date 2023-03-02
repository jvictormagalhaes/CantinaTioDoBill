using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace CantinaDoTioBill.Models
{
    internal class Cliente
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
