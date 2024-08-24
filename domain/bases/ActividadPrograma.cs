using System;
using System.Collections.Generic;

namespace onboarding.data.bases;

/// <summary>
/// Tabla que almacena las actividades de la plantilla del programa de onboarding
/// </summary>
public partial class ActividadPrograma
{
    /// <summary>
    /// Código de registro de la actividad de la plantilla para programa de onboarding
    /// </summary>
    public int Codigo { get; set; }

    /// <summary>
    /// Código de la plantilla de programa de onboarding
    /// </summary>
    public int ContratacionProgramaCodigo { get; set; }

    /// <summary>
    /// Nombre de la actividad
    /// </summary>
    public string Nombre { get; set; } = null!;

    /// <summary>
    /// Descripción de la actividad
    /// </summary>
    public string? Descripcion { get; set; }

    /// <summary>
    /// Objetivo de la actividad
    /// </summary>
    public string? Objetivo { get; set; }

    /// <summary>
    /// Código de Etapa o Fase del programa
    /// </summary>
    public int EtapaProgramaCodigo { get; set; }

    /// <summary>
    /// Código de Tipo de Actividad
    /// </summary>
    public int TipoActividadCodigo { get; set; }

    /// <summary>
    /// Código de empleo responsable de la evaluación
    /// </summary>
    public int? EmpleoResponsableCodigo { get; set; }

    /// <summary>
    /// Fecha calculada de inicio de la actividad
    /// </summary>
    public DateTime FechaInicio { get; set; }

    /// <summary>
    /// Fecha calculada de infalización de la actividad
    /// </summary>
    public DateTime FechaFin { get; set; }

    /// <summary>
    /// Duración de la actividad
    /// </summary>
    public int Duracion { get; set; }

    /// <summary>
    /// Unidad de medida de la duración de la actividad
    /// </summary>
    public string UnidadDuracion { get; set; } = null!;

    /// <summary>
    /// Código de Prioridad de la actividad
    /// </summary>
    public int PrioridadActividadCodigo { get; set; }

    /// <summary>
    /// Orden de esta actividad respecto de las mismas que tienen los mismos prerequisitos
    /// </summary>
    public int Orden { get; set; }

    /// <summary>
    /// Código de Tipo de Responsable de la actividad
    /// </summary>
    public int TipoResponsableActividadCodigo { get; set; }

    /// <summary>
    /// Codigo de Tipo de Evaluación de la activdidad (NULL cuando no requiere evaluación)
    /// </summary>
    public int? TipoEvaluacionCodigo { get; set; }

    /// <summary>
    /// Fecha de evaluación de la actividad
    /// </summary>
    public DateTime? FechaEvaluacion { get; set; }

    /// <summary>
    /// Nota de la evaluación dada por el responsable de la actividad
    /// </summary>
    public decimal? NotaEvaluacion { get; set; }

    /// <summary>
    /// Determina si la evaluación fue aprobada o no
    /// </summary>
    public string? ResultadoEvaluacion { get; set; }

    /// <summary>
    /// Código de la data del formulario dinámico (cuando está definido según el tipo de evaluación)
    /// </summary>
    public int? FormularioDinamicoDataCodigo { get; set; }

    /// <summary>
    /// Estado de la actividad (Pendiente, En Proceso, Finalizada)
    /// </summary>
    public string Estado { get; set; } = null!;

    /// <summary>
    /// Fecha de finalización de la actividad (fecha en el estado cambio a finalizada)
    /// </summary>
    public DateTime? FechaFinalizacion { get; set; }

    /// <summary>
    /// Comentarios de evaluador o quien finaliza la actividad
    /// </summary>
    public string? ComentarioFinalizacion { get; set; }

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

    public virtual ContratacionPrograma ContratacionPrograma { get; set; } = null!;

    public virtual EtapaPrograma EtapaPrograma { get; set; } = null!;

    public virtual PrioridadActividad PrioridadActividad { get; set; } = null!;

    public virtual TipoActividad TipoActividad { get; set; } = null!;

    public virtual TipoEvaluacion? TipoEvaluacion { get; set; }

    public virtual TipoResponsableActividad TipoResponsableActividad { get; set; } = null!;

    public virtual ICollection<NotificacionActividadPrograma> NotificacionActividadProgramas { get; set; } = new List<NotificacionActividadPrograma>();

    public virtual ICollection<ActividadPrograma> RapCodacpPrerequisitos { get; set; } = new List<ActividadPrograma>();

    public virtual ICollection<ActividadPrograma> RapCodpacs { get; set; } = new List<ActividadPrograma>();
}
