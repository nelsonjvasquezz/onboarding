using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace onboarding.data.bases
{
    /// <summary>
    /// Tabla que almacena la lista de actividades prerequisito de una actividad de la plantilla
    /// obd.ppa_plant_prerequisitos_act
    /// </summary>
    public partial class RequisitoActividadPlantilla
    {
        /// <summary>
        /// Código de Actividad en la plantilla del programa de onboarding
        /// </summary>
        public int ActividadCodigo { get; set; } // ppa_codpac

        /// <summary>
        /// Código de Actividad que es prerequisito
        /// </summary>
        public int ActividadRequisitoCodigo { get; set; } // ppa_codpac_prerequisito

        // Foreign keys

        /// <summary>
        /// Parent ActividadPrograma pointed by [ppa_plant_prerequisitos_act].([PlantillaActividadCodigo]) (FK_obdpac_obdppa)
        /// </summary>
        [XmlIgnore, JsonIgnore]
        public virtual ActividadPlantilla Actividad { get; set; } // FK_obdpac_obdppa

        /// <summary>
        /// Parent ActividadPrograma pointed by [ppa_plant_prerequisitos_act].([PlantillaPrerequisitoCodigo]) (FK_obdpac_obdppa_prerequisito)
        /// </summary>
        [XmlIgnore, JsonIgnore]
        public virtual ActividadPlantilla Requisito { get; set; } // FK_obdpac_obdppa_prerequisito
    }
}