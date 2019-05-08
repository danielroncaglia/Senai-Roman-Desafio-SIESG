using System;
using System.Collections.Generic;

namespace Roman.Domains
{
    public partial class Usuario
    {
        public Usuario()
        {
            Professor = new HashSet<Professor>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string TipoUsuario { get; set; }

        public ICollection<Professor> Professor { get; set; }
    }
}
