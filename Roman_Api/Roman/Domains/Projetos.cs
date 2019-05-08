using System;
using System.Collections.Generic;

namespace Roman.Domains
{
    public partial class Projetos
    {
        public int Id { get; set; }
        public string NomeProjeto { get; set; }
        public string Descricao { get; set; }
        public string Tema { get; set; }
        public int? IdProfessor { get; set; }
        public int Situacao { get; set; }

        public Professor IdProfessorNavigation { get; set; }
    }
}
