using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tkus.Core.DTOs
{
    public class SecurityDtos
    {
        public int IdSecurity { get; set; }

        public string Users { get; set; } = null!;

        public string NameUser { get; set; } = null!;

        public string Password { get; set; } = null!;
    }
}
