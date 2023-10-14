using System;
using System.Collections.Generic;

namespace WebInstituto.Models;

public partial class Matricula
{
    public int IdMatricula { get; set; }

    public int IdEstudiante { get; set; }

    public int IdBloque { get; set; }

    public DateTime PeriodoMatricula { get; set; }

    public virtual Bloque IdBloqueNavigation { get; set; } = null!;

    public virtual Estudiante IdEstudianteNavigation { get; set; } = null!;
}
