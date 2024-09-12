using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace onboarding.data.bases
{
    /// <summary>
    /// Tabla que almacena la lista de actividades requisito de una actividad de la plantilla
    /// obd.ppa_plant_requisitos_act
    /// </summary>
    public partial class RequisitoActividadPlantilla
    {
        /// <summary>
        /// Código de Actividad en la plantilla del programa de onboarding
        /// </summary>
        public int ActividadCodigo { get; set; } // ppa_codpac

        /// <summary>
        /// Código de Actividad que es requisito
        /// </summary>
        public int ActividadRequisitoCodigo { get; set; } // ppa_codpac_requisito

        // Foreign keys

        /// <summary>
        /// Parent Actividad pointed by [ppa_plant_requisitos_act].(ActividadCodigo]) (FK_obdpac_obdppa)
        /// </summary>
        [XmlIgnore, JsonIgnore]
        public virtual ActividadPlantilla Actividad { get; set; } // FK_obdpac_obdppa

        /// <summary>
        /// Parent Requisito pointed by [ppa_plant_requisitos_act].([ActividadRequisitoCodigo]) (FK_obdpac_obdppa_requisito)
        /// </summary>
        [XmlIgnore, JsonIgnore]
        public virtual ActividadPlantilla Requisito { get; set; } // FK_obdpac_obdppa_requisito
    }
}