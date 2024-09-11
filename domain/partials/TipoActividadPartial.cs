using onboarding.enums;
using onboarding.extensions;
using System.ComponentModel.DataAnnotations.Schema;

namespace onboarding.data.bases;
public partial class TipoActividad
{
    // EntitySetName

    /// <summary>
    /// Nombre de la entidad
    /// </summary>
    public string EntitySetName { get; } = "TiposActividades";

    // Otras propiedades

    /// <summary>
    /// Unidad de medida del tiempo de la duración estimada
    /// </summary>
    [NotMapped]
    public UnidadTiempo UnidadDuracion
    {
        get => UnidadDuracionDb.EnumParse<UnidadTiempo>();
        set => UnidadDuracionDb = value.ToString();
    }
}
