using System;
using System.Collections.Generic;

namespace WebInstituto.Models;

public partial class Bloque
{
    public int IdBloque { get; set; }

    public string NombreBloque { get; set; } = null!;

    public DateTime PeriodoBloque { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<Matricula> Matriculas { get; set; } = new List<Matricula>();
}
