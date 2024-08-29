using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace onboarding.data.bases;

/// <summary>
/// Tabla que almacena los evento que son notificables para el seguimiento de los programas de onboarding
/// obd.eno_eventos_notificables
/// </summary>
public partial class EventoNotificable
{
    /// <summary>
    /// Código de evento notificable
    /// </summary>
    public int Codigo { get; set; } // eno_codigo

    /// <summary>
    /// Código de Grupo Corporativo
    /// </summary>
    public int GrupoCorporativoCodigo { get; set; } // eno_codgrc

    /// <summary>
    /// Nombre del Evento
    /// </summary>
    public string Nombre { get; set; } // eno_nombre

    /// <summary>
    /// Descripción del Evento que se puede notificar
    /// </summary>
    public string Descripcion { get; set; } // eno_descripcion

    /// <summary>
    /// Data de los campos adicionales
    /// </summary>
    public string RawPropertyBagData { get; set; } // eno_property_bag_data

    /// <summary>
    /// Usuario que creo el registro
    /// </summary>
    public string UsuarioGrabacion { get; set; } // eno_usuario_grabacion

    /// <summary>
    /// Fecha en que se creo el registro
    /// </summary>
    public DateTime? FechaGrabacion { get; set; } // eno_fecha_grabacion

    /// <summary>
    /// Usuario que modificó por última vez el registro
    /// </summary>
    public string UsuarioUltimaModificacion { get; set; } // eno_usuario_modificacion

    /// <summary>
    /// Fecha de la última modificacion del registro
    /// </summary>
    public DateTime? FechaUltimaModificacion { get; set; } // eno_fecha_modificacion

    // Children collections

    /// <summary>
    /// Child NotificacionesDeActividades where [nap_notif_actividad_programa].[nap_codeno] point to this entity (FK_obdeno_obdnap)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual ICollection<NotificacionActividadPrograma> NotificacionesDeActividades { get; set; } = new List<NotificacionActividadPrograma>(); // FK_obdeno_obdnap
}