using System;
using System.Collections.Generic;

namespace SistemaVenta.Model;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string? NombreCompleto { get; set; }

    public string? Correo { get; set; }

    public int? IdRol { get; set; }

    public string? Clave { get; set; }

    public bool? EsActivo { get; set; }

    //No debesn ser visuales para el angular
    public DateTime? FechaRegistro { get; set; }

    //No deben ser visuales para el angular
    public virtual Rol? IdRolNavigation { get; set; }
}
