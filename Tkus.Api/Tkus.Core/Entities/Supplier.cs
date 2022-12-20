using System;
using System.Collections.Generic;

namespace Tkus.Core.Entities;

public class Supplier
{
    public int IdSupplier { get; set; }

    public string Nit { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

}
