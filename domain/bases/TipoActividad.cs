using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace onboarding.data.bases;

/// <summary>
/// Tabla que almacena los tipos de actividad para los programas de Onboarding
/// obd.tac_tipos_actividad
/// </summary>
public partial class TipoActividad
{
    /// <summary>
    /// Código de tipo de actividad
    /// </summary>
    public int Codigo { get; set; } // tac_codigo

    /// <summary>
    /// Código de grupo corporativo
    /// </summary>
    public int GrupoCorporativoCodigo { get; set; } // tac_codgrc

    /// <summary>
    /// Nombre del tipo de actividad
    /// </summary>
    public string Nombre { get; set; } // tac_nombre

    /// <summary>
    /// Descripción del tipo de actividad
    /// </summary>
    public string Descripcion { get; set; } // tac_descripcion

    /// <summary>
    /// ¿Requiere Notificación luego de que finalice? (contratado, jefe, RRHH y al responsable de la actividad si está definido)
    /// </summary>
    public bool RequiereNotificacion { get; set; } // tac_req_notificacion

    /// <summary>
    /// ¿Requiere Recordatorio previo a que se inicie? (contratado, jefe, RRHH y al responsable de la actividad si está definido)
    /// </summary>
    public bool RequiereRecordatorio { get; set; } // tac_req_recordatorio

    /// <summary>
    /// ¿Requiere Evaluación del responsable? (contratado, jefe, RRHH y al responsable de la actividad si está definido)
    /// </summary>
    public bool RequiereEvaluacion { get; set; } // tac_req_evaluacion

    /// <summary>
    /// ¿Requiere Adjuntar documentos?
    /// </summary>
    public bool RequiereDocumentos { get; set; } // tac_req_documentos

    /// <summary>
    /// ¿Requiere un responsable asignado?
    /// </summary>
    public bool RequiereResponsable { get; set; } // tac_req_responsable

    /// <summary>
    /// Duración estimada de la actividad
    /// </summary>
    public int DuracionEstimada { get; set; } // tac_duracion_estimada

    /// <summary>
    /// Unidad de medida para la duración estimada
    /// </summary>
    public string UnidadDuracionDb { get; set; } // tac_unidad_duracion

    /// <summary>
    /// Data de los campos adicionales
    /// </summary>
    public string RawPropertyBagData { get; set; } // tac_property_bag_data

    /// <summary>
    /// Usuario que creo el registro
    /// </summary>
    public string UsuarioGrabacion { get; set; } // tac_usuario_grabacion

    /// <summary>
    /// Fecha en que se creo el registro
    /// </summary>
    public DateTime? FechaGrabacion { get; set; } // tac_fecha_grabacion

    /// <summary>
    /// Usuario que modificó por última vez el registro
    /// </summary>
    public string UsuarioUltimaModificacion { get; set; } // tac_usuario_modificacion

    /// <summary>
    /// Fecha de la última modificacion del registro
    /// </summary>
    public DateTime? FechaUltimaModificacion { get; set; } // tac_fecha_modificacion

    // Children collections

    /// <summary>
    /// Child Actividades where [acp_actividades_prg].[acp_codtac] point to this entity (FK_obdtac_obdacp)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual ICollection<ActividadPrograma> Actividades { get; set; } = new List<ActividadPrograma>();

    /// <summary>
    /// Child ActividadesPlantilla where [pac_plant_actividades].[pac_codtac] point to this entity (FK_obdtac_obdpac)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual ICollection<ActividadPlantilla> ActividadesPlantilla { get; set; } = new List<ActividadPlantilla>();
}