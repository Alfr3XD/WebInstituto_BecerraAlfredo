using System;
using System.Collections.Generic;

namespace WebInstituto.Models;

public partial class Programa
{
    public int IdPrograma { get; set; }

    public string NombrePrograma { get; set; } = null!;

    public int DuraciónPrograma { get; set; }
}
