using Roman.Domains;
using Roman.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roman.Repositores
{
    public class GrupoRepository : IGrupoRepository
    {
        public void Cadastrar(Grupo grupo)
        {
            using(RomanContext ctx = new RomanContext())
            {
                ctx.Grupo.Add(grupo);
                ctx.SaveChanges();
            }
        }

        public IEnumerable<Grupo> ListaGrupo()
        {
            using (RomanContext ctx = new RomanContext())
            {
                List<Grupo> grupos = ctx.Grupo.ToList();

                return grupos;
            }

        }
    }
}
