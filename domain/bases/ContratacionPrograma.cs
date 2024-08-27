using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace onboarding.data.bases;

/// <summary>
/// Tabla con el detalle de nuevas contrataciones que participan de un programa de onboarding
/// obd.cpr_contrataciones_programa
/// </summary>
public partial class ContratacionPrograma
{
    /// <summary>
    /// Código de registro de contratación de cada programa
    /// </summary>
    public int Codigo { get; set; } // cpr_codigo

    /// <summary>
    /// Código del programa de onboarding
    /// </summary>
    public int ProgramaCodigo { get; set; } // cpr_codpro

    /// <summary>
    /// Código del responsable en RRHH de la nueva contratación
    /// </summary>
    public int EmpleoResponsableCodigo { get; set; } // cpr_codemp_resp_rrhh

    /// <summary>
    /// Código del puesto a donde será contratado el nuevo empleado
    /// </summary>
    public int PuestoCodigo { get; set; } // cpr_codpue

    /// <summary>
    /// Código de expediente de la nueva contratación
    /// </summary>
    public int ExpedienteCodigo { get; set; } // cpr_codexp

    /// <summary>
    /// Código de empleo, cuando la nueva contratación ya se realizó
    /// </summary>
    public int? EmpleoCodigo { get; set; } // cpr_codemp

    /// <summary>
    /// Código del empleo del jefe inmeditato superior o supervisor responsable de la nueva contratación
    /// </summary>
    public int EmpleoJefeCodigo { get; set; } // cpr_codemp_jefe

    /// <summary>
    /// Código del centro de trabajo donde será ubicado el nuevo empleado
    /// </summary>
    public int CentroTrabajoCodigo { get; set; } // cpr_codcdt

    /// <summary>
    /// Código de la unidad organizativa donde será ubicado el nuevo empleado
    /// </summary>
    public int UnidadCodigo { get; set; } // cpr_coduni

    /// <summary>
    /// Fecha efectiva de contratación
    /// </summary>
    public DateTime FechaContratacion { get; set; } // cpr_fecha_contratacion

    /// <summary>
    /// Fecha esperada de inicio del programa
    /// </summary>
    public DateTime FechaInicio { get; set; } // cpr_fecha_inicio

    /// <summary>
    /// Fecha esperada de finalización del programa
    /// </summary>
    public DateTime FechaFin { get; set; } // cpr_fecha_fin

    /// <summary>
    /// Data de los campos adicionales
    /// </summary>
    public string RawPropertyBagData { get; set; } // cpr_property_bag_data

    /// <summary>
    /// Usuario que creo el registro
    /// </summary>
    public string UsuarioGrabacion { get; set; } // cpr_usuario_grabacion

    /// <summary>
    /// Fecha en que se creo el registro
    /// </summary>
    public DateTime? FechaGrabacion { get; set; } // cpr_fecha_grabacion

    /// <summary>
    /// Usuario que modificó por última vez el registro
    /// </summary>
    public string UsuarioModificacion { get; set; } // cpr_usuario_modificacion

    /// <summary>
    /// Fecha de la última modificacion del registro
    /// </summary>
    public DateTime? FechaModificacion { get; set; } // cpr_fecha_modificacion

    // Foreing keys

    /// <summary>
    /// Parent Programa pointed by [cpr_contrataciones_programa].([ProgramaCodigo]) (FK_obdpro_obdcpr)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual Programa Programa { get; set; } // FK_obdpro_obdcpr

    // Children collections

    /// <summary>
    /// Child ActividadesProgramas where [acp_actividades_programa].[ContratacionProgramaCodigo] point to this entity (FK_obdcpr_obdacp)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual ICollection<ActividadPrograma> Actividades { get; set; } = new List<ActividadPrograma>(); // FK_obdcpr_obdacp

}