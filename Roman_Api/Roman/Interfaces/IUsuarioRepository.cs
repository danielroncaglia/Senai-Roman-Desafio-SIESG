using Roman.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roman.Interfaces
{
    interface IUsuarioRepository
    {
        void Cadastrar(Usuario usuario);

        Usuario BuscarPorEmailSenha(string email, string senha);

        IEnumerable<Usuario> ListaUsuario();
    }
}
