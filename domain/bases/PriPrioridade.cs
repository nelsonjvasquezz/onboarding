using System;
using System.Collections.Generic;

namespace onboarding.data.bases;

/// <summary>
/// Tabla que almacena las prioridades de las actividades del plan de onboarding
/// </summary>
public partial class PriPrioridade
{
    /// <summary>
    /// Código de la prioridad
    /// </summary>
    public int PriCodigo { get; set; }

    /// <summary>
    /// Código de Grupo Corporativo
    /// </summary>
    public int PriCodgrc { get; set; }

    /// <summary>
    /// Nombre de la prioridad
    /// </summary>
    public string PriNombre { get; set; } = null!;

    /// <summary>
    /// Color con que se muestra la prioridad
    /// </summary>
    public string PriColor { get; set; } = null!;

    /// <summary>
    /// Ícono con que se muestra la prioridad
    /// </summary>
    public string? PriIcono { get; set; }

    /// <summary>
    /// Determina el orden las prioridades
    /// </summary>
    public int PriOrden { get; set; }

    /// <summary>
    /// Data de los campos adicionales
    /// </summary>
    public string? PriPropertyBagData { get; set; }

    /// <summary>
    /// Usuario que creo el registro
    /// </summary>
    public string? PriUsuarioGrabacion { get; set; }

    /// <summary>
    /// Fecha en que se creo el registro
    /// </summary>
    public DateTime? PriFechaGrabacion { get; set; }

    /// <summary>
    /// Usuario que modificó por última vez el registro
    /// </summary>
    public string? PriUsuarioModificacion { get; set; }

    /// <summary>
    /// Fecha de la última modificacion del registro
    /// </summary>
    public DateTime? PriFechaModificacion { get; set; }

    public virtual ICollection<ActividadesPrograma> ActividadesProgramas { get; set; } = new List<ActividadesPrograma>();

    public virtual ICollection<PacPlantActividade> PacPlantActividades { get; set; } = new List<PacPlantActividade>();
}
