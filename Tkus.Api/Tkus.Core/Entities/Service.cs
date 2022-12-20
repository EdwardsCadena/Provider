using System;
using System.Collections.Generic;

namespace Tkus.Core.Entities;

public partial class Service
{
    public int IdServices { get; set; }

    public string Nit { get; set; } = null!;

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public int FkSupplier { get; set; }

    public int Fkcities { get; set; }


}
