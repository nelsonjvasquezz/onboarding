using System.Collections.Generic;

namespace onboarding.data.bases
{
    /// <summary>
    /// Tabla que almacena los requisitos de las actividades del programa de onboarding
    /// obd.rap_req_actividades_prg
    /// </summary>
    public partial class RequisitoActividad
    {
        /// <summary>
        /// Código de Actividad en el programa de onboarding
        /// </summary>
        public int ActividadCodigo { get; set; } // rap_codacp (Primary key)

        /// <summary>
        /// Código de la Actividad Requisito en el programa de onboarding
        /// </summary>
        public int ActividadRequisitoCodigo { get; set; } // rap_codacp_requisito (Primary key)

        /// <summary>
        /// Parent Actividad pointed by [rap_req_actividades_prg].([ActividadCodigo]) (FK_obdacp_obdrpa)
        /// </summary>
        public virtual ActividadPrograma Actividad { get; set; } // FK_obdacp_obdrpa

        /// <summary>
        /// Parent Requisito pointed by [rap_req_actividades_prg].([ActividadRequisitoCodigo]) (FK_obdacp_obdrap_requisito)
        /// </summary>
        public virtual ActividadPrograma Requisito { get; set; } // FK_obdacp_obdrap_requisito
    }
}