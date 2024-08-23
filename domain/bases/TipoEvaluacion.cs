using System;
using System.Collections.Generic;

namespace onboarding.data.bases;

/// <summary>
/// Tabla con los tipos de evaluaciones que se aplican a las actividades de los planes de onboarding
/// </summary>
public partial class TipoEvaluacion
{
    /// <summary>
    /// Código del tipo de evaluación
    /// </summary>
    public int TevCodigo { get; set; }

    /// <summary>
    /// Código del Grupo Corporativo
    /// </summary>
    public int TevCodgrc { get; set; }

    /// <summary>
    /// Nombre del tipo de evaluación
    /// </summary>
    public string TevNombre { get; set; } = null!;

    /// <summary>
    /// Descripción del tipo de evaluación
    /// </summary>
    public string? TevDescripcion { get; set; }

    /// <summary>
    /// Determina si el tipo de evaluación utiliza un formulario dinámico
    /// </summary>
    public bool TevUtilizaFdi { get; set; }

    /// <summary>
    /// Código de formulario dinámico que se utiliza para evaluar una actividad cuando si se utiliza
    /// </summary>
    public int? TevCodfdiEvaluacion { get; set; }

    /// <summary>
    /// Data de los campos adicionales
    /// </summary>
    public string? TevPropertyBagData { get; set; }

    /// <summary>
    /// Usuario que creo el registro
    /// </summary>
    public string? TevUsuarioGrabacion { get; set; }

    /// <summary>
    /// Fecha en que se creo el registro
    /// </summary>
    public DateTime? TevFechaGrabacion { get; set; }

    /// <summary>
    /// Usuario que modificó por última vez el registro
    /// </summary>
    public string? TevUsuarioModificacion { get; set; }

    /// <summary>
    /// Fecha de la última modificacion del registro
    /// </summary>
    public DateTime? TevFechaModificacion { get; set; }

    public virtual ICollection<ActividadPrograma> ActividadesProgramas { get; set; } = new List<ActividadPrograma>();

    public virtual ICollection<PacPlantActividade> PacPlantActividades { get; set; } = new List<PacPlantActividade>();
}
