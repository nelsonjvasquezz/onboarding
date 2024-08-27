using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace onboarding.data.bases;

/// <summary>
/// Tabla que almacena las actividades de la plantilla del programa de onboarding
/// obd.pac_plant_actividades
/// </summary>
public partial class PlantillaActividad
{
    /// <summary>
    /// Código de registro de la actividad de la plantilla para programa de onboarding
    /// </summary>
    public int Codigo { get; set; } // pac_codigo

    /// <summary>
    /// Código de la plantilla de programa de onboarding
    /// </summary>
    public int PlantillaProgramaCodigo { get; set; } // pac_codppr

    /// <summary>
    /// Nombre de la actividad
    /// </summary>
    public string Nombre { get; set; } // pac_nombre

    /// <summary>
    /// Descripción de la actividad
    /// </summary>
    public string Descripcion { get; set; } // pac_descripcion

    /// <summary>
    /// Objetivo de la actividad
    /// </summary>
    public string Objetivo { get; set; } // pac_objetivo

    /// <summary>
    /// Código de Etapa o Fase del programa
    /// </summary>
    public int EtapaProgramaCodigo { get; set; } // pac_codetp

    /// <summary>
    /// Código de Tipo de Actividad
    /// </summary>
    public int TipoActividadCodigo { get; set; } // pac_codtac

    /// <summary>
    /// Desplazamiento de tiempo antes o despues de la contratación para determinar la fecha de inicio de la actividad
    /// </summary>
    public int OffsetInicio { get; set; } // pac_offset_inicio

    /// <summary>
    /// Unidad de medida del desplazamiento
    /// </summary>
    public string UnidadOffsetInicio { get; set; } // pac_unidad_offset_inicio

    /// <summary>
    /// Duración estimada de la actividad
    /// </summary>
    public int DuracionEstimada { get; set; } // pac_duracion_estimada

    /// <summary>
    /// Unidad de medida de la duracióon estimada de la actividad
    /// </summary>
    public string UnidadDuracion { get; set; } // pac_unidad_duracion

    /// <summary>
    /// Código de Prioridad de la actividad
    /// </summary>
    public int PrioridadActividadCodigo { get; set; } // pac_codpri

    /// <summary>
    /// Orden de esta actividad respecto de las mismas que tienen los mismos prerequisitos
    /// </summary>
    public int Orden { get; set; } // pac_orden

    /// <summary>
    /// Código de Tipo de Responsable de la actividad
    /// </summary>
    public int TipoResponsableActividadCodigo { get; set; } // pac_codtra

    /// <summary>
    /// Codigo de Tipo de Evaluación de la activdidad
    /// </summary>
    public int TipoEvaluacionCodigo { get; set; } // pac_codtev

    /// <summary>
    /// Nota de evaluación esperada para determinar si aprobo o no la evaluación
    /// </summary>
    public decimal NotaEvalEsperada { get; set; } // pac_nota_eval_esperada

    /// <summary>
    /// Data de los campos adicionales
    /// </summary>
    public string RawPropertyBagData { get; set; } // pac_property_bag_data

    /// <summary>
    /// Usuario que creo el registro
    /// </summary>
    public string UsuarioGrabacion { get; set; } // pac_usuario_grabacion

    /// <summary>
    /// Fecha en que se creo el registro
    /// </summary>
    public DateTime? FechaGrabacion { get; set; } // pac_fecha_grabacion

    /// <summary>
    /// Usuario que modificó por última vez el registro
    /// </summary>
    public string UsuarioModificacion { get; set; } // pac_usuario_modificacion

    /// <summary>
    /// Fecha de la última modificacion del registro
    /// </summary>
    public DateTime? FechaModificacion { get; set; } // pac_fecha_modificacion

    // Foreign keys

    /// <summary>
    /// Parent EtapaPrograma pointed by [pac_plant_actividades].([EtapaProgramaCodigo]) (FK_obdetp_obdpac)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual EtapaPrograma EtapaPrograma { get; set; } // FK_obdetp_obdpac

    /// <summary>
    /// Parent PlantillaPrograma pointed by [pac_plant_actividades].([PlantillaProgramaCodigo]) (FK_obdppr_obdpac)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual PlantillaPrograma PlantillaPrograma { get; set; } // FK_obdppr_obdpac

    /// <summary>
    /// Parent PrioridadActividad pointed by [pac_plant_actividades].([PrioridadActividadCodigo]) (FK_obdpri_obdpac)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual PrioridadActividad PrioridadActividad { get; set; } // FK_obdpri_obdpac

    /// <summary>
    /// Parent TipoActividad pointed by [pac_plant_actividades].([TipoActividadCodigo]) (FK_obdtac_obdpac)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual TipoActividad TipoActividad { get; set; } // FK_obdtac_obdpac

    /// <summary>
    /// Parent TipoEvaluacion pointed by [pac_plant_actividades].([TipoEvaluacionCodigo]) (FK_obdtev_obdpac)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual TipoEvaluacion TipoEvaluacion { get; set; } // FK_obdtev_obdpac

    /// <summary>
    /// Parent TipoResponsableActividad pointed by [pac_plant_actividades].([TipoResponsableActividadCodigo]) (FK_obdtra_obdpac)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual TipoResponsableActividad TipoResponsableActividad { get; set; } // FK_obdtra_obdpac

    // Children collections

    /// <summary>
    /// Child Actividads where [pna_plant_notif_actividad].[pna_codpac] point to this entity (FK_obdpac_obdpna)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual ICollection<PlantillaNotificacionActividad> PlantillasDeNotificacion { get; set; } = new List<PlantillaNotificacionActividad>(); // FK_obdpac_obdpna

    /// <summary>
    /// Child Prerequisitos (Many-to-Many) mapped by table [ppa_plant_prerequisitos_act]
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual ICollection<PrerequisitoPlantillaActividad> Prerequisitos { get; set; } = new List<PrerequisitoPlantillaActividad>(); // ppa_plant_prerequisitos_act
}