ALTER TABLE OBD_PRI_PRIORIDADES ADD CONSTRAINT fk_obdpri_eorgrc_1
   FOREIGN KEY (PRI_CODGRC)
   REFERENCES EOR_GRC_GRUPOS_CORPORATIVOS (GRC_CODIGO);