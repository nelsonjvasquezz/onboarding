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
    public int Codigo { get; set; }

    /// <summary>
    /// Código de Grupo Corporativo
    /// </summary>
    public int GrupoCorporativoCodigo { get; set; }

    /// <summary>
    /// Nombre del Tipo de Resonsable de Actividad
    /// </summary>
    public string Nombre { get; set; } = null!;

    /// <summary>
    /// Descripción del Tipo de Resonsable de Actividad
    /// </summary>
    public string? Descripcion { get; set; }

    /// <summary>
    /// ¿Requiere la selección de un empleado?
    /// </summary>
    public bool RequiereEmpleo { get; set; }

    /// <summary>
    /// Código de la lista de valores que permite seleccionar un empleo
    /// </summary>
    public string? EmpleoValueListCodigo { get; set; }

    /// <summary>
    /// ¿Corresponde con una institución externa?
    /// </summary>
    public bool EsInstExterna { get; set; }

    /// <summary>
    /// Nombre de una persona contacto, cuando es una institución externa
    /// </summary>
    public string? ContactoExterno { get; set; }

    /// <summary>
    /// ¿Corresponde con una persona externa?
    /// </summary>
    public bool EsPersonaExterna { get; set; }

    /// <summary>
    /// Email de notificaciones si es una persona o institución externa
    /// </summary>
    public string? EmailExterno { get; set; }

    /// <summary>
    /// Teléfono de contacto cuando es una persona o institución externa
    /// </summary>
    public string? TelefonoExterno { get; set; }

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

    public virtual ICollection<PlantillaActividad> PlantillaActividades { get; set; } = new List<PlantillaActividad>();
}
