using System;
using System.Collections.Generic;

namespace ConsoleApp1;

public partial class Garage
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public int Volume { get; set; }

    public string Location { get; set; } = null!;

    public virtual ICollection<Plane> Planes { get; set; } = new List<Plane>();
}
