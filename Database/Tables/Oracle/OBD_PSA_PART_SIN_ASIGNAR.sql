CREATE TABLE OBD_PSA_PART_SIN_ASIGNAR (
   PSA_CODIGO INT NOT NULL,
   PSA_CODPAP INT,
   PSA_CODCON INT,
   PSA_CODCOS INT,
   PSA_CODPUE INT NOT NULL,
   PSA_CODEXP INT NOT NULL,
   PSA_CODEMP INT,
   PSA_CODPLZ INT,
   PSA_CODEMP_JEFE INT NOT NULL,
   PSA_CODCDT INT NOT NULL,
   PSA_CODUNI INT NOT NULL,
   PSA_FECHA_CONTRATACION DATE NOT NULL,
   PSA_USUARIO_GRABACION VARCHAR2(50 CHAR),
   PSA_FECHA_GRABACION DATE,
   PSA_USUARIO_MODIFICACION VARCHAR2(50 CHAR),
   PSA_FECHA_MODIFICACION DATE
);

COMMENT ON TABLE OBD_PSA_PART_SIN_ASIGNAR IS 'Tabla que almacena la información de los empleados participantes sin asignar en un programa de onboarding';

COMMENT ON COLUMN OBD_PSA_PART_SIN_ASIGNAR.PSA_CODIGO IS 'Código de registro del participante sin asignar en un programa de onboarding';
COMMENT ON COLUMN OBD_PSA_PART_SIN_ASIGNAR.PSA_CODPAP IS 'Código del participante cuando ya ha sido asignado a un programa de onboarding';
COMMENT ON COLUMN OBD_PSA_PART_SIN_ASIGNAR.PSA_CODCON IS 'Código de la contratación del participante sin asignar a un programa de onboarding';
COMMENT ON COLUMN OBD_PSA_PART_SIN_ASIGNAR.PSA_CODCOS IS 'Código del concurso de selección donde fue contratado el participante sin asignar a un programa de onboarding';
COMMENT ON COLUMN OBD_PSA_PART_SIN_ASIGNAR.PSA_CODPUE IS 'Código del puesto a donde será contratado el nuevo empleado';
COMMENT ON COLUMN OBD_PSA_PART_SIN_ASIGNAR.PSA_CODEXP IS 'Código de expediente del participante sin asignar a un programa de onboarding';
COMMENT ON COLUMN OBD_PSA_PART_SIN_ASIGNAR.PSA_CODEMP IS 'Código de empleo del participante, cuando la nueva contratación ya se realizó';
COMMENT ON COLUMN OBD_PSA_PART_SIN_ASIGNAR.PSA_CODPLZ IS 'Código de plaza, cuando la nueva contratación ya se realizó';
COMMENT ON COLUMN OBD_PSA_PART_SIN_ASIGNAR.PSA_CODEMP_JEFE IS 'Código del empleo del jefe inmeditato superior o supervisor responsable de la nueva contratación';
COMMENT ON COLUMN OBD_PSA_PART_SIN_ASIGNAR.PSA_CODCDT IS 'Código del centro de trabajo donde será ubicado el nuevo empleado';
COMMENT ON COLUMN OBD_PSA_PART_SIN_ASIGNAR.PSA_CODUNI IS 'Código de la unidad organizativa donde será ubicado el nuevo empleado';
COMMENT ON COLUMN OBD_PSA_PART_SIN_ASIGNAR.PSA_FECHA_CONTRATACION IS 'Fecha efectiva de contratación';
COMMENT ON COLUMN OBD_PSA_PART_SIN_ASIGNAR.PSA_USUARIO_GRABACION IS 'Usuario que creo el registro';
COMMENT ON COLUMN OBD_PSA_PART_SIN_ASIGNAR.PSA_FECHA_GRABACION IS 'Fecha en que se creo el registro';
COMMENT ON COLUMN OBD_PSA_PART_SIN_ASIGNAR.PSA_USUARIO_MODIFICACION IS 'Usuario que modificó por última vez el registro';
COMMENT ON COLUMN OBD_PSA_PART_SIN_ASIGNAR.PSA_FECHA_MODIFICACION IS 'Fecha de la última modificacion del registro';
