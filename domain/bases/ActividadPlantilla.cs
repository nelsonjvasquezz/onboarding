using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace onboarding.data.bases;

/// <summary>
/// Tabla que almacena las actividades de la plantilla del programa de onboarding
/// obd.pac_plant_actividades
/// </summary>
public partial class ActividadPlantilla
{
    /// <summary>
    /// Código de registro de la actividad de la plantilla para programa de onboarding
    /// </summary>
    public int Codigo { get; set; } // pac_codigo

    /// <summary>
    /// Código de la plantilla de programa de onboarding
    /// </summary>
    public int PlantillaCodigo { get; set; } // pac_codppr

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
    public int EtapaActividadCodigo { get; set; } // pac_codetp

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
    public string UnidadOffsetInicioDb { get; set; } // pac_unidad_offset_inicio

    /// <summary>
    /// Duración estimada de la actividad
    /// </summary>
    public int DuracionEstimada { get; set; } // pac_duracion_estimada

    /// <summary>
    /// Unidad de medida de la duracióon estimada de la actividad
    /// </summary>
    public string UnidadDuracionDb { get; set; } // pac_unidad_duracion

    /// <summary>
    /// Código de Prioridad de la actividad
    /// </summary>
    public int PrioridadActividadCodigo { get; set; } // pac_codpri

    /// <summary>
    /// Orden de esta actividad respecto de las mismas que tienen los mismos requisitos
    /// </summary>
    public int Orden { get; set; } // pac_orden

    /// <summary>
    /// Código de Tipo de Responsable de la actividad
    /// </summary>
    public int TipoResponsableActividadCodigo { get; set; } // pac_codtra

    /// <summary>
    /// Codigo de Tipo de Evaluación de la actividad
    /// </summary>
    public int? TipoEvaluacionCodigo { get; set; } // pac_codtev

    /// <summary>
    /// Nota de evaluación esperada para determinar si aprobo o no la evaluación
    /// </summary>
    public decimal? NotaEvalEsperada { get; set; } // pac_nota_eval_esperada

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
    public string UsuarioUltimaModificacion { get; set; } // pac_usuario_modificacion

    /// <summary>
    /// Fecha de la última modificacion del registro
    /// </summary>
    public DateTime? FechaUltimaModificacion { get; set; } // pac_fecha_modificacion

    // Foreign keys

    /// <summary>
    /// Parent Etapa pointed by [pac_plant_actividades].([EtapaActividadCodigo]) (FK_obdetp_obdpac)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual EtapaActividad Etapa { get; set; } // FK_obdetp_obdpac

    /// <summary>
    /// Parent Plantilla pointed by [pac_plant_actividades].([PlantillaCodigo]) (FK_obdppr_obdpac)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual PlantillaPrograma Plantilla { get; set; } // FK_obdppr_obdpac

    /// <summary>
    /// Parent Prioridad pointed by [pac_plant_actividades].([PrioridadActividadCodigo]) (FK_obdpri_obdpac)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual PrioridadActividad Prioridad { get; set; } // FK_obdpri_obdpac

    /// <summary>
    /// Parent Tipo pointed by [pac_plant_actividades].([TipoActividadCodigo]) (FK_obdtac_obdpac)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual TipoActividad Tipo { get; set; } // FK_obdtac_obdpac

    /// <summary>
    /// Parent TipoEvaluacion pointed by [pac_plant_actividades].([TipoEvaluacionCodigo]) (FK_obdtev_obdpac)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual TipoEvaluacion TipoEvaluacion { get; set; } // FK_obdtev_obdpac

    /// <summary>
    /// Parent TipoResponsable pointed by [pac_plant_actividades].([TipoResponsableActividadCodigo]) (FK_obdtra_obdpac)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual TipoResponsableActividad TipoResponsable { get; set; } // FK_obdtra_obdpac

    // Children collections

    /// <summary>
    /// Child Notificaciones where [pna_plant_notif_actividad].[pna_codpac] point to this entity (FK_obdpac_obdpna)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual ICollection<NotificacionActividadPlantilla> Notificaciones { get; set; } = new List<NotificacionActividadPlantilla>(); // FK_obdpac_obdpna

    /// <summary>
    /// Child Requisitos (Many-to-Many) mapped by table [ppa_plant_requisitos_act]
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual ICollection<RequisitoActividadPlantilla> Requisitos { get; set; } = new List<RequisitoActividadPlantilla>(); // ppa_plant_requisitos_act
}