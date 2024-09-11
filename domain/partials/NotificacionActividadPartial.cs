using onboarding.enums;
using onboarding.extensions;
using System.ComponentModel.DataAnnotations.Schema;

namespace onboarding.data.bases;
public partial class NotificacionActividad
{
    // EntitySetName
    /// <summary>
    /// Nombre de la entidad
    /// </summary>
    public string EntitySetName { get; } = "NotificacionesActividad";

    // Otras propiedades

    /// <summary>
    /// Tipo de destinatario de la notificacion
    /// </summary>
    [NotMapped]
    public TipoDestinatarioNotificacionActividad TipoDestinatario
    {
        get => TipoDestinatarioDb.EnumParse<TipoDestinatarioNotificacionActividad>();
        set => TipoDestinatarioDb = value.ToString();
    }

    /// <summary>
    /// Estado de la notificacion
    /// </summary>
    [NotMapped]
    public EstadoNotificacionActividad? Estado
    {
        get => string.IsNullOrWhiteSpace(EstadoDb) ? null : EstadoDb.EnumParse<EstadoNotificacionActividad>();
        set => EstadoDb = value?.ToString();
    }
}
