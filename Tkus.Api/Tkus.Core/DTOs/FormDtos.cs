using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tkus.Core.DTOs
{
    public class FormDtos
    {
        public int IdForm { get; set; }

        public string Name { get; set; } = null!;

        public int Fktypeform { get; set; }

        public int Fksuppliers { get; set; }
    }
}
