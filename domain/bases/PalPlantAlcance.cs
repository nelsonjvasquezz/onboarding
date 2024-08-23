using System;
using System.Collections.Generic;

namespace onboarding.data.bases;

public partial class PalPlantAlcance
{
    /// <summary>
    /// Código de registro de alcance para la plantilla de programa de onboarding
    /// </summary>
    public int PalCodigo { get; set; }

    /// <summary>
    /// Código de plantilla de programa de onboarding
    /// </summary>
    public int PalCodppr { get; set; }

    /// <summary>
    /// Tipo de Alcance
    /// </summary>
    public string PalTipo { get; set; } = null!;

    /// <summary>
    /// Código de Tipo de Puesto
    /// </summary>
    public int? PalCodtpp { get; set; }

    /// <summary>
    /// Código de Puesto
    /// </summary>
    public int? PalCodpue { get; set; }

    /// <summary>
    /// Data de los campos adicionales
    /// </summary>
    public string? PalPropertyBagData { get; set; }

    /// <summary>
    /// Usuario que creo el registro
    /// </summary>
    public string? PalUsuarioGrabacion { get; set; }

    /// <summary>
    /// Fecha en que se creo el registro
    /// </summary>
    public DateTime? PalFechaGrabacion { get; set; }

    /// <summary>
    /// Usuario que modificó por última vez el registro
    /// </summary>
    public string? PalUsuarioModificacion { get; set; }

    /// <summary>
    /// Fecha de la última modificacion del registro
    /// </summary>
    public DateTime? PalFechaModificacion { get; set; }

    public virtual PprPlantPrograma PalCodpprNavigation { get; set; } = null!;
}
