
namespace CantinaDoTioBill.Models
{
    internal class Usuário
    {
        public class Usuario
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Username { get; set; }
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
}
