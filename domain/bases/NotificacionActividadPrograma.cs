using System;

namespace onboarding.data.bases;

/// <summary>
/// Tabla que almacena las configuraciones de las notificaciones de la actividad del programa
/// obd.nap_notif_actividad_programa
/// </summary>
public partial class NotificacionActividadPrograma
{
    /// <summary>
    /// Código de registro de la configuración de notificaciones de la actividad del programa
    /// </summary>
    public int Codigo { get; set; }

    /// <summary>
    /// Código de la Actividad
    /// </summary>
    public int ActividadProgramaCodigo { get; set; }

    /// <summary>
    /// Código de Evento Notificable
    /// </summary>
    public int EventoNotificableCodigo { get; set; }

    /// <summary>
    /// Desplazamiento en días de la fecha en que ocurre el evento para el envio de la notificación
    /// </summary>
    public int OffsetDias { get; set; }

    /// <summary>
    /// Destinatario de la notificación: Contratado | JefeInmediato | ResponsableActividad | ResponsableRRHH
    /// </summary>
    public string TipoDestinatario { get; set; } = null;

    /// <summary>
    /// Asunto de la notificación
    /// </summary>
    public string Subject { get; set; }

    /// <summary>
    /// Cuerpo Markdown de la notificación
    /// </summary>
    public string Body { get; set; }

    /// <summary>
    /// Fecha en que sucedió el evento notificable (está null mientras no se ha dado)
    /// </summary>
    public DateTime? FechaEvento { get; set; }

    /// <summary>
    /// Fecha y hora de cuando se notificó
    /// </summary>
    public DateTime? FechaNotificacion { get; set; }

    /// <summary>
    /// Estado de la notificación (NULL | &apos;Pendiente&apos; | &apos;Enviada&apos; | &apos;Error&apos;)
    /// </summary>
    public string Estado { get; set; }

    /// <summary>
    /// Mensaje o excepción cuando el estado es &apos;Error&apos;
    /// </summary>
    public string MensajeError { get; set; }

    public virtual ActividadPrograma ActividadPrograma { get; set; }

    public virtual EventoNotificable EventoNotificable { get; set; }
}
