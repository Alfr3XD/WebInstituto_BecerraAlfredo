using System;
using System.Collections.Generic;

namespace WebInstituto.Models;

public partial class Estudiante
{
    public int IdEstudiante { get; set; }

    public string NombreEstudiante { get; set; } = null!;

    public int EdadEstudiante { get; set; }

    public string SexoEstudiante { get; set; } = null!;

    public virtual ICollection<Matricula> Matriculas { get; set; } = new List<Matricula>();
}
