using System;
using System.Collections.Generic;

namespace onboarding.data.bases;

/// <summary>
/// Tabla que almacena los registros de la notificación de la actividad de la plantilla
/// obd.pna_plant_notificacion_act
/// </summary>
public partial class PlantillaNotificacionActividad
{
    /// <summary>
    /// Código de registro de notificaciones de la actividad de la plantilla
    /// </summary>
    public int Codigo { get; set; }

    /// <summary>
    /// Código de Actividad de la plantilla de programas de onboarding
    /// </summary>
    public int PlantillaActividadCodigo { get; set; }

    /// <summary>
    /// Determina cual desplazamiento utiliza, si el de fecha inicio o fecha fin
    /// </summary>
    public bool UsaFechaInicio { get; set; }

    /// <summary>
    /// Desplamiento en dias antes o despues de la fecha de inicio 
    /// </summary>
    public int OffsetInicio { get; set; }

    /// <summary>
    /// Desplamiento en dias antes o despues de la fecha de finalizacion
    /// </summary>
    public int OffsetFin { get; set; }

    /// <summary>
    /// Asunto de la notificación
    /// </summary>
    public string Subject { get; set; } = null;

    /// <summary>
    /// Cuerpo Markdown de la notificación
    /// </summary>
    public string Body { get; set; } = null;

    /// <summary>
    /// Determina si la notificación se envía al empleado contratado
    /// </summary>
    public bool EnviaContratado { get; set; }

    /// <summary>
    /// Determina si la notificación se envía al jefe inmediato superior del empleado
    /// </summary>
    public bool EnviaJefe { get; set; }

    /// <summary>
    /// Determina si la notificación se envía al responsable de la actividad
    /// </summary>
    public bool EnviaResponsable { get; set; }

    /// <summary>
    /// Data de los campos adicionales
    /// </summary>
    public string RawPropertyBagData { get; set; }

    /// <summary>
    /// Usuario que creo el registro
    /// </summary>
    public string UsuarioGrabacion { get; set; }

    /// <summary>
    /// Fecha en que se creo el registro
    /// </summary>
    public DateTime? FechaGrabacion { get; set; }

    /// <summary>
    /// Usuario que modificó por última vez el registro
    /// </summary>
    public string UsuarioUltimaModificacion { get; set; }

    /// <summary>
    /// Fecha de la última modificacion del registro
    /// </summary>
    public DateTime? FechaUltimaModificacion { get; set; }

    public virtual PlantillaActividad PlantillaActividad { get; set; }
}
