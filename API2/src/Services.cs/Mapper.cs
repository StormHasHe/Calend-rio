using Contracts.DTO;
using Entities.CalendarioOperacao;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    internal static class Mapper
    {
        public static AulaDTO ToAulaDTO(this Aula aula)
        {
            var retorno = new AulaDTO()
            {
                Id = aula.Id,
                Data = aula.Data,
                JSONObj = JsonConvert.DeserializeObject(aula.JSONObj),
                Local = aula.Local,
                ResponsavelID = aula.ResponsavelID,
                SeguidoresID = aula.SeguidoresID,
                Status = aula.Status,
                Subtipo = aula.Subtipo,
                Tipo = aula.Tipo
            };

            return retorno;
        }

        public static Aula ToAulaEntity(this AulaDTO aula)
        {
            var retorno = new Aula()
            {
                Id = aula.Id,
                Data = aula.Data,
                JSONObj = JsonConvert.SerializeObject(aula.JSONObj),
                Local = aula.Local,
                ResponsavelID = aula.ResponsavelID,
                SeguidoresID = aula.SeguidoresID,
                Status = aula.Status,
                Subtipo = aula.Subtipo,
                Tipo = aula.Tipo
            };

            return retorno;
        }

        public static List<AulaDTO> ToAulasDTO(this List<Aula> aulas)
        {
            var list = new List<AulaDTO>();

            foreach (var aula in aulas)
            {
                var dto = ToAulaDTO(aula);

                list.Add(dto);
            }

            return list;
        }
    }
}
