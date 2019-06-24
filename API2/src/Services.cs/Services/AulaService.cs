using Contracts.DTO;
using Contracts.Interface.Service;
using DataAccessContracts.Interface.DataAccess;
using Exceptions.DataAccessExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class AulaService : IAulaService
    {
        IAulaRepository _aulaRepository;

        public AulaService(IAulaRepository aulaRepository)
        {
            _aulaRepository = aulaRepository;
        }

        public List<AulaDTO> GetTodasAsAulas()
        {
            return _aulaRepository.GetAll().ToList().ToAulasDTO();
        }

        public AulaDTO InserirAula(AulaDTO aula)
        {
            return _aulaRepository.InserirAula(aula.ToAulaEntity()).ToAulaDTO();
        }

        public AulaDTO AtualizarAula(AulaDTO aula)
        {
            return _aulaRepository.Atualizar(aula.ToAulaEntity()).ToAulaDTO();
        }
    }
}
