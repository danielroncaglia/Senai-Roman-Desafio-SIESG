using Roman.Domains;
using Roman.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roman.Repositores
{
    public class ProfessorRepository : IProfessorRepository
    {
        public void Cadastrar(Professor professor)
        {
            using(RomanContext ctx = new RomanContext())
            {
                ctx.Professor.Add(professor);
                ctx.SaveChanges();
            }
        }

        public IEnumerable<Professor> ListaProfessor()
        {
            using (RomanContext ctx = new RomanContext())
            {
                List<Professor> professor = ctx.Professor.ToList();

                return professor;
            }

        }
    }
}