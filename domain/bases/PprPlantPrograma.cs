using System;
using System.Collections.Generic;

namespace onboarding.data.bases;

/// <summary>
/// Tabla que almacena la plantilla para los programas de onboarding
/// </summary>
public partial class PprPlantPrograma
{
    /// <summary>
    /// Código de plantilla de programa de onboarding
    /// </summary>
    public int PprCodigo { get; set; }

    /// <summary>
    /// Código de Grupo Corporativo
    /// </summary>
    public int PprCodgrc { get; set; }

    /// <summary>
    /// Nombre del programa de onboarding
    /// </summary>
    public string PprNombre { get; set; } = null!;

    /// <summary>
    /// Descripción del programa de onboarding
    /// </summary>
    public string? PprDescripcion { get; set; }

    /// <summary>
    /// Objetivos del programa de onboarding
    /// </summary>
    public string? PprObjetivo { get; set; }

    /// <summary>
    /// Estado de la plantilla &apos;Activa&apos; o &apos;Inactiva&apos;  (inactivas para fines de guardar históricos y que no aparezcan en la selección)
    /// </summary>
    public string PprEstado { get; set; } = null!;

    /// <summary>
    /// Duración estimada del programa
    /// </summary>
    public int PprDuracionEstimada { get; set; }

    /// <summary>
    /// Unidad de medida de la duración estimada del programa
    /// </summary>
    public string PprUnidadDuracion { get; set; } = null!;

    /// <summary>
    /// Data de los campos adicionales
    /// </summary>
    public string? PprPropertyBagData { get; set; }

    /// <summary>
    /// Usuario que creo el registro
    /// </summary>
    public string? PprUsuarioGrabacion { get; set; }

    /// <summary>
    /// Fecha en que se creo el registro
    /// </summary>
    public DateTime? PprFechaGrabacion { get; set; }

    /// <summary>
    /// Usuario que modificó por última vez el registro
    /// </summary>
    public string? PprUsuarioModificacion { get; set; }

    /// <summary>
    /// Fecha de la última modificacion del registro
    /// </summary>
    public DateTime? PprFechaModificacion { get; set; }

    public virtual ICollection<PacPlantActividade> PacPlantActividades { get; set; } = new List<PacPlantActividade>();

    public virtual ICollection<PalPlantAlcance> PalPlantAlcances { get; set; } = new List<PalPlantAlcance>();

    public virtual ICollection<ProPrograma> ProProgramas { get; set; } = new List<ProPrograma>();
}
