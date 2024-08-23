using System;
using System.Collections.Generic;

namespace onboarding.data.bases;

/// <summary>
/// Tabla que almacena los evento que son notificables para el seguimiento de los programas de onboarding
/// </summary>
public partial class EventoNotificable
{
    /// <summary>
    /// Código de evento notificable
    /// </summary>
    public int Codigo { get; set; }

    /// <summary>
    /// Código de Grupo Corporativo
    /// </summary>
    public int GrupoCorporativoCodigo { get; set; }

    /// <summary>
    /// Nombre del Evento
    /// </summary>
    public string Nombre { get; set; } = null!;

    /// <summary>
    /// Descripción del Evento que se puede notificar
    /// </summary>
    public string Descripcion { get; set; } = null!;

    /// <summary>
    /// Data de los campos adicionales
    /// </summary>
    public string? PropertyBagData { get; set; }

    /// <summary>
    /// Usuario que creo el registro
    /// </summary>
    public string? UsuarioGrabacion { get; set; }

    /// <summary>
    /// Fecha en que se creo el registro
    /// </summary>
    public DateTime? FechaGrabacion { get; set; }

    /// <summary>
    /// Usuario que modificó por última vez el registro
    /// </summary>
    public string? UsuarioModificacion { get; set; }

    /// <summary>
    /// Fecha de la última modificacion del registro
    /// </summary>
    public DateTime? FechaModificacion { get; set; }

    public virtual ICollection<NotificacionActividadPrograma> NotifActividadProgramas { get; set; } = new List<NotificacionActividadPrograma>();
}
