using System.Collections.Generic;

namespace onboarding.data.bases
{
    /// <summary>
    /// Tabla que almacena los requisitos de las actividades del programa de onboarding
    /// obd.rap_req_actividades_programa
    /// </summary>
    public partial class RequisitoActividad
    {
        /// <summary>
        /// Código de Actividad en el programa de onboarding
        /// </summary>
        public int ActividadCodigo { get; set; } // rap_codacp (Primary key)

        /// <summary>
        /// Código de Actividad Prerequisito en el programa de onboarding
        /// </summary>
        public int ActividadRequisitoCodigo { get; set; } // rap_codacp_prerequisito (Primary key)

        /// <summary>
        /// Parent ActividadPrograma pointed by [rap_req_actividades_programa].([ActividadCodigo]) (FK_obdacp_obdrpa)
        /// </summary>
        public virtual ActividadPrograma Actividad { get; set; }

        /// <summary>
        /// Parent ActividadPrograma pointed by [rap_req_actividades_programa].([ActividadPrerequisitoCodigo]) (FK_obdacp_obdrap_prerequisito)
        /// </summary>
        public virtual ActividadPrograma Requisito { get; set; }
    }
}