using System;
using System.Collections.Generic;

namespace onboarding.data.bases;

/// <summary>
/// Tabla que almacena los programas de onboarding
/// </summary>
public partial class Programa
{
    /// <summary>
    /// Código de programa de onboarding
    /// </summary>
    public int ProCodigo { get; set; }

    public int ProCodppr { get; set; }

    /// <summary>
    /// Nombre del programa de onboarding
    /// </summary>
    public string ProNombre { get; set; } = null!;

    /// <summary>
    /// Descripción del programa de onboarding
    /// </summary>
    public string? ProDescripcion { get; set; }

    /// <summary>
    /// Objetivos del programa de onboarding
    /// </summary>
    public string? ProObjetivo { get; set; }

    /// <summary>
    /// Estado del programa &apos;Planificado&apos; o &apos;En Ejecución&apos; o &apos;Finalizado&apos;
    /// </summary>
    public string ProEstado { get; set; } = null!;

    /// <summary>
    /// Duración estimada del programa
    /// </summary>
    public int ProDuracion { get; set; }

    /// <summary>
    /// Unidad de medida de la duración estimada del programa
    /// </summary>
    public string ProUnidadDuracion { get; set; } = null!;

    /// <summary>
    /// Data de los campos adicionales
    /// </summary>
    public string? ProPropertyBagData { get; set; }

    /// <summary>
    /// Usuario que creo el registro
    /// </summary>
    public string? ProUsuarioGrabacion { get; set; }

    /// <summary>
    /// Fecha en que se creo el registro
    /// </summary>
    public DateTime? ProFechaGrabacion { get; set; }

    /// <summary>
    /// Usuario que modificó por última vez el registro
    /// </summary>
    public string? ProUsuarioModificacion { get; set; }

    /// <summary>
    /// Fecha de la última modificacion del registro
    /// </summary>
    public DateTime? ProFechaModificacion { get; set; }

    public virtual ICollection<ContratacionPrograma> ContratacionesProgramas { get; set; } = new List<ContratacionPrograma>();

    public virtual PprPlantPrograma ProCodpprNavigation { get; set; } = null!;
}
