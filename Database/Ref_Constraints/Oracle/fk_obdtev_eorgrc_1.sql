ALTER TABLE OBD_TEV_TIPOS_EVALUACION ADD CONSTRAINT fk_obdtev_eorgrc_1
   FOREIGN KEY (TEV_CODGRC)
   REFERENCES EOR_GRC_GRUPOS_CORPORATIVOS (GRC_CODIGO);
