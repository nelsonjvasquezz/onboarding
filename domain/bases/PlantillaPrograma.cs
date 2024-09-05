using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace onboarding.data.bases;

/// <summary>
/// Tabla que almacena la plantilla para los programas de onboarding
/// obd.ppr_plant_programa
/// </summary>
public partial class PlantillaPrograma
{
    /// <summary>
    /// Código de plantilla de programa de onboarding
    /// </summary>
    public int Codigo { get; set; } // ppr_codigo

    /// <summary>
    /// Código de Grupo Corporativo
    /// </summary>
    public int GrupoCorporativoCodigo { get; set; } // ppr_codgrc

    /// <summary>
    /// Nombre del programa de onboarding
    /// </summary>
    public string Nombre { get; set; } // ppr_nombre

    /// <summary>
    /// Descripción del programa de onboarding
    /// </summary>
    public string Descripcion { get; set; } // ppr_descripcion

    /// <summary>
    /// Objetivos del programa de onboarding
    /// </summary>
    public string Objetivo { get; set; } // ppr_objetivo

    /// <summary>
    /// Estado de la plantilla 'Activa' o 'Inactiva'  (inactivas para fines de guardar históricos y que no aparezcan en la selección)
    /// </summary>
    public string Estado { get; set; } // ppr_estado

    /// <summary>
    /// Duración estimada del programa
    /// </summary>
    public int DuracionEstimada { get; set; } // ppr_duracion_estimada

    /// <summary>
    /// Unidad de medida de la duración estimada del programa
    /// </summary>
    public string UnidadDuracion { get; set; } // ppr_unidad_duracion

    /// <summary>
    /// Data de los campos adicionales
    /// </summary>
    public string RawPropertyBagData { get; set; } // ppr_property_bag_data

    /// <summary>
    /// Usuario que creo el registro
    /// </summary>
    public string UsuarioGrabacion { get; set; } // ppr_usuario_grabacion

    /// <summary>
    /// Fecha en que se creo el registro
    /// </summary>
    public DateTime? FechaGrabacion { get; set; } // ppr_fecha_grabacion

    /// <summary>
    /// Usuario que modificó por última vez el registro
    /// </summary>
    public string UsuarioUltimaModificacion { get; set; } // ppr_usuario_modificacion

    /// <summary>
    /// Fecha de la última modificacion del registro
    /// </summary>
    public DateTime? FechaUltimaModificacion { get; set; } // ppr_fecha_modificacion

    // Children collections

    /// <summary>
    /// Child ActividadesPlantilla where [pac_plant_actividades].[pac_codppr] point to this entity (FK_obdppr_obdpac)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual ICollection<ActividadPlantilla> ActividadesPlantilla { get; set; } = new List<ActividadPlantilla>(); // FK_obdppr_obdpac

    /// <summary>
    /// Child Alcances where [pal_plant_alcances].[pal_codppr] point to this entity (FK_obdppr_obdpap)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual ICollection<AlcancePlantilla> Alcances { get; set; } = new List<AlcancePlantilla>(); // FK_obdppr_obdpap

    /// <summary>
    /// Child Programas where [pro_programas].[pro_codppr] point to this entity (FK_obdppr_obdpro)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual ICollection<Programa> Programas { get; set; } = new List<Programa>(); // FK_obdppr_obdpro
}