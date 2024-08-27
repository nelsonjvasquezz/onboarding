using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace onboarding.data.bases;

/// <summary>
/// Tabla de Tipos de resposnables de las Actividades
/// obd.tra_tipos_respon_actividad
/// </summary>
public partial class TipoResponsableActividad
{
    /// <summary>
    /// Código de Tipo de Resonsable de Actividad
    /// </summary>
    public int Codigo { get; set; } // tra_codigo

    /// <summary>
    /// Código de Grupo Corporativo
    /// </summary>
    public int GrupoCorporativoCodigo { get; set; } // tra_codgrc

    /// <summary>
    /// Nombre del Tipo de Resonsable de Actividad
    /// </summary>
    public string Nombre { get; set; } // tra_nombre

    /// <summary>
    /// Descripción del Tipo de Resonsable de Actividad
    /// </summary>
    public string Descripcion { get; set; } // tra_descripcion

    /// <summary>
    /// ¿Requiere la selección de un empleado?
    /// </summary>
    public bool RequiereEmpleo { get; set; } // tra_requiere_empleo

    /// <summary>
    /// Código de la lista de valores que permite seleccionar un empleo
    /// </summary>
    public string EmpleoValueListCodigo { get; set; } // tra_codvli_empleo

    /// <summary>
    /// ¿Corresponde con una institución externa?
    /// </summary>
    public bool EsInstExterna { get; set; } // tra_es_inst_externa

    /// <summary>
    /// Nombre de una persona contacto, cuando es una institución externa
    /// </summary>
    public string ContactoExterno { get; set; } // tra_contacto_externo

    /// <summary>
    /// ¿Corresponde con una persona externa?
    /// </summary>
    public bool EsPersonaExterna { get; set; } // tra_es_persona_externa

    /// <summary>
    /// Email de notificaciones si es una persona o institución externa
    /// </summary>
    public string EmailExterno { get; set; } // tra_email_externo

    /// <summary>
    /// Teléfono de contacto cuando es una persona o institución externa
    /// </summary>
    public string TelefonoExterno { get; set; } // tra_telefono_externo

    /// <summary>
    /// Data de los campos adicionales
    /// </summary>
    public string RawPropertyBagData { get; set; } // tra_property_bag_data

    /// <summary>
    /// Usuario que creo el registro
    /// </summary>
    public string UsuarioGrabacion { get; set; } // tra_usuario_grabacion

    /// <summary>
    /// Fecha en que se creo el registro
    /// </summary>
    public DateTime? FechaGrabacion { get; set; } // tra_fecha_grabacion

    /// <summary>
    /// Usuario que modificó por última vez el registro
    /// </summary>
    public string UsuarioModificacion { get; set; } // tra_usuario_modificacion

    /// <summary>
    /// Fecha de la última modificacion del registro
    /// </summary>
    public DateTime? FechaModificacion { get; set; } // tra_fecha_modificacion

    // Children collections

    /// <summary>
    /// Child Actividades where [acp_actividades_programa].[acp_codtra] point to this entity (FK_obdtra_obdacp)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual ICollection<ActividadPrograma> Actividades { get; set; } = new List<ActividadPrograma>(); // FK_obdtra_obdacp

    /// <summary>
    /// Child PlantillasDeActividades where [pac_plant_actividades].[pac_codtra] point to this entity (FK_obdtra_obdpac)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual ICollection<PlantillaActividad> PlantillasDeActividades { get; set; } = new List<PlantillaActividad>(); // FK_obdtra_obdpac
}