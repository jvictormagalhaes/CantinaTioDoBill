using CantinaDoTioBill.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantinaDoTioBill.Controller
{
    public class UsuarioController
    {
        public static BancoContext db;

        static UsuarioController()
        {
            db = new BancoContext();
        }

        public static void Adicionar(Usuario usuario)
        {
            db.Usuario.Add(usuario);
            db.Entry(usuario).State = usuario.Id > 0 ? EntityState.Modified :
                EntityState.Added;
            db.SaveChanges();
        }

        public static Usuario GetUsuario(int Id)
        {
            return db.Usuario.Where(x => x.Id == Id).FirstOrDefault();
        }

        public static List<Usuario> ListaUsuario()
        {
            return db.Usuario.ToList();
        }

        public static void Excluir(int Id)
        {
            Usuario usuario = GetUsuario(Id);
            db.Usuario.Remove(usuario);
            db.SaveChanges();
        }

    }
}
