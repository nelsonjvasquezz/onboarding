using System;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace onboarding.data.bases;

/// <summary>
/// Tabla que almacena las configuraciones de las notificaciones para las actividades de la plantilla
/// obd.pna_plant_notificacion_act
/// </summary>
public partial class NotificacionActividadPlantilla
{
    /// <summary>
    /// Código de la configuración de las notificaciones de la actividad de la plantilla
    /// </summary>
    public int Codigo { get; set; } // pna_codigo

    /// <summary>
    /// Código de Evento Notificable
    /// </summary>
    public int EventoNotificableCodigo { get; set; } // pna_codeno

    /// <summary>
    /// Código de Actividad de la plantilla de programas de onboarding
    /// </summary>
    public int ActividadPlantillaCodigo { get; set; } // pna_codpac

    /// <summary>
    /// Determina que se utiliza el desplazamiento de fecha inicio
    /// </summary>
    public bool UsaFechaInicio { get; set; } // pna_usa_fecha_inicio

    /// <summary>
    /// Desplamiento en dias antes o despues de la fecha de inicio 
    /// </summary>
    public int? OffsetInicio { get; set; } // pna_offset_inicio

    /// <summary>
    /// Desplamiento en dias antes o despues de la fecha de finalizacion
    /// </summary>
    public int? OffsetFin { get; set; } // pna_offset_fin

    /// <summary>
    /// Asunto de la notificación
    /// </summary>
    public string Subject { get; set; } = null; // pna_subject

    /// <summary>
    /// Cuerpo Markdown de la notificación
    /// </summary>
    public string Body { get; set; } = null; // pna_body

    /// <summary>
    /// Determina si la notificación se envía al empleado contratado
    /// </summary>
    public bool EnviaContratado { get; set; } // pna_envia_contratado

    /// <summary>
    /// Determina si la notificación se envía al jefe inmediato superior del empleado
    /// </summary>
    public bool EnviaJefe { get; set; } // pna_envia_jefe

    /// <summary>
    /// Determina si la notificación se envía al responsable de la actividad
    /// </summary>
    public bool EnviaResponsable { get; set; } // pna_envia_responsable

    /// <summary>
    /// Data de los campos adicionales
    /// </summary>
    public string RawPropertyBagData { get; set; } // pna_property_bag_data

    /// <summary>
    /// Usuario que creo el registro
    /// </summary>
    public string UsuarioGrabacion { get; set; } // pna_usuario_grabacion

    /// <summary>
    /// Fecha en que se creo el registro
    /// </summary>
    public DateTime? FechaGrabacion { get; set; } // pna_fecha_grabacion

    /// <summary>
    /// Usuario que modificó por última vez el registro
    /// </summary>
    public string UsuarioUltimaModificacion { get; set; } // pna_usuario_modificacion

    /// <summary>
    /// Fecha de la última modificacion del registro
    /// </summary>
    public DateTime? FechaUltimaModificacion { get; set; } // pna_fecha_modificacion

    // Foreign keys

    /// <summary>
    /// Parent Actividad pointed by [pna_plant_notificacion].([ActividadPlantillaCodigo]) (FK_obdpac_obdpna)
    /// </summary>
    public virtual ActividadPlantilla Actividad { get; set; } // FK_obdpac_obdpna

    /// <summary>
    /// Parent EventoNotificable pointed by [pna_plant_notificacion_act].[(EventoNotificableCodigo)] (FK_obdeno_obdpna)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual EventoNotificable EventoNotificable { get; set; } // FK_obdeno_obdpna
}
