﻿using System;
using System.Collections.Generic;

namespace onboarding.data.bases;

/// <summary>
/// Tabla que almacena las prioridades de las actividades del plan de onboarding
/// obd.pri_prioridades
/// </summary>
public partial class PrioridadActividad
{
    /// <summary>
    /// Código de la prioridad
    /// </summary>
    public int Codigo { get; set; } // pri_codigo

    /// <summary>
    /// Código de Grupo Corporativo
    /// </summary>
    public int GrupoCorporativoCodigo { get; set; } // pri_codgrc

    /// <summary>
    /// Nombre de la prioridad
    /// </summary>
    public string Nombre { get; set; } // pri_nombre

    /// <summary>
    /// Color con que se muestra la prioridad
    /// </summary>
    public string Color { get; set; } // pri_color

    /// <summary>
    /// Ícono con que se muestra la prioridad
    /// </summary>
    public string Icono { get; set; } // pri_icono

    /// <summary>
    /// Determina el orden las prioridades
    /// </summary>
    public int Orden { get; set; } // pri_orden

    /// <summary>
    /// Data de los campos adicionales
    /// </summary>
    public string RawPropertyBagData { get; set; } // pri_property_bag_data

    /// <summary>
    /// Usuario que creo el registro
    /// </summary>
    public string UsuarioGrabacion { get; set; } // pri_usuario_grabacion

    /// <summary>
    /// Fecha en que se creo el registro
    /// </summary>
    public DateTime? FechaGrabacion { get; set; } // pri_fecha_grabacion

    /// <summary>
    /// Usuario que modificó por última vez el registro
    /// </summary>
    public string UsuarioModificacion { get; set; } // pri_usuario_modificacion

    /// <summary>
    /// Fecha de la última modificacion del registro
    /// </summary>
    public DateTime? FechaModificacion { get; set; } // pri_fecha_modificacion

    // Children collections

    /// <summary>
    /// Child Actividades where [acp_actividades_programa].[acp_codpri] point to this entity (FK_obdpri_obdacp)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual ICollection<ActividadPrograma> Actividades { get; set; } = new List<ActividadPrograma>(); // FK_obdpri_obdacp

    /// <summary>
    /// Child PlantillasDeActividades where [pac_plant_actividades].[pac_codpri] point to this entity (FK_obdpri_obdpac)
    /// </summary>
    [XmlIgnore, JsonIgnore]
    public virtual ICollection<PlantillaActividad> PlantillasDeActividades { get; set; } = new List<PlantillaActividad>(); // FK_obdpri_obdpac
}