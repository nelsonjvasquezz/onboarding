using onboarding.data.bases;
using System;
using System.Collections.Generic;

namespace onboarding.data;

/// <summary>
/// Tabla de Tipos de resposnables de las Actividades
/// </summary>
public partial class TipoResponsableActividad
{
    /// <summary>
    /// Código de Tipo de Resonsable de Actividad
    /// </summary>
    public int TraCodigo { get; set; }

    /// <summary>
    /// Código de Grupo Corporativo
    /// </summary>
    public int TraCodgrc { get; set; }

    /// <summary>
    /// Nombre del Tipo de Resonsable de Actividad
    /// </summary>
    public string TraNombre { get; set; } = null!;

    /// <summary>
    /// Descripción del Tipo de Resonsable de Actividad
    /// </summary>
    public string? TraDescripcion { get; set; }

    /// <summary>
    /// ¿Requiere la selección de un empleado?
    /// </summary>
    public bool TraRequiereEmpleo { get; set; }

    /// <summary>
    /// Código de la lista de valores que permite seleccionar un empleo
    /// </summary>
    public string? TraCodvliEmpleo { get; set; }

    /// <summary>
    /// ¿Corresponde con una institución externa?
    /// </summary>
    public bool TraEsInstExterna { get; set; }

    /// <summary>
    /// Nombre de una persona contacto, cuando es una institución externa
    /// </summary>
    public string? TraContactoExterno { get; set; }

    /// <summary>
    /// ¿Corresponde con una persona externa?
    /// </summary>
    public bool TraEsPersonaExterna { get; set; }

    /// <summary>
    /// Email de notificaciones si es una persona o institución externa
    /// </summary>
    public string? TraEmailExterno { get; set; }

    /// <summary>
    /// Teléfono de contacto cuando es una persona o institución externa
    /// </summary>
    public string? TraTelefonoExterno { get; set; }

    /// <summary>
    /// Data de los campos adicionales
    /// </summary>
    public string? TraPropertyBagData { get; set; }

    /// <summary>
    /// Usuario que creo el registro
    /// </summary>
    public string? TraUsuarioGrabacion { get; set; }

    /// <summary>
    /// Fecha en que se creo el registro
    /// </summary>
    public DateTime? TraFechaGrabacion { get; set; }

    /// <summary>
    /// Usuario que modificó por última vez el registro
    /// </summary>
    public string? TraUsuarioModificacion { get; set; }

    /// <summary>
    /// Fecha de la última modificacion del registro
    /// </summary>
    public DateTime? TraFechaModificacion { get; set; }

    public virtual ICollection<ActividadPrograma> ActividadesProgramas { get; set; } = new List<ActividadPrograma>();

    public virtual ICollection<PacPlantActividade> PacPlantActividades { get; set; } = new List<PacPlantActividade>();
}
