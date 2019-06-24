using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.DataAccessExceptions
{
    public class ErrorSavingDataException : Exception
    {
        public ErrorSavingDataException() : base("Ocorreu um erro ao salvar os dados")
        {
            
        }
    }
}
