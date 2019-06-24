using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.CalendarioOperacao
{
    public class Aula
    {
        public Aula()
        {
        }

        public virtual int Id { get; set; }
        public virtual DateTime Data { get; set; }
        public virtual string Local { get; set; }
        public virtual string Tipo { get; set; }
        public virtual string Subtipo { get; set; }
        public virtual string JSONObj { get; set; }
        public virtual int Status { get; set; }
        public virtual int ResponsavelID { get; set; }
        public virtual int SeguidoresID { get; set; }
    }
}
