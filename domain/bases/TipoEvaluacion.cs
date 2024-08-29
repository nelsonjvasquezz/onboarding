using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace onboarding.data.bases;

/// <summary>
/// Tabla con los tipos de evaluaciones que se aplican a las actividades de los planes de onboarding
/// obd.tev_tipos_evaluacion
/// </summary>
public partial class TipoEvaluacion
{
    /// <summary>
    /// Código del tipo de evaluación
    /// </summary>
    public int Codigo { get; set; } // tev_codigo

    /// <summary>
    /// Código del Grupo Corporativo
    /// </summary>
    public int GrupoCorporativoCodigo { get; set; } // tev_codgrc

    /// <summary>
    /// Nombre del tipo de evaluación
    /// </summary>
    public string Nombre { get; set; } // tev_nombre

    /// <summary>
    /// Descripción del tipo de evaluación
    /// </summary>
    public string Descripcion { get; set; } // tev_descripcion

    /// <summary>
    /// Determina si el tipo de evaluación utiliza un formulario dinámico
    /// </summary>
    public bool UtilizaFormularioDinamico { get; set; } // tev_utiliza_fdi

    /// <summary>
    /// Código de formulario dinámico que se utiliza para evaluar una actividad cuando si se utiliza
    /// </summary>
    public int? FormularioDinamicoCodigo { get; set; } // tev_codfdi_evaluacion

    /// <summary>
    /// Data de los campos adicionales
    /// </summary>
    public string RawPropertyBagData { get; set; } // tev_property_bag_data

    /// <summary>
    /// Usuario que creo el registro
    /// </summary>
    public string UsuarioGrabacion { get; set; } // tev_usuario_grabacion

    /// <summary>
    /// Fecha en que se creo el registro
    /// </summary>
    public DateTime? FechaGrabacion { get; set; } // tev_fecha_grabacion

    /// <summary>
    /// Usuario que modificó por última vez el registro
    /// </summary>
    public string UsuarioUltimaModificacion { get; set; } // tev_usuario_modificacion

    /// <summary>
    /// Fecha de la última modificacion del registro
    /// </summary>
    public DateTime? FechaUltimaModificacion { get; set; } // tev_fecha_modificacion

    // Children collections

    /// <summary>
    /// Child Actividades where [acp_actividades_programa].[acp_codtev] point to this entity (FK_obdte_obdacp)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual ICollection<ActividadPrograma> Actividades { get; set; } = new List<ActividadPrograma>(); // FK_obdte_obdacp

    /// <summary>
    /// Child PlantillaActividades where [pac_plant_actividades].[pac_codtac] point to this entity (FK_obdtev_obdpac)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual ICollection<PlantillaActividad> PlantillasDeActividades { get; set; } = new List<PlantillaActividad>(); // FK_obdtev_obdpac
}