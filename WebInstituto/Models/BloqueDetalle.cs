using System;
using System.Collections.Generic;

namespace WebInstituto.Models;

public partial class BloqueDetalle
{
    public int IdBloque { get; set; }

    public int IdPrograma { get; set; }

    public int IdCurso { get; set; }

    public int IdProfesor { get; set; }

    public virtual Bloque IdBloqueNavigation { get; set; } = null!;

    public virtual Curso IdCursoNavigation { get; set; } = null!;

    public virtual Profesore IdProfesorNavigation { get; set; } = null!;

    public virtual Programa IdProgramaNavigation { get; set; } = null!;
}
