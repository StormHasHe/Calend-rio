using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.DTO
{
    public class AulaDTO
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Local { get; set; }
        public string Tipo { get; set; }
        public string Subtipo { get; set; }
        public dynamic JSONObj { get; set; }
        public int Status { get; set; }
        public int ResponsavelID { get; set; }
        public int SeguidoresID { get; set; }
    }
}
