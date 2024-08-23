using System;
using System.Collections.Generic;

namespace onboarding.data.bases;

/// <summary>
/// Tabla que almacena las actividades de la plantilla del programa de onboarding
/// </summary>
public partial class ActividadesPrograma
{
    /// <summary>
    /// Código de registro de la actividad de la plantilla para programa de onboarding
    /// </summary>
    public int Codigo { get; set; }

    /// <summary>
    /// Código de la plantilla de programa de onboarding
    /// </summary>
    public int Codcpr { get; set; }

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
    public int Codetp { get; set; }

    /// <summary>
    /// Código de Tipo de Actividad
    /// </summary>
    public int Codtac { get; set; }

    /// <summary>
    /// Código de empleo responsable de la evaluación
    /// </summary>
    public int? CodempResponsable { get; set; }

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
    public int Codpri { get; set; }

    /// <summary>
    /// Orden de esta actividad respecto de las mismas que tienen los mismos prerequisitos
    /// </summary>
    public int Orden { get; set; }

    /// <summary>
    /// Código de Tipo de Responsable de la actividad
    /// </summary>
    public int Codtra { get; set; }

    /// <summary>
    /// Codigo de Tipo de Evaluación de la activdidad (NULL cuando no requiere evaluación)
    /// </summary>
    public int? Codtev { get; set; }

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
    public int? Codfdd { get; set; }

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

    public virtual CprContratacionesPrograma CodcprNavigation { get; set; } = null!;

    public virtual EtpEtapasPrograma CodetpNavigation { get; set; } = null!;

    public virtual PriPrioridade CodpriNavigation { get; set; } = null!;

    public virtual TacTiposActividad CodtacNavigation { get; set; } = null!;

    public virtual TevTiposEvaluacion? CodtevNavigation { get; set; }

    public virtual TraTiposResponActividad CodtraNavigation { get; set; } = null!;

    public virtual ICollection<NapNotifActividadPrograma> NapNotifActividadProgramas { get; set; } = new List<NapNotifActividadPrograma>();

    public virtual ICollection<ActividadesPrograma> RapCodacpPrerequisitos { get; set; } = new List<ActividadesPrograma>();

    public virtual ICollection<ActividadesPrograma> RapCodpacs { get; set; } = new List<ActividadesPrograma>();
}
