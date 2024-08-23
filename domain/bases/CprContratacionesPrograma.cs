using System;
using System.Collections.Generic;

namespace onboarding.data.bases;

/// <summary>
/// Tabla con el detalle de nuevas contrataciones que participan de un programa de onboarding
/// </summary>
public partial class CprContratacionesPrograma
{
    /// <summary>
    /// Código de registro de contratación de cada programa
    /// </summary>
    public int CprCodigo { get; set; }

    /// <summary>
    /// Código del programa de onboarding
    /// </summary>
    public int CprCodpro { get; set; }

    /// <summary>
    /// Código del responsable en RRHH de la nueva contratación
    /// </summary>
    public int CprCodempRespRrhh { get; set; }

    /// <summary>
    /// Código del puesto a donde será contratado el nuevo empleado
    /// </summary>
    public int CprCodpue { get; set; }

    /// <summary>
    /// Código de expediente de la nueva contratación
    /// </summary>
    public int CprCodexp { get; set; }

    /// <summary>
    /// Código de empleo, cuando la nueva contratación ya se realizó
    /// </summary>
    public int? CprCodemp { get; set; }

    /// <summary>
    /// Código del empleo del jefe inmeditato superior o supervisor responsable de la nueva contratación
    /// </summary>
    public int CprCodempJefe { get; set; }

    /// <summary>
    /// Código del centro de trabajo donde será ubicado el nuevo empleado
    /// </summary>
    public int CprCodcdt { get; set; }

    /// <summary>
    /// Código de la unidad organizativa donde será ubicado el nuevo empleado
    /// </summary>
    public int CprCoduni { get; set; }

    /// <summary>
    /// Fecha efectiva de contratación
    /// </summary>
    public DateTime CprFechaContratacion { get; set; }

    /// <summary>
    /// Fecha esperada de inicio del programa
    /// </summary>
    public DateTime CprFechaInicio { get; set; }

    /// <summary>
    /// Fecha esperada de finalización del programa
    /// </summary>
    public DateTime CprFechaFin { get; set; }

    /// <summary>
    /// Data de los campos adicionales
    /// </summary>
    public string? CprPropertyBagData { get; set; }

    /// <summary>
    /// Usuario que creo el registro
    /// </summary>
    public string? CprUsuarioGrabacion { get; set; }

    /// <summary>
    /// Fecha en que se creo el registro
    /// </summary>
    public DateTime? CprFechaGrabacion { get; set; }

    /// <summary>
    /// Usuario que modificó por última vez el registro
    /// </summary>
    public string? CprUsuarioModificacion { get; set; }

    /// <summary>
    /// Fecha de la última modificacion del registro
    /// </summary>
    public DateTime? CprFechaModificacion { get; set; }

    public virtual ICollection<ActividadesPrograma> ActividadesProgramas { get; set; } = new List<ActividadesPrograma>();

    public virtual ProPrograma CprCodproNavigation { get; set; } = null!;
}
