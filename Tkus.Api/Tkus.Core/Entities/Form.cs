using System;
using System.Collections.Generic;

namespace Tkus.Core.Entities;

public class Form
{
    public int IdForm { get; set; }

    public string Name { get; set; } = null!;

    public int Fktypeform { get; set; }

    public int Fksuppliers { get; set; }

}
