using Roman.Domains;
using Roman.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roman.Repositores
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public Usuario BuscarPorEmailSenha(string email, string senha)
        {
            using (RomanContext ctx = new RomanContext())
            {
                return ctx.Usuario.FirstOrDefault(u => u.Email == email && u.Senha == senha);
            }
        }

        public void Cadastrar(Usuario usuario)
        {
            using (RomanContext ctx = new RomanContext())
            {
                ctx.Usuario.Add(usuario);
                ctx.SaveChanges();
            }
        }

        public IEnumerable<Usuario> ListaUsuario()
        {
            using (RomanContext ctx = new RomanContext())
            {
                List<Usuario> usuario = ctx.Usuario.ToList();

                return usuario;
            }

        }
    }
}
