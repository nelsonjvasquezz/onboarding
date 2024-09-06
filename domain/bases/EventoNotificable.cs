using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace onboarding.data.bases;

/// <summary>
/// Tabla que almacena los eventos que son notificables para el seguimiento de los programas de onboarding
/// obd.eno_eventos_notificables
/// </summary>
public partial class EventoNotificable
{
    /// <summary>
    /// Código de evento notificable
    /// </summary>
    public int Codigo { get; set; } // eno_codigo

    /// <summary>
    /// Nombre del Evento
    /// </summary>
    public string Nombre { get; set; } // eno_nombre

    /// <summary>
    /// Llave de localización de la descripción del evento que se puede notificar
    /// </summary>
    public string DescripcionLocalizationKey { get; set; } // eno_descripcion_loc_key

    // Children collections

    /// <summary>
    /// Child Notificaciones where [nap_notif_actividad_programa].[nap_codeno] point to this entity (FK_obdeno_obdnap)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual ICollection<NotificacionActividad> Notificaciones { get; set; } = new List<NotificacionActividad>(); // FK_obdeno_obdnap

    /// <summary>
    /// Child NotificacionesPlantilla where [pna_plant_notificacion_act.[pna_codeno] point to this entity (FK_obdeno_obdpna)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual ICollection<NotificacionActividadPlantilla> NotificacionesPlantilla { get; set; } = new List<NotificacionActividadPlantilla>(); // FK_obdeno_obdpna
}