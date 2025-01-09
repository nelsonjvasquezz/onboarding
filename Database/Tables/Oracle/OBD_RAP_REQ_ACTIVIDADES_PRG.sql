CREATE TABLE OBD_RAP_REQ_ACTIVIDADES_PRG (
   RAP_CODACP INT NOT NULL,
   RAP_CODACP_REQUISITO INT NOT NULL
);

COMMENT ON TABLE OBD_RAP_REQ_ACTIVIDADES_PRG IS 'Tabla que almacena los requisitos de las actividades del programa de onboarding';

COMMENT ON COLUMN OBD_RAP_REQ_ACTIVIDADES_PRG.RAP_CODACP IS 'Código de Actividad en el programa de onboarding';
COMMENT ON COLUMN OBD_RAP_REQ_ACTIVIDADES_PRG.RAP_CODACP_REQUISITO IS 'Código de Actividad requisito en el programa de onboarding';
