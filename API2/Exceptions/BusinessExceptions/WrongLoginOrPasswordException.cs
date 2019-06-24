using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.BusinessExceptions
{
    public class WrongLoginOrPasswordException : Exception
    {
        public WrongLoginOrPasswordException() : base("Ocorreu um erro ao salvar os dados")
        {

        }
    }
}
