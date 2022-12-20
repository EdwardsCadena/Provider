using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tkus.Core.DTOs
{
    public class SupplierDtos
    {
        public int IdSupplier { get; set; }

        public string Nit { get; set; } = null!;

        public string Name { get; set; } = null!;

        public string Email { get; set; } = null!;
    }
}
