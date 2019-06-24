using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.DataAccessExceptions
{
    public class RecordDoesNotExistException : Exception
    {
        public RecordDoesNotExistException() : base("A informação em questão não existe. É possível que tenha sido excluida por outro usuário")
        {

        }
    }
}
