using System;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace onboarding.data.bases;

/// <summary>
/// Tabla que almacena los registros de las notificaciones generadas de la actividad del programa
/// obd.nap_notif_actividad_prg
/// </summary>
public partial class NotificacionActividad
{
    /// <summary>
    /// Código del registro de la notificación de la actividad del programa
    /// </summary>
    public int Codigo { get; set; } // nap_codigo

    /// <summary>
    /// Código de la Actividad
    /// </summary>
    public int ActividadProgramaCodigo { get; set; } // nap_codacp

    /// <summary>
    /// Código de Evento Notificable
    /// </summary>
    public int EventoNotificableCodigo { get; set; } // nap_codeno

    /// <summary>
    /// Desplazamiento en días de la fecha en que ocurre el evento para el envio de la notificación
    /// </summary>
    public int OffsetDias { get; set; } // nap_offset_dias

    /// <summary>
    /// Destinatario de la notificación: Participante | JefeInmediato | ResponsableActividad | ResponsableRRHH
    /// </summary>
    public string TipoDestinatarioDb { get; set; } = null; // nap_tipo_destinatario

    /// <summary>
    /// Código del empleo del destinatario, puede ser NULL cuando el empleado nuevo no ha sido contratado
    /// </summary>
    public int? EmpleoDestinatarioCodigo {get; set;} // nap_codemp_destinatario

    /// <summary>
    /// Código del expediente del destinatario
    /// </summary>
    public int ExpedienteDestinatarioCodigo {get; set;} // nap_codexp_destinatario

    /// <summary>
    /// Lista de correos electrónicos separadas por comas
    /// </summary>
    public string EmailsDestinatario {get; set;} // nap_emails_destinatario

    /// <summary>
    /// Lista de ids de onesignal separadas por comas
    /// </summary>
    public string OneSignalIdsDestinatario {get; set;} // nap_onesignal_ids_destinatario

    /// <summary>
    /// Asunto de la notificación
    /// </summary>
    public string Subject { get; set; } // nap_subject

    /// <summary>
    /// Cuerpo Markdown de la notificación
    /// </summary>
    public string Body { get; set; } // nap_body

    /// <summary>
    /// Fecha en que sucedió el evento notificable (está null mientras no se ha dado)
    /// </summary>
    public DateTime? FechaEvento { get; set; } // nap_fecha_evento

    /// <summary>
    /// Fecha y hora de cuando se notificó
    /// </summary>
    public DateTime? FechaNotificacion { get; set; } // nap_fecha_notificacion

    /// <summary>
    /// Estado de la notificación (NULL | 'Pendiente' | 'Enviada' | 'Error')
    /// </summary>
    public string EstadoDb { get; set; } // nap_estado

    /// <summary>
    /// Mensaje o excepción cuando el estado es 'Error'
    /// </summary>
    public string MensajeError { get; set; } // nap_mensaje_error

    // Foreign keys

    /// <summary>
    /// Parent Actividad pointed by [nap_notif_actividad_prg].[(ActividadProgramaCodigo)] (FK_obdacp_obdnap)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual ActividadPrograma Actividad { get; set; } // FK_obdacp_obdnap

    /// <summary>
    /// Parent EventoNotificable pointed by [nap_notif_actividad_prg].[(EventoNotificableCodigo)] (FK_obdeno_obdnap)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual EventoNotificable EventoNotificable { get; set; } // FK_obdeno_obdnap
}