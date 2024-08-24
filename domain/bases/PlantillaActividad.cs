using System;
using System.Collections.Generic;

namespace onboarding.data.bases;

/// <summary>
/// Tabla que almacena las actividades de la plantilla del programa de onboarding
/// </summary>
public partial class PlantillaActividad
{
    /// <summary>
    /// Código de registro de la actividad de la plantilla para programa de onboarding
    /// </summary>
    public int Codigo { get; set; }

    /// <summary>
    /// Código de la plantilla de programa de onboarding
    /// </summary>
    public int PlantillaProgramaCodigo { get; set; }

    /// <summary>
    /// Nombre de la actividad
    /// </summary>
    public string Nombre { get; set; } = null!;

    /// <summary>
    /// Descripción de la actividad
    /// </summary>
    public string? Descripcion { get; set; }

    /// <summary>
    /// Objetivo de la actividad
    /// </summary>
    public string? Objetivo { get; set; }

    /// <summary>
    /// Código de Etapa o Fase del programa
    /// </summary>
    public int EtapaProgramaCodigo { get; set; }

    /// <summary>
    /// Código de Tipo de Actividad
    /// </summary>
    public int TipoActividadCodigo { get; set; }

    /// <summary>
    /// Desplazamiento de tiempo antes o despues de la contratación para determinar la fecha de inicio de la actividad
    /// </summary>
    public int OffsetInicio { get; set; }

    /// <summary>
    /// Unidad de medida del desplazamiento
    /// </summary>
    public string UnidadOffsetInicio { get; set; } = null!;

    /// <summary>
    /// Duración estimada de la actividad
    /// </summary>
    public int DuracionEstimada { get; set; }

    /// <summary>
    /// Unidad de medida de la duracióon estimada de la actividad
    /// </summary>
    public string UnidadDuracion { get; set; } = null!;

    /// <summary>
    /// Código de Prioridad de la actividad
    /// </summary>
    public int PrioridadActividadCodigo { get; set; }

    /// <summary>
    /// Orden de esta actividad respecto de las mismas que tienen los mismos prerequisitos
    /// </summary>
    public int Orden { get; set; }

    /// <summary>
    /// Código de Tipo de Responsable de la actividad
    /// </summary>
    public int TipoResponsableActividadCodigo { get; set; }

    /// <summary>
    /// Codigo de Tipo de Evaluación de la activdidad
    /// </summary>
    public int TipoEvaluacionCodigo { get; set; }

    /// <summary>
    /// Nota de evaluación esperada para determinar si aprobo o no la evaluación
    /// </summary>
    public decimal NotaEvalEsperada { get; set; }

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

    public virtual EtapaPrograma EtapaPrograma { get; set; } = null!;

    public virtual PlantillaPrograma PlantillaPrograma { get; set; } = null!;

    public virtual PrioridadActividad PrioridadActividad { get; set; } = null!;

    public virtual TipoActividad TipoActividad { get; set; } = null!;

    public virtual TipoEvaluacion TipoEvaluacion { get; set; } = null!;

    public virtual TipoResponsableActividad TipoResponsableActividad { get; set; } = null!;

    public virtual ICollection<PlantillaNotificacionActividad> PlantillasNotificacionActividad { get; set; } = new List<PlantillaNotificacionActividad>();

    public virtual ICollection<PlantillaActividad> PlantillaActividadesPrerequisitos { get; set; } = new List<PlantillaActividad>();

    public virtual ICollection<PlantillaActividad> PlantillaActividades { get; set; } = new List<PlantillaActividad>();
}
