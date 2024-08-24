using System;
using System.Collections.Generic;

namespace onboarding.data.bases;

/// <summary>
/// Tabla con las fases o etapas de los programas de Oboarding
/// </summary>
public partial class EtapaPrograma
{
    /// <summary>
    /// Código de la etapa del programa
    /// </summary>
    public int Codigo { get; set; }

    /// <summary>
    /// Código de grupo corporativo
    /// </summary>
    public int GrupoCorporativoCodigo { get; set; }

    /// <summary>
    /// Nombre de la etapa del programa
    /// </summary>
    public string Nombre { get; set; } = null!;

    /// <summary>
    /// Descripción de la etapa del programa
    /// </summary>
    public string? Descripcion { get; set; }

    /// <summary>
    /// Orden de esta etapa respecto de las demás
    /// </summary>
    public int Orden { get; set; }

    /// <summary>
    /// ¿Corresponde con actividades antes del primer día de trabajo?
    /// </summary>
    public bool AntesPrimerDia { get; set; }

    /// <summary>
    /// ¿Corresponde con actividades durante el primer día de trabajo?
    /// </summary>
    public bool DurantePrimerDia { get; set; }

    /// <summary>
    /// ¿Corresponde con actividades posteriores al primer día de trabajo?
    /// </summary>
    public bool PosteriorPrimerDia { get; set; }

    /// <summary>
    /// Esta fase está contenida en el período de prueba
    /// </summary>
    public bool PeriodoPrueba { get; set; }

    /// <summary>
    /// Data de los campos adicionales
    /// </summary>
    public string? PropertyBagData { get; set; }

    /// <summary>
    /// Usuario que creo el registro
    /// </summary>
    public string? UsuarioGrabacion { get; set; }

    /// <summary>
    /// Fecha en que se creo el registro
    /// </summary>
    public DateTime? FechaGrabacion { get; set; }

    /// <summary>
    /// Usuario que modificó por última vez el registro
    /// </summary>
    public string? UsuarioModificacion { get; set; }

    /// <summary>
    /// Fecha de la última modificacion del registro
    /// </summary>
    public DateTime? FechaModificacion { get; set; }

    public virtual ICollection<ActividadPrograma> ActividadesProgramas { get; set; } = new List<ActividadPrograma>();

    public virtual ICollection<PlantillaActividad> PlantActividades { get; set; } = new List<PlantillaActividad>();
}
