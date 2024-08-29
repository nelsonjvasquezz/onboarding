using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace onboarding.data.bases;

/// <summary>
/// Tabla con las fases o etapas de los programas de Oboarding
/// obd.etp_etapas_programa
/// </summary>
public partial class EtapaPrograma
{
    /// <summary>
    /// Código de la etapa del programa
    /// </summary>
    public int Codigo { get; set; } // etp_codigo

    /// <summary>
    /// Código de grupo corporativo
    /// </summary>
    public int GrupoCorporativoCodigo { get; set; } // etp_codgrc

    /// <summary>
    /// Nombre de la etapa del programa
    /// </summary>
    public string Nombre { get; set; } // etp_nombre

    /// <summary>
    /// Descripción de la etapa del programa
    /// </summary>
    public string Descripcion { get; set; } // etp_descripcion

    /// <summary>
    /// Orden de esta etapa respecto de las demás
    /// </summary>
    public int Orden { get; set; } // etp_orden

    /// <summary>
    /// ¿Corresponde con actividades antes del primer día de trabajo?
    /// </summary>
    public bool AntesPrimerDia { get; set; } // etp_antes_primer_dia

    /// <summary>
    /// ¿Corresponde con actividades durante el primer día de trabajo?
    /// </summary>
    public bool DurantePrimerDia { get; set; } // etp_durante_primer_dia

    /// <summary>
    /// ¿Corresponde con actividades posteriores al primer día de trabajo?
    /// </summary>
    public bool PosteriorPrimerDia { get; set; } // etp_posterior_primer_dia

    /// <summary>
    /// Esta fase está contenida en el período de prueba
    /// </summary>
    public bool PeriodoPrueba { get; set; } // etp_periodo_prueba

    /// <summary>
    /// Data de los campos adicionales
    /// </summary>
    public string RawPropertyBagData { get; set; } // etp_property_bag_data

    /// <summary>
    /// Usuario que creo el registro
    /// </summary>
    public string UsuarioGrabacion { get; set; } // etp_usuario_grabacion

    /// <summary>
    /// Fecha en que se creo el registro
    /// </summary>
    public DateTime? FechaGrabacion { get; set; } // etp_fecha_grabacion

    /// <summary>
    /// Usuario que modificó por última vez el registro
    /// </summary>
    public string UsuarioUltimaModificacion { get; set; } // etp_usuario_modificacion

    /// <summary>
    /// Fecha de la última modificacion del registro
    /// </summary>
    public DateTime? FechaUltimaModificacion { get; set; } // etp_fecha_modificacion

    // Children collections

    /// <summary>
    /// Child ActividadesProgramas where [acp_actividades_programa].[acp_codigo] point to this entity (FK_obdetp_obdacp)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual ICollection<ActividadPrograma> Actividades { get; set; } = new List<ActividadPrograma>(); // FK_obdetp_obdacp

    /// <summary>
    /// Child PlantillasActividades where [pac_plant_actividades].[pac_codetp] point to this entity (FK_obdetp_obdpac)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual ICollection<PlantillaActividad> PlantillasDeActividades { get; set; } = new List<PlantillaActividad>(); // FK_obdetp_obdpac
}