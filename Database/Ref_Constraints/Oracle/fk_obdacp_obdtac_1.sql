ALTER TABLE OBD_ACP_ACTIVIDADES_PRG ADD CONSTRAINT fk_obdacp_obdtac_1
   FOREIGN KEY (ACP_CODTAC)
   REFERENCES OBD_TAC_TIPOS_ACTIVIDAD (TAC_CODIGO);