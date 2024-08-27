using System;
using System.Collections.Generic;

namespace onboarding.data.bases;

/// <summary>
/// Tabla que almacena los tipos de actividad para los programas de Onboarding
/// obd.tac_tipos_actividad
/// </summary>
public partial class TipoActividad
{
    /// <summary>
    /// Código de tipo de actividad
    /// </summary>
    public int Codigo { get; set; }

    /// <summary>
    /// Código de grupo corporativo
    /// </summary>
    public int GrupoCorporativoCodigo { get; set; }

    /// <summary>
    /// Nombre del tipo de actividad
    /// </summary>
    public string Nombre { get; set; }

    /// <summary>
    /// Descripción del tipo de actividad
    /// </summary>
    public string Descripcion { get; set; }

    /// <summary>
    /// ¿Requiere Notificación luego de que finalice? (contratado, jefe, RRHH y al responsable de la actividad si está definido)
    /// </summary>
    public bool RequiereNotificacion { get; set; }

    /// <summary>
    /// ¿Requiere Recordatorio previo a que se inicie? (contratado, jefe, RRHH y al responsable de la actividad si está definido)
    /// </summary>
    public bool RequiereRecordatorio { get; set; }

    /// <summary>
    /// ¿Requiere Evaluación del responsable? (contratado, jefe, RRHH y al responsable de la actividad si está definido)
    /// </summary>
    public bool RequiereEvaluacion { get; set; }

    /// <summary>
    /// ¿Requiere Adjuntar documentos?
    /// </summary>
    public bool RequiereDocumentos { get; set; }

    /// <summary>
    /// ¿Requiere un responsable asignado?
    /// </summary>
    public bool RequiereResponsable { get; set; }

    /// <summary>
    /// Duración estimada de la actividad
    /// </summary>
    public int DuracionEstimada { get; set; }

    /// <summary>
    /// Unidad de medida para la duración estimada
    /// </summary>
    public string UnidadDuracion { get; set; }

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

    public virtual ICollection<PlantillaActividad> PlantillasDeActividades { get; set; } = new List<PlantillaActividad>();
}
