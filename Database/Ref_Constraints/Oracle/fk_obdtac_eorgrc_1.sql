ALTER TABLE OBD_TAC_TIPOS_ACTIVIDAD ADD CONSTRAINT fk_obdtac_eorgrc_1
   FOREIGN KEY (TAC_CODGRC)
   REFERENCES EOR_GRC_GRUPOS_CORPORATIVOS (GRC_CODIGO);
