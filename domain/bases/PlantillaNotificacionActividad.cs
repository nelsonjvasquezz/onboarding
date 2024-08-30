﻿using System;
using System.Collections.Generic;

namespace onboarding.data.bases;

/// <summary>
/// Tabla que almacena los registros de la notificación de la actividad de la plantilla
/// obd.pna_plant_notificacion_act
/// </summary>
public partial class PlantillaNotificacionActividad
{
    /// <summary>
    /// Código de registro de notificaciones de la actividad de la plantilla
    /// </summary>
    public int Codigo { get; set; } // pna_codigo

    /// <summary>
    /// Código de Actividad de la plantilla de programas de onboarding
    /// </summary>
    public int PlantillaActividadCodigo { get; set; } // pna_codpac

    /// <summary>
    /// Determina cual desplazamiento utiliza, si el de fecha inicio o fecha fin
    /// </summary>
    public bool UsaFechaInicio { get; set; } // pna_usa_fecha_inicio

    /// <summary>
    /// Desplamiento en dias antes o despues de la fecha de inicio 
    /// </summary>
    public int OffsetInicio { get; set; } // pna_offset_inicio

    /// <summary>
    /// Desplamiento en dias antes o despues de la fecha de finalizacion
    /// </summary>
    public int OffsetFin { get; set; } // pna_offset_fin

    /// <summary>
    /// Asunto de la notificación
    /// </summary>
    public string Subject { get; set; } = null; // pna_subject

    /// <summary>
    /// Cuerpo Markdown de la notificación
    /// </summary>
    public string Body { get; set; } = null; // pna_body

    /// <summary>
    /// Determina si la notificación se envía al empleado contratado
    /// </summary>
    public bool EnviaContratado { get; set; } // pna_envia_contratado

    /// <summary>
    /// Determina si la notificación se envía al jefe inmediato superior del empleado
    /// </summary>
    public bool EnviaJefe { get; set; } // pna_envia_jefe

    /// <summary>
    /// Determina si la notificación se envía al responsable de la actividad
    /// </summary>
    public bool EnviaResponsable { get; set; } // pna_envia_responsable

    /// <summary>
    /// Data de los campos adicionales
    /// </summary>
    public string RawPropertyBagData { get; set; } // pna_property_bag_data

    /// <summary>
    /// Usuario que creo el registro
    /// </summary>
    public string UsuarioGrabacion { get; set; } // pna_usuario_grabacion

    /// <summary>
    /// Fecha en que se creo el registro
    /// </summary>
    public DateTime? FechaGrabacion { get; set; } // pna_fecha_grabacion

    /// <summary>
    /// Usuario que modificó por última vez el registro
    /// </summary>
    public string UsuarioUltimaModificacion { get; set; } // pna_usuario_modificacion

    /// <summary>
    /// Fecha de la última modificacion del registro
    /// </summary>
    public DateTime? FechaUltimaModificacion { get; set; } // pna_fecha_modificacion

    /// <summary>
    /// Parent PlantillaActividad pointed by [pna_plant_notificacion].([PlantillaActividadCodigo]) (FK_obdpac_obdpna)
    /// </summary>
    public virtual PlantillaActividad PlantillaActividad { get; set; } // FK_obdpac_obdpna
}
