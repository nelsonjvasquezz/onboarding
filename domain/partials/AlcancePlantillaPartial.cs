using onboarding.enums;
using onboarding.extensions;
using System.ComponentModel.DataAnnotations.Schema;

namespace onboarding.data.bases;

public partial class AlcancePlantilla
{
    // EntitySetName

    /// <summary>
    /// Nombre de la entidad
    /// </summary>
    public string EntitySetName { get; } = "AlcancesPlantilla";

    // Otras propiedades

    /// <summary>
    /// Tipo de Alcance
    /// </summary>
    [NotMapped]
    public TipoAlcancePlantilla Tipo
    {
        get => TipoDb.EnumParse<TipoAlcancePlantilla>();
        set => TipoDb = value.ToString();
    }
}
