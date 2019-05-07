using Roman.Domains;
using Roman.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roman.Repositores
{
    public class ProjetosRepository : IProjetosRepository
    {
        public void Cadastrar(Projetos projetos)
        {
            using(RomanContext ctx = new RomanContext())
            {
                ctx.Projetos.Add(projetos);
                ctx.SaveChanges();
            }
        }

        public IEnumerable<Projetos> ListaProjetos()
        {
            using(RomanContext ctx = new RomanContext())
            {
                List<Projetos> projetos = ctx.Projetos.ToList();

                return projetos;
            }

        }
    }
}
