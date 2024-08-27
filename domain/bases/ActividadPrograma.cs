using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace onboarding.data.bases;

// TODO: Agregar las respectivas enums para los campos que lo requieran según la configuración de la tabla

/// <summary>
/// Tabla que almacena las actividades de la plantilla del programa de onboarding
/// obd.acp_actividades_programa
/// </summary>
public partial class ActividadPrograma
{
    /// <summary>
    /// Código de registro de la actividad de la plantilla para programa de onboarding
    /// </summary>
    public int Codigo { get; set; } // acp_codigo (Primary key)

    /// <summary>
    /// Código de la plantilla de programa de onboarding
    /// </summary>
    public int ContratacionProgramaCodigo { get; set; } // acp_codcpr

    /// <summary>
    /// Nombre de la actividad
    /// </summary>
    public string Nombre { get; set; } // acp_nombre

    /// <summary>
    /// Descripción de la actividad
    /// </summary>
    public string Descripcion { get; set; } // acp_descripcion

    /// <summary>
    /// Objetivo de la actividad
    /// </summary>
    public string Objetivo { get; set; } // acp_objetivo

    /// <summary>
    /// Código de Etapa o Fase del programa
    /// </summary>
    public int EtapaProgramaCodigo { get; set; } // acp_codetp

    /// <summary>
    /// Código de Tipo de Actividad
    /// </summary>
    public int TipoActividadCodigo { get; set; } // acp_codtac

    /// <summary>
    /// Código de empleo responsable de la evaluación
    /// </summary>
    public int? EmpleoResponsableCodigo { get; set; } // acp_codemp_responsable

    /// <summary>
    /// Fecha calculada de inicio de la actividad
    /// </summary>
    public DateTime FechaInicio { get; set; } // acp_fecha_inicio

    /// <summary>
    /// Fecha calculada de infalización de la actividad
    /// </summary>
    public DateTime FechaFin { get; set; } // acp_fecha_fin

    /// <summary>
    /// Duración de la actividad
    /// </summary>
    public int Duracion { get; set; } // acp_duracion

    /// <summary>
    /// Unidad de medida de la duración de la actividad
    /// </summary>
    public string UnidadDuracion { get; set; } // acp_unidad_duracion

    /// <summary>
    /// Código de Prioridad de la actividad
    /// </summary>
    public int PrioridadActividadCodigo { get; set; } // acp_codpri

    /// <summary>
    /// Orden de esta actividad respecto de las mismas que tienen los mismos prerequisitos
    /// </summary>
    public int Orden { get; set; } // acp_orden

    /// <summary>
    /// Código de Tipo de Responsable de la actividad
    /// </summary>
    public int TipoResponsableActividadCodigo { get; set; } // acp_codtra

    /// <summary>
    /// Codigo de Tipo de Evaluación de la activdidad (NULL cuando no requiere evaluación)
    /// </summary>
    public int? TipoEvaluacionCodigo { get; set; } // acp_codtev

    /// <summary>
    /// Fecha de evaluación de la actividad
    /// </summary>
    public DateTime? FechaEvaluacion { get; set; } // acp_fecha_evaluacion

    /// <summary>
    /// Nota de la evaluación dada por el responsable de la actividad
    /// </summary>
    public decimal? NotaEvaluacion { get; set; } // acp_nota_evaluacion

    /// <summary>
    /// Determina si la evaluación fue aprobada o no
    /// </summary>
    public string ResultadoEvaluacion { get; set; } // acp_resultado_evaluacion

    /// <summary>
    /// Código de la data del formulario dinámico (cuando está definido según el tipo de evaluación)
    /// </summary>
    public int? FormularioDinamicoDataCodigo { get; set; } // acp_codfdd

    /// <summary>
    /// Estado de la actividad (Pendiente, En Proceso, Finalizada)
    /// </summary>
    public string Estado { get; set; } // acp_estado

    /// <summary>
    /// Fecha de finalización de la actividad (fecha en el estado cambio a finalizada)
    /// </summary>
    public DateTime? FechaFinalizacion { get; set; } // acp_fecha_finalizacion

    /// <summary>
    /// Comentarios de evaluador o quien finaliza la actividad
    /// </summary>
    public string ComentarioFinalizacion { get; set; } // acp_comentario_finalizacion

    /// <summary>
    /// Data de los campos adicionales
    /// </summary>
    public string RawPropertyBagData { get; set; } // acp_property_bag_data

    /// <summary>
    /// Usuario que creo el registro
    /// </summary>
    public string UsuarioGrabacion { get; set; } // acp_usuario_grabacion

    /// <summary>
    /// Fecha en que se creo el registro
    /// </summary>
    public DateTime? FechaGrabacion { get; set; } // acp_fecha_grabacion

    /// <summary>
    /// Usuario que modificó por última vez el registro
    /// </summary>
    public string UsuarioModificacion { get; set; } // acp_usuario_modificacion

    /// <summary>
    /// Fecha de la última modificacion del registro
    /// </summary>
    public DateTime? FechaModificacion { get; set; } // acp_fecha_modificacion

    // Foreing keys

    /// <summary>
    /// Parent ContratacionPrograma pointed by [acp_actividades_programa].([ContratacionProgramaCodigo]) (FK_obdcpr_obdacp)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual ContratacionPrograma ContratacionPrograma { get; set; } // FK_obdcpr_obdacp

    /// <summary>
    /// Parent EtapaPrograma pointed by [acp_actividades_programa].([EtapaProgramaCodigo]) (FK_obdetp_obdacp)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual EtapaPrograma EtapaPrograma { get; set; } // FK_obdetp_obdacp

    /// <summary>
    /// Parent PrioridadActividad pointed by [acp_actividades_programa].([PrioridadActividadCodigo]) (FK_obdpri_obdacp)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual PrioridadActividad PrioridadActividad { get; set; } // FK_obdpri_obdacp

    /// <summary>
    /// Parent TipoActividad pointed by [acp_actividades_programa].([TipoActividadCodigo]) (FK_obdtac_obdacp)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual TipoActividad TipoActividad { get; set; } // FK_obdtac_obdacp

    /// <summary>
    /// Parent TipoEvaluacion pointed by [acp_actividades_programa].([TipoEvaluacionCodigo]) (FK_obdtev_obdacp)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual TipoEvaluacion? TipoEvaluacion { get; set; } // FK_obdte_obdacp

    /// <summary>
    /// Parent TipoResponsableActividad pointed by [acp_actividades_programa].([TipoResponsableActividadCodigo]) (FK_obdtra_obdacp)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual TipoResponsableActividad TipoResponsableActividad { get; set; } // FK_obdtra_obdacp

    // Children collections

    /// <summary>
    /// Child Notificaciones where [nap_notif_actividad_programa].[nap_codacp] point to this entity (FK_obdacp_obdnap)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual ICollection<NotificacionActividadPrograma> Notificaciones { get; set; } = new List<NotificacionActividadPrograma>();

    /// <summary>
    /// Child ActividadesPrerequisitos (Many-to-Many) mapped by table [rap_req_actividades_programa]
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual ICollection<RequisitoActividadPrograma> ActividadesPrerequisitos { get; set; } = new List<RequisitoActividadPrograma>();
}
