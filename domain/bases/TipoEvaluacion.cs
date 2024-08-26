using System;
using System.Collections.Generic;

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
    public int Codigo { get; set; }

    /// <summary>
    /// Código del Grupo Corporativo
    /// </summary>
    public int GrupoCorporativoCodigo { get; set; }

    /// <summary>
    /// Nombre del tipo de evaluación
    /// </summary>
    public string Nombre { get; set; }

    /// <summary>
    /// Descripción del tipo de evaluación
    /// </summary>
    public string Descripcion { get; set; }

    /// <summary>
    /// Determina si el tipo de evaluación utiliza un formulario dinámico
    /// </summary>
    public bool UtilizaFormularioDinamico { get; set; }

    /// <summary>
    /// Código de formulario dinámico que se utiliza para evaluar una actividad cuando si se utiliza
    /// </summary>
    public int? FormularioDinamicoCodigo { get; set; }

    /// <summary>
    /// Data de los campos adicionales
    /// </summary>
    public string RawPropertyBagData { get; set; }

    /// <summary>
    /// Usuario que creo el registro
    /// </summary>
    public string UsuarioGrabacion { get; set; }

    /// <summary>
    /// Fecha en que se creo el registro
    /// </summary>
    public DateTime? FechaGrabacion { get; set; }

    /// <summary>
    /// Usuario que modificó por última vez el registro
    /// </summary>
    public string UsuarioModificacion { get; set; }

    /// <summary>
    /// Fecha de la última modificacion del registro
    /// </summary>
    public DateTime? FechaModificacion { get; set; }

    public virtual ICollection<ActividadPrograma> ActividadesProgramas { get; set; } = new List<ActividadPrograma>();

    public virtual ICollection<PlantillaActividad> PlantillaActividades { get; set; } = new List<PlantillaActividad>();
}
