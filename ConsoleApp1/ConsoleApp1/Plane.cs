using System;
using System.Collections.Generic;

namespace ConsoleApp1;

public partial class Plane
{
    public int Id { get; set; }

    public string Model { get; set; } = null!;

    public string Company { get; set; } = null!;

    public int GarageId { get; set; }

    public virtual Garage Garage { get; set; } = null!;
}
