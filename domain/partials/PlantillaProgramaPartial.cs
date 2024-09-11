using onboarding.enums;
using onboarding.extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace onboarding.data.bases;
public partial class PlantillaPrograma
{
    // EntitySetName

    /// <summary>
    /// Nombre de la entidad
    /// </summary>
    public string EntitySetName { get; } = "PlantillasPrograma";

    // FileAttachments

    /// <summary>
    /// Contiene la información cruda del XML que contiene las referencias a los file uploads que se han hecho
    /// </summary>
    [NotMapped]
    public List<Guid> FileAttachments { get; set; }

    // Otras Propiedades

    /// <summary>
    /// Estado de la Plantilla
    /// </summary>
    [NotMapped]
    public EstadoPlantilla Estado
    {
        get => EstadoDb.EnumParse<EstadoPlantilla>();
        set => EstadoDb = value.ToString();
    }

    /// <summary>
    /// Unidad de medida del tiempo de la duración estimada del programa
    /// </summary>
    [NotMapped]
    public UnidadTiempo UnidadDuracion
    {
        get => UnidadDuracionDb.EnumParse<UnidadTiempo>();
        set => UnidadDuracionDb = value.ToString();
    }
}
