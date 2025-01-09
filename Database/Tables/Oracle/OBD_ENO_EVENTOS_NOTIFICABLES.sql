CREATE TABLE OBD_ENO_EVENTOS_NOTIFICABLES (
   ENO_CODIGO INT NOT NULL,
   ENO_NOMBRE VARCHAR2(100 CHAR) NOT NULL,
   ENO_DESCRIPCION_LOC_KEY VARCHAR2(500 CHAR) NOT NULL
);

COMMENT ON TABLE OBD_ENO_EVENTOS_NOTIFICABLES IS 'Tabla que almacena los eventos que son notificables para el seguimiento de los programas de onboarding';

COMMENT ON COLUMN OBD_ENO_EVENTOS_NOTIFICABLES.ENO_CODIGO IS 'Código de evento notificable';
COMMENT ON COLUMN OBD_ENO_EVENTOS_NOTIFICABLES.ENO_NOMBRE IS 'Nombre del Evento';
COMMENT ON COLUMN OBD_ENO_EVENTOS_NOTIFICABLES.ENO_DESCRIPCION_LOC_KEY IS 'Llave de localización de la descripción del evento que se puede notificar';