using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tkus.Core.DTOs
{
    public class ServiceDtos
    {
        public int IdServices { get; set; }

        public string Nit { get; set; } = null!;

        public string Name { get; set; } = null!;

        public decimal Price { get; set; }

        public int FkSupplier { get; set; }

        public int Fkcities { get; set; }
    }
}
