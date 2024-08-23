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
    public int Codigo { get; set; }

    /// <summary>
    /// Código de plantilla programa
    /// </summary>
    public int PlantillaProgramaCodigo { get; set; }

    /// <summary>
    /// Nombre del programa de onboarding
    /// </summary>
    public string Nombre { get; set; } = null!;

    /// <summary>
    /// Descripción del programa de onboarding
    /// </summary>
    public string? Descripcion { get; set; }

    /// <summary>
    /// Objetivos del programa de onboarding
    /// </summary>
    public string? Objetivo { get; set; }

    /// <summary>
    /// Estado del programa &apos;Planificado&apos; o &apos;En Ejecución&apos; o &apos;Finalizado&apos;
    /// </summary>
    public string Estado { get; set; } = null!;

    /// <summary>
    /// Duración estimada del programa
    /// </summary>
    public int Duracion { get; set; }

    /// <summary>
    /// Unidad de medida de la duración estimada del programa
    /// </summary>
    public string UnidadDuracion { get; set; } = null!;

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

    public virtual ICollection<ContratacionPrograma> ContratacionesProgramas { get; set; } = new List<ContratacionPrograma>();

    public virtual PlantillaPrograma PlantillaPrograma { get; set; } = null!;
}
