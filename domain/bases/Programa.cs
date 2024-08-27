using System;
using System.Collections.Generic;

namespace onboarding.data.bases;

/// <summary>
/// Tabla que almacena los programas de onboarding
/// obd.pro_programas
/// </summary>
public partial class Programa
{
    /// <summary>
    /// Código de programa de onboarding
    /// </summary>
    public int Codigo { get; set; } // pro_codigo

    /// <summary>
    /// Código de plantilla programa
    /// </summary>
    public int PlantillaProgramaCodigo { get; set; } // pro_codppr

    /// <summary>
    /// Nombre del programa de onboarding
    /// </summary>
    public string Nombre { get; set; } // pro_nombre

    /// <summary>
    /// Descripción del programa de onboarding
    /// </summary>
    public string Descripcion { get; set; } // pro_descripcion

    /// <summary>
    /// Objetivos del programa de onboarding
    /// </summary>
    public string Objetivo { get; set; } // pro_objetivo

    /// <summary>
    /// Estado del programa 'Planificado' o 'En Ejecución' o 'Finalizado'
    /// </summary>
    public string Estado { get; set; } // pro_estado

    /// <summary>
    /// Duración estimada del programa
    /// </summary>
    public int Duracion { get; set; } // pro_duracion

    /// <summary>
    /// Unidad de medida de la duración estimada del programa
    /// </summary>
    public string UnidadDuracion { get; set; } // pro_unidad_duracion

    /// <summary>
    /// Data de los campos adicionales
    /// </summary>
    public string RawPropertyBagData { get; set; } // pro_property_bag_data

    /// <summary>
    /// Usuario que creo el registro
    /// </summary>
    public string UsuarioGrabacion { get; set; } // pro_usuario_grabacion

    /// <summary>
    /// Fecha en que se creo el registro
    /// </summary>
    public DateTime? FechaGrabacion { get; set; } // pro_fecha_grabacion

    /// <summary>
    /// Usuario que modificó por última vez el registro
    /// </summary>
    public string UsuarioModificacion { get; set; } // pro_usuario_modificacion

    /// <summary>
    /// Fecha de la última modificacion del registro
    /// </summary>
    public DateTime? FechaModificacion { get; set; } // pro_fecha_modificacion

    // Foreign keys

    /// <summary>
    /// Parent PlantillaPrograma pointed by [pro_programas].([pro_codppr]) (FK_obdppr_obdpro)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual PlantillaPrograma PlantillaPrograma { get; set; } // FK_obdppr_obdpro

    // Children collections

    /// <summary>
    /// Child Contrataciones where [cpr_contrataciones_programa].[cpr_codpro] point to this entity (FK_obdpro_obdcpr)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual ICollection<ContratacionPrograma> Contrataciones { get; set; } = new List<ContratacionPrograma>(); // FK_obdpro_obdcpr

}