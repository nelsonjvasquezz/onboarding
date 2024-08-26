using System;
using System.Collections.Generic;

namespace onboarding.data.bases;

/// <summary>
/// Tabla que almacena la plantilla para los programas de onboarding
/// obd.ppr_plant_programa
/// </summary>
public partial class PlantillaPrograma
{
    /// <summary>
    /// Código de plantilla de programa de onboarding
    /// </summary>
    public int Codigo { get; set; }

    /// <summary>
    /// Código de Grupo Corporativo
    /// </summary>
    public int GurpoCorporativoCodigo { get; set; }

    /// <summary>
    /// Nombre del programa de onboarding
    /// </summary>
    public string Nombre { get; set; }

    /// <summary>
    /// Descripción del programa de onboarding
    /// </summary>
    public string Descripcion { get; set; }

    /// <summary>
    /// Objetivos del programa de onboarding
    /// </summary>
    public string Objetivo { get; set; }

    /// <summary>
    /// Estado de la plantilla &apos;Activa&apos; o &apos;Inactiva&apos;  (inactivas para fines de guardar históricos y que no aparezcan en la selección)
    /// </summary>
    public string Estado { get; set; }

    /// <summary>
    /// Duración estimada del programa
    /// </summary>
    public int DuracionEstimada { get; set; }

    /// <summary>
    /// Unidad de medida de la duración estimada del programa
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

    public virtual ICollection<PlantillaActividad> PlantillaActividades { get; set; } = new List<PlantillaActividad>();

    public virtual ICollection<AlcancePlantillaPrograma> Alcances { get; set; } = new List<AlcancePlantillaPrograma>();

    public virtual ICollection<Programa> Programa { get; set; } = new List<Programa>();
}
