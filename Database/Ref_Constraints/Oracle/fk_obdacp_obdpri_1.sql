ALTER TABLE OBD_ACP_ACTIVIDADES_PRG ADD CONSTRAINT fk_obdacp_obdpri_1
   FOREIGN KEY (ACP_CODPRI)
   REFERENCES OBD_PRI_PRIORIDADES (PRI_CODIGO);
