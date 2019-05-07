using System;
using System.Collections.Generic;

namespace Roman.Domains
{
    public partial class Professor
    {
        public Professor()
        {
            Projetos = new HashSet<Projetos>();
        }

        public int Id { get; set; }
        public int? IdUsuario { get; set; }
        public string NomeProfessor { get; set; }
        public int? IdGrupo { get; set; }

        public Grupo IdGrupoNavigation { get; set; }
        public Usuario IdUsuarioNavigation { get; set; }
        public ICollection<Projetos> Projetos { get; set; }
    }
}
