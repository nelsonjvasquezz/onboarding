using System;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace onboarding.data.bases;

// TODO: Agregar las enums correspondientes según la configuración de tabla de la base de datos

/// <summary>
/// Tabla que almacena el alcance para la Platilla del programa
/// obd.pal_plant_alcances
/// </summary>
public partial class AlcancePlantillaPrograma
{
    /// <summary>
    /// Código de registro de alcance para la plantilla de programa de onboarding
    /// </summary>
    public int Codigo { get; set; } // pal_codigo

    /// <summary>
    /// Código de plantilla de programa de onboarding
    /// </summary>
    public int PlantillaProgramaCodigo { get; set; } // pal_codppr

    /// <summary>
    /// Tipo de Alcance
    /// </summary>
    public string Tipo { get; set; } // pal_tipo

    /// <summary>
    /// Código de Tipo de Puesto
    /// </summary>
    public int? TipoPuestoCodigo { get; set; } // pal_codtpp

    /// <summary>
    /// Código de Puesto
    /// </summary>
    public int? PuestoCodigo { get; set; } // pal_codpue

    /// <summary>
    /// Data de los campos adicionales
    /// </summary>
    public string RawPropertyBagData { get; set; } // pal_property_bag_data

    /// <summary>
    /// Usuario que creo el registro
    /// </summary>
    public string UsuarioGrabacion { get; set; } // pal_usuario_grabacion

    /// <summary>
    /// Fecha en que se creo el registro
    /// </summary>
    public DateTime? FechaGrabacion { get; set; } // pal_fecha_grabacion

    /// <summary>
    /// Usuario que modificó por última vez el registro
    /// </summary>
    public string UsuarioModificacion { get; set; } // pal_usuario_modificacion

    /// <summary>
    /// Fecha de la última modificacion del registro
    /// </summary>
    public DateTime? FechaModificacion { get; set; } // pal_fecha_modificacion

    // Foreing keys

    /// <summary>
    /// Parent PlantillaPrograma pointed by [pal_plant_alcances].([PlantillaProgramaCodigo]) (FK_obdppr_obdpap)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual PlantillaPrograma PlantillaPrograma { get; set; } // FK_obdppr_obdpap
}