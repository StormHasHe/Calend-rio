using Entities.CalendarioOperacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessContracts.Interface.DataAccess
{
    public interface IAulaRepository
    {
        IEnumerable<Aula> GetAll();
        Aula InserirAula(Aula aula);
        Aula Atualizar(Aula aula);
    }
}
