using System;
using System.Collections.Generic;

namespace Tkus.Core.Entities;
public class Security
{
    public int IdSecurity { get; set; }

    public string Users { get; set; } = null!;

    public string NameUser { get; set; } = null!;

    public string Password { get; set; } = null!;
}
