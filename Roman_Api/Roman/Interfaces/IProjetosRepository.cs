using Roman.Domains;
using System.Collections.Generic;

namespace Roman.Interfaces
{
    interface IProjetosRepository
    {
        void Cadastrar(Projetos projetos);

        IEnumerable<Projetos> ListaProjetos();

        //fala se o tema esta ativo ou inativo 
        void Situacao(Projetos projetos, int id);

        Projetos BuscarPorId(int id);

        
    }
}
