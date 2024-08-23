using System;
using System.Collections.Generic;

namespace onboarding.data.bases;

/// <summary>
/// Tabla que almacena los tipos de actividad para los programas de Onboarding
/// </summary>
public partial class TacTiposActividad
{
    /// <summary>
    /// Código de tipo de actividad
    /// </summary>
    public int TacCodigo { get; set; }

    /// <summary>
    /// Código de grupo corporativo
    /// </summary>
    public int TacCodgrc { get; set; }

    /// <summary>
    /// Nombre del tipo de actividad
    /// </summary>
    public string TacNombre { get; set; } = null!;

    /// <summary>
    /// Descripción del tipo de actividad
    /// </summary>
    public string? TacDescripcion { get; set; }

    /// <summary>
    /// ¿Requiere Notificación luego de que finalice? (contratado, jefe, RRHH y al responsable de la actividad si está definido)
    /// </summary>
    public bool TacReqNotificacion { get; set; }

    /// <summary>
    /// ¿Requiere Recordatorio previo a que se inicie? (contratado, jefe, RRHH y al responsable de la actividad si está definido)
    /// </summary>
    public bool TacReqRecordatorio { get; set; }

    /// <summary>
    /// ¿Requiere Evaluación del responsable? (contratado, jefe, RRHH y al responsable de la actividad si está definido)
    /// </summary>
    public bool TacReqEvaluacion { get; set; }

    /// <summary>
    /// ¿Requiere Adjuntar documentos?
    /// </summary>
    public bool TacReqDocumentos { get; set; }

    /// <summary>
    /// ¿Requiere un responsable asignado?
    /// </summary>
    public bool TacReqResponsable { get; set; }

    /// <summary>
    /// Duración estimada de la actividad
    /// </summary>
    public int TacDuracionEstimada { get; set; }

    /// <summary>
    /// Unidad de medida para la duración estimada
    /// </summary>
    public string TacUnidadDuracion { get; set; } = null!;

    /// <summary>
    /// Data de los campos adicionales
    /// </summary>
    public string? TacPropertyBagData { get; set; }

    /// <summary>
    /// Usuario que creo el registro
    /// </summary>
    public string? TacUsuarioGrabacion { get; set; }

    /// <summary>
    /// Fecha en que se creo el registro
    /// </summary>
    public DateTime? TacFechaGrabacion { get; set; }

    /// <summary>
    /// Usuario que modificó por última vez el registro
    /// </summary>
    public string? TacUsuarioModificacion { get; set; }

    /// <summary>
    /// Fecha de la última modificacion del registro
    /// </summary>
    public DateTime? TacFechaModificacion { get; set; }

    public virtual ICollection<ActividadesPrograma> ActividadesProgramas { get; set; } = new List<ActividadesPrograma>();

    public virtual ICollection<PacPlantActividade> PacPlantActividades { get; set; } = new List<PacPlantActividade>();
}
