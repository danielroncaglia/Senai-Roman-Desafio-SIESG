using System;
using System.Collections.Generic;

namespace Roman.Domains
{
    public partial class Grupo
    {
        public Grupo()
        {
            Professor = new HashSet<Professor>();
        }

        public int Id { get; set; }
        public string NomeGrupo { get; set; }

        public ICollection<Professor> Professor { get; set; }
    }
}
