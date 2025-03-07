﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace onboarding.data.bases;

/// <summary>
/// Tabla que almacena las actividades de los participantes de un programa de onboarding
/// obd.acp_actividades_prg
/// </summary>
public partial class ActividadPrograma
{
    /// <summary>
    /// Código de registro de la actividad de un participante para un programa de onboarding
    /// </summary>
    public int Codigo { get; set; } // acp_codigo (Primary key)

    /// <summary>
    /// Código del participante de un programa de onboarding
    /// </summary>
    public int ParticipanteProgramaCodigo { get; set; } // acp_codpap

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
    public int EtapaActividadCodigo { get; set; } // acp_codetp

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
    /// Fecha calculada de finalización de la actividad
    /// </summary>
    public DateTime FechaFin { get; set; } // acp_fecha_fin

    /// <summary>
    /// Duración de la actividad
    /// </summary>
    public int Duracion { get; set; } // acp_duracion

    /// <summary>
    /// Unidad de medida de la duración de la actividad
    /// </summary>
    public string UnidadDuracionDb { get; set; } // acp_unidad_duracion

    /// <summary>
    /// Código de Prioridad de la actividad
    /// </summary>
    public int PrioridadActividadCodigo { get; set; } // acp_codpri

    /// <summary>
    /// Orden de esta actividad respecto de las mismas que tienen los mismos requisitos
    /// </summary>
    public int Orden { get; set; } // acp_orden

    /// <summary>
    /// Código de Tipo de Responsable de la actividad
    /// </summary>
    public int TipoResponsableActividadCodigo { get; set; } // acp_codtra

    /// <summary>
    /// Codigo de Tipo de Evaluación de la actividad (NULL cuando no requiere evaluación)
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
    public string ResultadoEvaluacionDb { get; set; } // acp_resultado_evaluacion

    /// <summary>
    /// Código de la data del formulario dinámico (cuando está definido según el tipo de evaluación)
    /// </summary>
    public int? FormularioDinamicoDataCodigo { get; set; } // acp_codfdd

    /// <summary>
    /// Estado de la actividad (Pendiente, En Proceso, Finalizada)
    /// </summary>
    public string EstadoDb { get; set; } // acp_estado

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
    public string UsuarioUltimaModificacion { get; set; } // acp_usuario_modificacion

    /// <summary>
    /// Fecha de la última modificacion del registro
    /// </summary>
    public DateTime? FechaUltimaModificacion { get; set; } // acp_fecha_modificacion

    // Foreing keys

    /// <summary>
    /// Parent ParticipantePrograma pointed by [acp_actividades_prg].([ParticipanteProgramaCodigo]) (FK_obdpap_obdacp)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual ParticipantePrograma Participante { get; set; } // FK_obdpap_obdacp

    /// <summary>
    /// Parent EtapaActividad pointed by [acp_actividades_prg].([EtapaActividadCodigo]) (FK_obdetp_obdacp)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual EtapaActividad Etapa { get; set; } // FK_obdetp_obdacp

    /// <summary>
    /// Parent PrioridadActividad pointed by [acp_actividades_prg].([PrioridadActividadCodigo]) (FK_obdpri_obdacp)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual PrioridadActividad Prioridad { get; set; } // FK_obdpri_obdacp

    /// <summary>
    /// Parent TipoActividad pointed by [acp_actividades_prg].([TipoActividadCodigo]) (FK_obdtac_obdacp)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual TipoActividad Tipo { get; set; } // FK_obdtac_obdacp

    /// <summary>
    /// Parent TipoEvaluacion pointed by [acp_actividades_prg].([TipoEvaluacionCodigo]) (FK_obdtev_obdacp)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual TipoEvaluacion TipoEvaluacion { get; set; } // FK_obdtev_obdacp

    /// <summary>
    /// Parent TipoResponsableActividad pointed by [acp_actividades_prg].([TipoResponsableActividadCodigo]) (FK_obdtra_obdacp)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual TipoResponsableActividad TipoResponsable { get; set; } // FK_obdtra_obdacp

    // Children collections

    /// <summary>
    /// Child Notificaciones where [nap_notif_actividad_prg].[nap_codacp] point to this entity (FK_obdacp_obdnap)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual ICollection<NotificacionActividad> Notificaciones { get; set; } = new List<NotificacionActividad>();

    /// <summary>
    /// Child Requisitos (Many-to-Many) mapped by table [rap_req_actividades_prg]
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual ICollection<RequisitoActividad> Requisitos { get; set; } = new List<RequisitoActividad>();
}
