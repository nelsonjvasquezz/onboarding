using System;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace onboarding.data.bases;

/// <summary>
/// Tabla que almacena la información de los empleados participantes sin asignar en un programa de onboarding
/// obd.psa_part_sin_asignar
/// </summary>
public partial class ParticipanteSinAsignar
{
    /// <summary>
    /// Código de registro del participante sin asignar en un programa de onboarding
    /// </summary>
    public int Codigo { get; set; } // psa_codigo

    /// <summary>
    /// Código del participante cuando ya ha sido asignado a un programa de onboarding
    /// </summary>
    public int? ParticipanteProgramaCodigo { get; set; } // psa_codpap

    /// <summary>
    /// Código de la contratación del participante sin asignar a un programa de onboarding
    /// </summary>
    public int? ContratacionCodigo { get; set; } // psa_codcon

    /// <summary>
    /// Código del concurso de selección donde fue contratado el participante sin asignar a un programa de onboarding
    /// </summary>
    public int? ConcursoCodigo { get; set; } // psa_codcos

    /// <summary>
    /// Código del puesto a donde será contratado el nuevo empleado
    /// </summary>
    public int PuestoCodigo { get; set; } // psa_codpue

    /// <summary>
    /// Código de expediente del participante sin asignar a un programa de onboarding
    /// </summary>
    public int ExpedienteCodigo { get; set; } // psa_codexp

    /// <summary>
    /// Código de empleo del participante, cuando la nueva contratación ya se realizó
    /// </summary>
    public int? EmpleoCodigo { get; set; } // psa_codemp

    /// <summary>
    /// Código de plaza, cuando la nueva contratación ya se realizó
    /// </summary>
    public int? PlazaCodigo { get; set; } // psa_codplz

    /// <summary>
    /// Código del empleo del jefe inmeditato superior o supervisor responsable de la nueva contratación
    /// </summary>
    public int EmpleoJefeCodigo { get; set; } // psa_codemp_jefe

    /// <summary>
    /// Código del centro de trabajo donde será ubicado el nuevo empleado
    /// </summary>
    public int CentroTrabajoCodigo { get; set; } // psa_codcdt

    /// <summary>
    /// Código de la unidad organizativa donde será ubicado el nuevo empleado
    /// </summary>
    public int UnidadCodigo { get; set; } // psa_coduni

    /// <summary>
    /// Fecha efectiva de contratación
    /// </summary>
    public DateTime FechaContratacion { get; set; } // psa_fecha_contratacion

    /// <summary>
    /// Usuario que creo el registro
    /// </summary>
    public string UsuarioGrabacion { get; set; } // psa_usuario_grabacion

    /// <summary>
    /// Fecha en que se creo el registro
    /// </summary>
    public DateTime? FechaGrabacion { get; set; } // psa_fecha_grabacion

    /// <summary>
    /// Usuario que modificó por última vez el registro
    /// </summary>
    public string UsuarioUltimaModificacion { get; set; } // psa_usuario_modificacion

    /// <summary>
    /// Fecha de la última modificacion del registro
    /// </summary>
    public DateTime? FechaUltimaModificacion { get; set; } // psa_fecha_modificacion

    // Foreing keys

    /// <summary>
    /// Parent ParticipantePrograma pointed by [psa_part_sin_asignar].([ParticipanteProgramaCodigo]) (FK_obdpap_obdpsa)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual ParticipantePrograma Participante { get; set; } // FK_obdpap_obdpsa

}