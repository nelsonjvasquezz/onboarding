using System;
using System.Collections.Generic;

namespace onboarding.data.bases;

/// <summary>
/// Tabla que almacena el alcance para la Platilla del programa
/// </summary>
public partial class AlcancePlantillaPrograma
{
    /// <summary>
    /// Código de registro de alcance para la plantilla de programa de onboarding
    /// </summary>
    public int Codigo { get; set; }

    /// <summary>
    /// Código de plantilla de programa de onboarding
    /// </summary>
    public int PlantillaProgramaCodigo { get; set; }

    /// <summary>
    /// Tipo de Alcance
    /// </summary>
    public string Tipo { get; set; } = null!;

    /// <summary>
    /// Código de Tipo de Puesto
    /// </summary>
    public int? TipoPuestoCodigo { get; set; }

    /// <summary>
    /// Código de Puesto
    /// </summary>
    public int? PuestoCodigo { get; set; }

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

    public virtual PlantillaPrograma PlantillaPrograma { get; set; } = null!;
}
