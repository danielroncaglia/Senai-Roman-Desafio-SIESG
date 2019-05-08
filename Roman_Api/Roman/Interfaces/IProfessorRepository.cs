using Roman.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roman.Interfaces
{
    interface IProfessorRepository
    {
        void Cadastrar(Professor professor);

        IEnumerable<Professor> ListaProfessor();
    }
}
