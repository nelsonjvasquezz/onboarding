CREATE TABLE OBD_TRA_TIPOS_RESPON_ACTIVIDAD (
   TRA_CODIGO INT NOT NULL,
   TRA_CODGRC INT NOT NULL,
   TRA_NOMBRE VARCHAR2(50 CHAR) NOT NULL,
   TRA_DESCRIPCION VARCHAR2(500 CHAR),
   TRA_ES_PARTICIPANTE NUMBER(1, 0) DEFAULT ((0)) NOT NULL,
   TRA_ES_JEFE NUMBER(1, 0) DEFAULT ((0)) NOT NULL,
   TRA_REQUIERE_EMPLEO NUMBER(1, 0) DEFAULT ((1)) NOT NULL,
   TRA_CODVLI_EMPLEO VARCHAR2(50 CHAR),
   TRA_ES_INST_EXTERNA NUMBER(1, 0) DEFAULT ((0)) NOT NULL,
   TRA_CONTACTO_EXTERNO VARCHAR2(250 CHAR),
   TRA_ES_PERSONA_EXTERNA NUMBER(1, 0) DEFAULT ((0)) NOT NULL,
   TRA_EMAIL_EXTERNO VARCHAR2(100 CHAR),
   TRA_TELEFONO_EXTERNO VARCHAR2(50 CHAR),
   TRA_PROPERTY_BAG_DATA CLOB,
   TRA_USUARIO_GRABACION VARCHAR2(50 CHAR),
   TRA_FECHA_GRABACION DATE,
   TRA_USUARIO_MODIFICACION VARCHAR2(50 CHAR),
   TRA_FECHA_MODIFICACION DATE
);

COMMENT ON TABLE OBD_TRA_TIPOS_RESPON_ACTIVIDAD IS 'Tabla de Tipos de responsables de las Actividades';

COMMENT ON COLUMN OBD_TRA_TIPOS_RESPON_ACTIVIDAD.TRA_CODIGO IS 'Código de Tipo de Responsable de Actividad';
COMMENT ON COLUMN OBD_TRA_TIPOS_RESPON_ACTIVIDAD.TRA_CODGRC IS 'Código de Grupo Corporativo';
COMMENT ON COLUMN OBD_TRA_TIPOS_RESPON_ACTIVIDAD.TRA_NOMBRE IS 'Nombre del Tipo de Responsable de Actividad';
COMMENT ON COLUMN OBD_TRA_TIPOS_RESPON_ACTIVIDAD.TRA_DESCRIPCION IS 'Descripción del Tipo de Responsable de Actividad';
COMMENT ON COLUMN OBD_TRA_TIPOS_RESPON_ACTIVIDAD.TRA_ES_PARTICIPANTE IS '¿El participante es el responsable?';
COMMENT ON COLUMN OBD_TRA_TIPOS_RESPON_ACTIVIDAD.TRA_ES_JEFE IS '¿El jefe inmediato es el responsable?';
COMMENT ON COLUMN OBD_TRA_TIPOS_RESPON_ACTIVIDAD.TRA_REQUIERE_EMPLEO IS '¿Requiere la selección de un empleado?';
COMMENT ON COLUMN OBD_TRA_TIPOS_RESPON_ACTIVIDAD.TRA_CODVLI_EMPLEO IS 'Código de la lista de valores que permite seleccionar un empleo';
COMMENT ON COLUMN OBD_TRA_TIPOS_RESPON_ACTIVIDAD.TRA_ES_INST_EXTERNA IS '¿Corresponde con una institución externa?';
COMMENT ON COLUMN OBD_TRA_TIPOS_RESPON_ACTIVIDAD.TRA_CONTACTO_EXTERNO IS 'Nombre de una persona contacto, cuando es una institución externa';
COMMENT ON COLUMN OBD_TRA_TIPOS_RESPON_ACTIVIDAD.TRA_ES_PERSONA_EXTERNA IS '¿Corresponde con una persona externa?';
COMMENT ON COLUMN OBD_TRA_TIPOS_RESPON_ACTIVIDAD.TRA_EMAIL_EXTERNO IS 'Email de notificaciones si es una persona o institución externa';
COMMENT ON COLUMN OBD_TRA_TIPOS_RESPON_ACTIVIDAD.TRA_TELEFONO_EXTERNO IS 'Teléfono de contacto cuando es una persona o institución externa';
COMMENT ON COLUMN OBD_TRA_TIPOS_RESPON_ACTIVIDAD.TRA_PROPERTY_BAG_DATA IS 'Data de los campos adicionales';
COMMENT ON COLUMN OBD_TRA_TIPOS_RESPON_ACTIVIDAD.TRA_USUARIO_GRABACION IS 'Usuario que creo el registro';
COMMENT ON COLUMN OBD_TRA_TIPOS_RESPON_ACTIVIDAD.TRA_FECHA_GRABACION IS 'Fecha en que se creo el registro';
COMMENT ON COLUMN OBD_TRA_TIPOS_RESPON_ACTIVIDAD.TRA_USUARIO_MODIFICACION IS 'Usuario que modificó por última vez el registro';
COMMENT ON COLUMN OBD_TRA_TIPOS_RESPON_ACTIVIDAD.TRA_FECHA_MODIFICACION IS 'Fecha de la última modificacion del registro';
