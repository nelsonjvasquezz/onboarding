namespace onboarding.data.bases;

/// <summary>
/// Tabla con el detalle de nuevas contrataciones que participan de un programa de onboarding
/// obd.cpr_contrataciones_programa
/// </summary>
public partial class ContratacionPrograma
{
    /// <summary>
    /// Código de registro de contratación de cada programa
    /// </summary>
    public int Codigo { get; set; }

    /// <summary>
    /// Código del programa de onboarding
    /// </summary>
    public int ProgramaCodigo { get; set; }

    /// <summary>
    /// Código del responsable en RRHH de la nueva contratación
    /// </summary>
    public int EmpleoResponsableCodigo { get; set; }

    /// <summary>
    /// Código del puesto a donde será contratado el nuevo empleado
    /// </summary>
    public int PuestoCodigo { get; set; }

    /// <summary>
    /// Código de expediente de la nueva contratación
    /// </summary>
    public int ExpedienteCodigo { get; set; }

    /// <summary>
    /// Código de empleo, cuando la nueva contratación ya se realizó
    /// </summary>
    public int? EmpleoCodigo { get; set; }

    /// <summary>
    /// Código del empleo del jefe inmeditato superior o supervisor responsable de la nueva contratación
    /// </summary>
    public int EmpleoJefeCodigo { get; set; }

    /// <summary>
    /// Código del centro de trabajo donde será ubicado el nuevo empleado
    /// </summary>
    public int CentroTrabajoCodigo { get; set; }

    /// <summary>
    /// Código de la unidad organizativa donde será ubicado el nuevo empleado
    /// </summary>
    public int UnidadCodigo { get; set; }

    /// <summary>
    /// Fecha efectiva de contratación
    /// </summary>
    public DateTime FechaContratacion { get; set; }

    /// <summary>
    /// Fecha esperada de inicio del programa
    /// </summary>
    public DateTime FechaInicio { get; set; }

    /// <summary>
    /// Fecha esperada de finalización del programa
    /// </summary>
    public DateTime FechaFin { get; set; }

    /// <summary>
    /// Data de los campos adicionales
    /// </summary>
    public string RawPropertyBagData { get; set; }

    /// <summary>
    /// Usuario que creo el registro
    /// </summary>
    public string UsuarioGrabacion { get; set; }

    /// <summary>
    /// Fecha en que se creo el registro
    /// </summary>
    public DateTime? FechaGrabacion { get; set; }

    /// <summary>
    /// Usuario que modificó por última vez el registro
    /// </summary>
    public string UsuarioModificacion { get; set; }

    /// <summary>
    /// Fecha de la última modificacion del registro
    /// </summary>
    public DateTime? FechaModificacion { get; set; }

    public virtual ICollection<ActividadPrograma> ActividadesProgramas { get; set; } = new List<ActividadPrograma>();

    public virtual Programa Programa { get; set; };
}
