namespace onboarding.data.bases;

public partial class NotificacionActividadPlantilla
{
    // EntitySetName

    /// <summary>
    /// Nombre de la entidad
    /// </summary>
    public string EntitySetName { get; } = "NotificacionesActividadesPlantilla";

    // Otras Propiedades

    /// <summary>
    /// Determina que se utiliza el desplazamiento de fecha fin
    /// </summary>
    public bool UsaFechaFin => !UsaFechaInicio;
}
