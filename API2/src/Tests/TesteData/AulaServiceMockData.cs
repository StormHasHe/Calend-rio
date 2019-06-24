using Contracts.DTO;
using Entities.CalendarioOperacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.TesteData
{
    public static class AulaServiceMockData
    {
        public static IEnumerable<Aula> CustomersList()
        {
            var list = new List<Aula>();

            var item1 = new Aula() {
                Id = 1,
                Data = DateTime.Now.AddDays(3),
                Local = "Barra da Tijuca - RJ",
                ResponsavelID = 1,
                SeguidoresID = 2,
                Status = 1,
                Tipo = "Aula",
                Subtipo = "Regular",
                JSONObj = "JSON AQUI"
            };

            var item2 = new Aula()
            {
                Id = 2,
                Data = DateTime.Now.AddDays(4),
                Local = "Barra da Tijuca - RJ",
                ResponsavelID = 1,
                SeguidoresID = 2,
                Status = 1,
                Tipo = "Aula",
                Subtipo = "Regular",
                JSONObj = "JSON AQUI"
            };

            var item3 = new Aula()
            {
                Id = 3,
                Data = DateTime.Now.AddDays(5),
                Local = "Barra da Tijuca - RJ",
                ResponsavelID = 1,
                SeguidoresID = 2,
                Status = 1,
                Tipo = "Aula",
                Subtipo = "Regular",
                JSONObj = "JSON AQUI"
            };

            list.Add(item1);
            list.Add(item2);
            list.Add(item3);

            return list.AsEnumerable();
        }
    }
}
