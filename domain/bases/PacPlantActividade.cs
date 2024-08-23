using System;
using System.Collections.Generic;

namespace onboarding.data.bases;

/// <summary>
/// Tabla que almacena las actividades de la plantilla del programa de onboarding
/// </summary>
public partial class PacPlantActividade
{
    /// <summary>
    /// Código de registro de la actividad de la plantilla para programa de onboarding
    /// </summary>
    public int PacCodigo { get; set; }

    /// <summary>
    /// Código de la plantilla de programa de onboarding
    /// </summary>
    public int PacCodppr { get; set; }

    /// <summary>
    /// Nombre de la actividad
    /// </summary>
    public string PacNombre { get; set; } = null!;

    /// <summary>
    /// Descripción de la actividad
    /// </summary>
    public string? PacDescripcion { get; set; }

    /// <summary>
    /// Objetivo de la actividad
    /// </summary>
    public string? PacObjetivo { get; set; }

    /// <summary>
    /// Código de Etapa o Fase del programa
    /// </summary>
    public int PacCodetp { get; set; }

    /// <summary>
    /// Código de Tipo de Actividad
    /// </summary>
    public int PacCodtac { get; set; }

    /// <summary>
    /// Desplazamiento de tiempo antes o despues de la contratación para determinar la fecha de inicio de la actividad
    /// </summary>
    public int PacOffsetInicio { get; set; }

    /// <summary>
    /// Unidad de medida del desplazamiento
    /// </summary>
    public string PacUnidadOffsetInicio { get; set; } = null!;

    /// <summary>
    /// Duración estimada de la actividad
    /// </summary>
    public int PacDuracionEstimada { get; set; }

    /// <summary>
    /// Unidad de medida de la duracióon estimada de la actividad
    /// </summary>
    public string PacUnidadDuracion { get; set; } = null!;

    /// <summary>
    /// Código de Prioridad de la actividad
    /// </summary>
    public int PacCodpri { get; set; }

    /// <summary>
    /// Orden de esta actividad respecto de las mismas que tienen los mismos prerequisitos
    /// </summary>
    public int PacOrden { get; set; }

    /// <summary>
    /// Código de Tipo de Responsable de la actividad
    /// </summary>
    public int PacCodtra { get; set; }

    /// <summary>
    /// Codigo de Tipo de Evaluación de la activdidad
    /// </summary>
    public int PacCodtev { get; set; }

    /// <summary>
    /// Nota de evaluación esperada para determinar si aprobo o no la evaluación
    /// </summary>
    public decimal PacNotaEvalEsperada { get; set; }

    /// <summary>
    /// Data de los campos adicionales
    /// </summary>
    public string? PacPropertyBagData { get; set; }

    /// <summary>
    /// Usuario que creo el registro
    /// </summary>
    public string? PacUsuarioGrabacion { get; set; }

    /// <summary>
    /// Fecha en que se creo el registro
    /// </summary>
    public DateTime? PacFechaGrabacion { get; set; }

    /// <summary>
    /// Usuario que modificó por última vez el registro
    /// </summary>
    public string? PacUsuarioModificacion { get; set; }

    /// <summary>
    /// Fecha de la última modificacion del registro
    /// </summary>
    public DateTime? PacFechaModificacion { get; set; }

    public virtual EtpEtapasPrograma PacCodetpNavigation { get; set; } = null!;

    public virtual PprPlantPrograma PacCodpprNavigation { get; set; } = null!;

    public virtual PriPrioridade PacCodpriNavigation { get; set; } = null!;

    public virtual TacTiposActividad PacCodtacNavigation { get; set; } = null!;

    public virtual TevTiposEvaluacion PacCodtevNavigation { get; set; } = null!;

    public virtual TraTiposResponActividad PacCodtraNavigation { get; set; } = null!;

    public virtual ICollection<PnaPlantNotificacionAct> PnaPlantNotificacionActs { get; set; } = new List<PnaPlantNotificacionAct>();

    public virtual ICollection<PacPlantActividade> PpaCodpacPrerequisitos { get; set; } = new List<PacPlantActividade>();

    public virtual ICollection<PacPlantActividade> PpaCodpacs { get; set; } = new List<PacPlantActividade>();
}
