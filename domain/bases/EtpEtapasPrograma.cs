using System;
using System.Collections.Generic;

namespace onboarding.data.bases;

/// <summary>
/// Tabla con las fases o etapas de los programas de Oboarding
/// </summary>
public partial class EtpEtapasPrograma
{
    /// <summary>
    /// Código de la etapa del programa
    /// </summary>
    public int EtpCodigo { get; set; }

    /// <summary>
    /// Código de grupo corporativo
    /// </summary>
    public int EtpCodgrc { get; set; }

    /// <summary>
    /// Nombre de la etapa del programa
    /// </summary>
    public string EtpNombre { get; set; } = null!;

    /// <summary>
    /// Descripción de la etapa del programa
    /// </summary>
    public string? EtpDescripcion { get; set; }

    /// <summary>
    /// Orden de esta etapa respecto de las demás
    /// </summary>
    public int EtpOrden { get; set; }

    /// <summary>
    /// ¿Corresponde con actividades antes del primer día de trabajo?
    /// </summary>
    public bool EtpAntesPrimerDia { get; set; }

    /// <summary>
    /// ¿Corresponde con actividades durante el primer día de trabajo?
    /// </summary>
    public bool EtpDurantePrimerDia { get; set; }

    /// <summary>
    /// ¿Corresponde con actividades posteriores al primer día de trabajo?
    /// </summary>
    public bool EtpPosteriorPrimerDia { get; set; }

    /// <summary>
    /// Esta fase está contenida en el período de prueba
    /// </summary>
    public bool EtpPeriodoPrueba { get; set; }

    /// <summary>
    /// Data de los campos adicionales
    /// </summary>
    public string? EtpPropertyBagData { get; set; }

    /// <summary>
    /// Usuario que creo el registro
    /// </summary>
    public string? EtpUsuarioGrabacion { get; set; }

    /// <summary>
    /// Fecha en que se creo el registro
    /// </summary>
    public DateTime? EtpFechaGrabacion { get; set; }

    /// <summary>
    /// Usuario que modificó por última vez el registro
    /// </summary>
    public string? EtpUsuarioModificacion { get; set; }

    /// <summary>
    /// Fecha de la última modificacion del registro
    /// </summary>
    public DateTime? EtpFechaModificacion { get; set; }

    public virtual ICollection<ActividadesPrograma> ActividadesProgramas { get; set; } = new List<ActividadesPrograma>();

    public virtual ICollection<PacPlantActividade> PacPlantActividades { get; set; } = new List<PacPlantActividade>();
}
