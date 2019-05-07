using Roman.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roman.Interfaces
{
    interface IGrupoRepository
    {
        void Cadastrar(Grupo grupo);
    }
}
