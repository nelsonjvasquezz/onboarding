using System;
using System.Collections.Generic;

namespace onboarding.data.bases;

/// <summary>
/// Tabla que almacena los evento que son notificables para el seguimiento de los programas de onboarding
/// </summary>
public partial class EnoEventosNotificable
{
    /// <summary>
    /// Código de evento notificable
    /// </summary>
    public int EnoCodigo { get; set; }

    /// <summary>
    /// Código de Grupo Corporativo
    /// </summary>
    public int EnoCodgrc { get; set; }

    /// <summary>
    /// Nombre del Evento
    /// </summary>
    public string EnoNombre { get; set; } = null!;

    /// <summary>
    /// Descripción del Evento que se puede notificar
    /// </summary>
    public string EnoDescripcion { get; set; } = null!;

    /// <summary>
    /// Data de los campos adicionales
    /// </summary>
    public string? EnoPropertyBagData { get; set; }

    /// <summary>
    /// Usuario que creo el registro
    /// </summary>
    public string? EnoUsuarioGrabacion { get; set; }

    /// <summary>
    /// Fecha en que se creo el registro
    /// </summary>
    public DateTime? EnoFechaGrabacion { get; set; }

    /// <summary>
    /// Usuario que modificó por última vez el registro
    /// </summary>
    public string? EnoUsuarioModificacion { get; set; }

    /// <summary>
    /// Fecha de la última modificacion del registro
    /// </summary>
    public DateTime? EnoFechaModificacion { get; set; }

    public virtual ICollection<NapNotifActividadPrograma> NapNotifActividadProgramas { get; set; } = new List<NapNotifActividadPrograma>();
}
