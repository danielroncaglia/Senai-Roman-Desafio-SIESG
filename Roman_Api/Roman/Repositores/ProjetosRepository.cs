using Roman.Domains;
using Roman.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Roman.Repositores
{
    public class ProjetosRepository : IProjetosRepository
    {

        public Projetos BuscarPorId(int id)
        {
            using (RomanContext buscar = new RomanContext())
            {
                return buscar.Projetos.Find(id);
            }
        }

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

        public void Situacao(Projetos projetos, int id)
        {
            using (RomanContext situacao = new RomanContext())
            {
                situacao.Projetos.Update(projetos);
                situacao.SaveChanges();
            }
        }
    }
}
