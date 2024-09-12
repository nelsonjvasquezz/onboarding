using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace onboarding.data.bases;

/// <summary>
/// Tabla con el detalle de nuevas contrataciones que participan de un programa de onboarding
/// obd.pap_participantes_prg
/// </summary>
public partial class ParticipantePrograma
{
    /// <summary>
    /// Código de registro de contratación de cada programa
    /// </summary>
    public int Codigo { get; set; } // pap_codigo

    /// <summary>
    /// Código del programa de onboarding
    /// </summary>
    public int ProgramaCodigo { get; set; } // pap_codpro

    /// <summary>
    /// Código del responsable en RRHH de la nueva contratación
    /// </summary>
    public int EmpleoResponsableCodigo { get; set; } // pap_codemp_resp_rrhh

    /// <summary>
    /// Código del puesto a donde será contratado el nuevo empleado
    /// </summary>
    public int PuestoCodigo { get; set; } // pap_codpue

    /// <summary>
    /// Código de expediente de la nueva contratación
    /// </summary>
    public int ExpedienteCodigo { get; set; } // pap_codexp

    /// <summary>
    /// Código de empleo, cuando la nueva contratación ya se realizó
    /// </summary>
    public int? EmpleoCodigo { get; set; } // pap_codemp

    /// <summary>
    /// Código de plaza, cuando la nueva contratación ya se realizó
    /// </summary>
    public int? PlazaCodigo {get; set;} // pap_codplz

    /// <summary>
    /// Código del empleo del jefe inmeditato superior o supervisor responsable de la nueva contratación
    /// </summary>
    public int EmpleoJefeCodigo { get; set; } // pap_codemp_jefe

    /// <summary>
    /// Código del centro de trabajo donde será ubicado el nuevo empleado
    /// </summary>
    public int CentroTrabajoCodigo { get; set; } // pap_codcdt

    /// <summary>
    /// Código de la unidad organizativa donde será ubicado el nuevo empleado
    /// </summary>
    public int UnidadCodigo { get; set; } // pap_coduni

    /// <summary>
    /// Fecha efectiva de contratación
    /// </summary>
    public DateTime FechaContratacion { get; set; } // pap_fecha_contratacion

    /// <summary>
    /// Fecha esperada de inicio del programa
    /// </summary>
    public DateTime FechaInicio { get; set; } // pap_fecha_inicio

    /// <summary>
    /// Fecha esperada de finalización del programa
    /// </summary>
    public DateTime FechaFin { get; set; } // pap_fecha_fin

    /// <summary>
    /// Data de los campos adicionales
    /// </summary>
    public string RawPropertyBagData { get; set; } // pap_property_bag_data

    /// <summary>
    /// Usuario que creo el registro
    /// </summary>
    public string UsuarioGrabacion { get; set; } // pap_usuario_grabacion

    /// <summary>
    /// Fecha en que se creo el registro
    /// </summary>
    public DateTime? FechaGrabacion { get; set; } // pap_fecha_grabacion

    /// <summary>
    /// Usuario que modificó por última vez el registro
    /// </summary>
    public string UsuarioUltimaModificacion { get; set; } // pap_usuario_modificacion

    /// <summary>
    /// Fecha de la última modificacion del registro
    /// </summary>
    public DateTime? FechaUltimaModificacion { get; set; } // pap_fecha_modificacion

    // Foreing keys

    /// <summary>
    /// Parent Programa pointed by [pap_participantes_prg].([ProgramaCodigo]) (FK_obdpro_obdpap)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual Programa Programa { get; set; } // FK_obdpro_obdpap

    // Children collections

    /// <summary>
    /// Child Actividades where [acp_actividades_prg].[ParticipanteProgramaCodigo] point to this entity (FK_obdpap_obdacp)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual ICollection<ActividadPrograma> Actividades { get; set; } = new List<ActividadPrograma>(); // FK_obdpap_obdacp

}