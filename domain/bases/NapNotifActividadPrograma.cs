using System;
using System.Collections.Generic;

namespace onboarding.data.bases;

public partial class NapNotifActividadPrograma
{
    /// <summary>
    /// Código de registro de la configuración de notificaciones de la actividad del programa
    /// </summary>
    public int NapCodigo { get; set; }

    /// <summary>
    /// Código de la Actividad
    /// </summary>
    public int NapCodacp { get; set; }

    /// <summary>
    /// Tipo de Evento Notificable
    /// </summary>
    public int NapCodeno { get; set; }

    /// <summary>
    /// Desplazamiento en días de la fecha en que ocurre el evento para el envio de la notificación
    /// </summary>
    public int NapOffsetDias { get; set; }

    /// <summary>
    /// Destinatario de la notificación: Contratado | JefeInmediato | ResponsableActividad | ResponsableRRHH
    /// </summary>
    public string NapTipoDestinatario { get; set; } = null!;

    /// <summary>
    /// Asunto de la notificación
    /// </summary>
    public string? NapSubject { get; set; }

    /// <summary>
    /// Cuerpo Markdown de la notificación
    /// </summary>
    public string? NapBody { get; set; }

    /// <summary>
    /// Fecha en que sucedió el evento notificable (está null mientras no se ha dado)
    /// </summary>
    public DateTime? NapFechaEvento { get; set; }

    /// <summary>
    /// Fecha y hora de cuando se notificó
    /// </summary>
    public DateTime? NapFechaNotificacion { get; set; }

    /// <summary>
    /// Estado de la notificación (NULL | &apos;Pendiente&apos; | &apos;Enviada&apos; | &apos;Error&apos;)
    /// </summary>
    public string? NapEstado { get; set; }

    /// <summary>
    /// Mensaje o excepción cuando el estado es &apos;Error&apos;
    /// </summary>
    public string? NapMensajeError { get; set; }

    public virtual ActividadesPrograma NapCodacpNavigation { get; set; } = null!;

    public virtual EnoEventosNotificable NapCodenoNavigation { get; set; } = null!;
}
