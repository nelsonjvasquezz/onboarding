using System;
using System.Collections.Generic;

namespace onboarding.data.bases;

public partial class PnaPlantNotificacionAct
{
    /// <summary>
    /// Código de registro de notificaciones de la actividad de la plantilla
    /// </summary>
    public int PnaCodigo { get; set; }

    /// <summary>
    /// Código de Actividad de la plantilla de programas de onboarding
    /// </summary>
    public int PnaCodpac { get; set; }

    /// <summary>
    /// Determina cual desplazamiento utiliza, si el de fecha inicio o fecha fin
    /// </summary>
    public bool PnaUsaFechaInicio { get; set; }

    /// <summary>
    /// Desplamiento en dias antes o despues de la fecha de inicio 
    /// </summary>
    public int PnaOffsetInicio { get; set; }

    /// <summary>
    /// Desplamiento en dias antes o despues de la fecha de finalizacion
    /// </summary>
    public int PnaOffsetFin { get; set; }

    /// <summary>
    /// Asunto de la notificación
    /// </summary>
    public string PnaSubject { get; set; } = null!;

    /// <summary>
    /// Cuerpo Markdown de la notificación
    /// </summary>
    public string PnaBody { get; set; } = null!;

    /// <summary>
    /// Determina si la notificación se envía al empleado contratado
    /// </summary>
    public bool PnaEnviaContratado { get; set; }

    /// <summary>
    /// Determina si la notificación se envía al jefe inmediato superior del empleado
    /// </summary>
    public bool PnaEnviaJefe { get; set; }

    /// <summary>
    /// Determina si la notificación se envía al responsable de la actividad
    /// </summary>
    public bool PnaEnviaResponsable { get; set; }

    /// <summary>
    /// Data de los campos adicionales
    /// </summary>
    public string? PnaPropertyBagData { get; set; }

    /// <summary>
    /// Usuario que creo el registro
    /// </summary>
    public string? PnaUsuarioGrabacion { get; set; }

    /// <summary>
    /// Fecha en que se creo el registro
    /// </summary>
    public DateTime? PnaFechaGrabacion { get; set; }

    /// <summary>
    /// Usuario que modificó por última vez el registro
    /// </summary>
    public string? PnaUsuarioModificacion { get; set; }

    /// <summary>
    /// Fecha de la última modificacion del registro
    /// </summary>
    public DateTime? PnaFechaModificacion { get; set; }

    public virtual PacPlantActividade PnaCodpacNavigation { get; set; } = null!;
}
