using System;
using System.Collections.Generic;

namespace onboarding.data.bases;

/// <summary>
/// Tabla que almacena las prioridades de las actividades del plan de onboarding
/// </summary>
public partial class PrioridadActividad
{
    /// <summary>
    /// Código de la prioridad
    /// </summary>
    public int Codigo { get; set; }

    /// <summary>
    /// Código de Grupo Corporativo
    /// </summary>
    public int GrupoCorporativoCodigo { get; set; }

    /// <summary>
    /// Nombre de la prioridad
    /// </summary>
    public string Nombre { get; set; } = null!;

    /// <summary>
    /// Color con que se muestra la prioridad
    /// </summary>
    public string Color { get; set; } = null!;

    /// <summary>
    /// Ícono con que se muestra la prioridad
    /// </summary>
    public string? Icono { get; set; }

    /// <summary>
    /// Determina el orden las prioridades
    /// </summary>
    public int Orden { get; set; }

    /// <summary>
    /// Data de los campos adicionales
    /// </summary>
    public string? PropertyBagData { get; set; }

    /// <summary>
    /// Usuario que creo el registro
    /// </summary>
    public string? UsuarioGrabacion { get; set; }

    /// <summary>
    /// Fecha en que se creo el registro
    /// </summary>
    public DateTime? FechaGrabacion { get; set; }

    /// <summary>
    /// Usuario que modificó por última vez el registro
    /// </summary>
    public string? UsuarioModificacion { get; set; }

    /// <summary>
    /// Fecha de la última modificacion del registro
    /// </summary>
    public DateTime? FechaModificacion { get; set; }

    public virtual ICollection<ActividadPrograma> ActividadesProgramas { get; set; } = new List<ActividadPrograma>();

    public virtual ICollection<PlantillaActividad> PlantillaActividades { get; set; } = new List<PlantillaActividad>();
}
