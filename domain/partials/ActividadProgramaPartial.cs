using onboarding.enums;
using onboarding.extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace onboarding.data.bases;
public partial class ActividadPrograma
{
    // EntitySetName

    /// <summary>
    /// Nombre de la entidad
    /// </summary>
    public string EntitySetName { get; } = "ActividadesPrograma";

    // FileAttachments

    /// <summary>
    /// Contiene la información cruda del XML que contiene las referencias a los file uploads que se han hecho
    /// </summary>
    [NotMapped]
    public List<Guid> FileAttachments { get; set; }

    // Otras propiedades

    /// <summary>
    /// Unidad de medida del tiempo de la duración de la actividad
    /// </summary>
    [NotMapped]
    public UnidadTiempo UnidadDuracion
    {
        get => UnidadDuracionDb.EnumParse<UnidadTiempo>();
        set => UnidadDuracionDb = value.ToString();
    }

    /// <summary>
    /// Estado de la actividad
    /// </summary>
    [NotMapped]
    public EstadoActividad Estado
    {
        get => EstadoDb.EnumParse<EstadoActividad>();
        set => EstadoDb = value.ToString();
    }

    /// <summary>
    /// Resultado de la evaluacion
    /// </summary>
    [NotMapped]
    public ResultadoEvaluacionActividad? ResultadoEvaluacion
    {
        get => string.IsNullOrWhiteSpace(ResultadoEvaluacionDb) ? null : ResultadoEvaluacionDb.EnumParse<ResultadoEvaluacionActividad>();
        set => ResultadoEvaluacionDb = value?.ToString();
    }
}
