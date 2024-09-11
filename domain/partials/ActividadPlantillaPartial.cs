using onboarding.enums;
using onboarding.extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace onboarding.data.bases;

public partial class ActividadPlantilla
{
    // EntitySetName

    /// <summary>
    /// Nombre de la entidad
    /// </summary>
    public string EntitySetName { get; } = "ActividadesPlantilla";

    // FileAttachments

    /// <summary>
    /// Contiene la información cruda del XML que contiene las referencias a los file uploads que se han hecho
    /// </summary>
    [NotMapped]
    public List<Guid> FileAttachments { get; set; }

    // Otras propiedades

    /// <summary>
    /// Unidad de medida del tiempo del desplazamiento
    /// </summary>
    [NotMapped]
    public UnidadTiempo UnidadOffsetInicio
    {
        get => UnidadOffsetInicioDb.EnumParse<UnidadTiempo>();
        set => UnidadOffsetInicioDb = value.ToString();
    }

    /// <summary>
    /// Unidad de medida del tiempo de la duración estimada de la actividad
    /// </summary>
    [NotMapped]
    public UnidadTiempo UnidadDuracion
    {
        get => UnidadDuracionDb.EnumParse<UnidadTiempo>();
        set => UnidadDuracionDb = value.ToString();
    }
}
