CREATE TABLE OBD_PPA_PLANT_REQUISITOS_ACT (
   PPA_CODPAC INT NOT NULL,
   PPA_CODPAC_REQUISITO INT NOT NULL
);

COMMENT ON TABLE OBD_PPA_PLANT_REQUISITOS_ACT IS 'Tabla que almacena la lista de actividades requisito de una actividad de la plantilla';

COMMENT ON COLUMN OBD_PPA_PLANT_REQUISITOS_ACT.PPA_CODPAC IS 'Código de Actividad en la plantilla del programa de onboarding';
COMMENT ON COLUMN OBD_PPA_PLANT_REQUISITOS_ACT.PPA_CODPAC_REQUISITO IS 'Código de Actividad que es requisito';
