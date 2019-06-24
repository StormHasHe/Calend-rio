using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.TesteData;
using DataAccessContracts.Interface.DataAccess;
using Contracts.Interface.Service;

namespace Tests.UnitTests
{
    [TestClass]
    public class AulaServiceTest
    {
        IAulaRepository _mockAulaRepository;
        IAulaService _aulaService;

        public AulaServiceTest()
        {
            _mockAulaRepository = MockRepository.GenerateMock<IAulaRepository>();

            _mockAulaRepository.Stub<IAulaRepository>(x => x.GetAll()).Return(AulaServiceMockData.CustomersList());

            _aulaService = new AulaService(_mockAulaRepository);

        }

        [TestMethod]
        [TestCategory("Aulas")]
        public void CalendarioOperacao_RetornarTodasAsAulas_Correto()
        {
            var aulas = _aulaService.GetTodasAsAulas();

            _mockAulaRepository.AssertWasCalled<IAulaRepository>(x => x.GetAll());
            Assert.IsTrue(aulas.Count == 3, "CalendarioOperacao_RetornarTodasAsAulas_Correto Não retornando todas as aulas");
        }

    }
}
