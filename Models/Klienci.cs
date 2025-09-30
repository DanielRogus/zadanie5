using System;
using System.Collections.Generic;

namespace ZADANIE5.Models;

public partial class Klienci
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string Pesel { get; set; } = null!;

    public short BirthYear { get; set; }

    public short? Gender { get; set; }
}
