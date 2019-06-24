using Contracts.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Interface.Service
{
    public interface IAulaService
    {
        List<AulaDTO> GetTodasAsAulas();
        AulaDTO InserirAula(AulaDTO aula);
        AulaDTO AtualizarAula(AulaDTO aula);
    }
}
