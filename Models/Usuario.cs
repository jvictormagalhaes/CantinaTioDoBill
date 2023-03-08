
using System.ComponentModel.DataAnnotations;

namespace CantinaDoTioBill.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]

        public string Senha { get; set; }

        public Usuario(string nome, string username, string senha)
        {
            Nome = nome;
            Username = username;
            Senha = senha;
        }

        public Usuario()
        {

        }
    }
}
