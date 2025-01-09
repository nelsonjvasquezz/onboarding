CREATE TABLE OBD_TEV_TIPOS_EVALUACION (
   TEV_CODIGO INT NOT NULL,
   TEV_CODGRC INT NOT NULL,
   TEV_NOMBRE VARCHAR2(100 CHAR) NOT NULL,
   TEV_DESCRIPCION VARCHAR2(500 CHAR),
   TEV_UTILIZA_FDI NUMBER(1, 0) DEFAULT ((0)) NOT NULL,
   TEV_CODFDI_EVALUACION INT,
   TEV_PROPERTY_BAG_DATA CLOB,
   TEV_USUARIO_GRABACION VARCHAR2(50 CHAR),
   TEV_FECHA_GRABACION DATE,
   TEV_USUARIO_MODIFICACION VARCHAR2(50 CHAR),
   TEV_FECHA_MODIFICACION DATE
);

COMMENT ON TABLE OBD_TEV_TIPOS_EVALUACION IS 'Tabla con los tipos de evaluaciones que se aplican a las actividades de los planes de onboarding';

COMMENT ON COLUMN OBD_TEV_TIPOS_EVALUACION.TEV_CODIGO IS 'Código del tipo de evaluación';
COMMENT ON COLUMN OBD_TEV_TIPOS_EVALUACION.TEV_CODGRC IS 'Código del Grupo Corporativo';
COMMENT ON COLUMN OBD_TEV_TIPOS_EVALUACION.TEV_NOMBRE IS 'Nombre del tipo de evaluación';
COMMENT ON COLUMN OBD_TEV_TIPOS_EVALUACION.TEV_DESCRIPCION IS 'Descripción del tipo de evaluación';
COMMENT ON COLUMN OBD_TEV_TIPOS_EVALUACION.TEV_UTILIZA_FDI IS 'Determina si el tipo de evaluación utiliza un formulario dinámico';
COMMENT ON COLUMN OBD_TEV_TIPOS_EVALUACION.TEV_CODFDI_EVALUACION IS 'Código de formulario dinámico que se utiliza para evaluar una actividad cuando si se utiliza';
COMMENT ON COLUMN OBD_TEV_TIPOS_EVALUACION.TEV_PROPERTY_BAG_DATA IS 'Data de los campos adicionales';
COMMENT ON COLUMN OBD_TEV_TIPOS_EVALUACION.TEV_USUARIO_GRABACION IS 'Usuario que creo el registro';
COMMENT ON COLUMN OBD_TEV_TIPOS_EVALUACION.TEV_FECHA_GRABACION IS 'Fecha en que se creo el registro';
COMMENT ON COLUMN OBD_TEV_TIPOS_EVALUACION.TEV_USUARIO_MODIFICACION IS 'Usuario que modificó por última vez el registro';
COMMENT ON COLUMN OBD_TEV_TIPOS_EVALUACION.TEV_FECHA_MODIFICACION IS 'Fecha de la última modificacion del registro';