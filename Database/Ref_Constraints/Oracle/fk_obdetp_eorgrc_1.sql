ALTER TABLE OBD_ETP_ETAPAS_PRG ADD CONSTRAINT fk_obdetp_eorgrc_1
   FOREIGN KEY (ETP_CODGRC)
   REFERENCES EOR_GRC_GRUPOS_CORPORATIVOS (GRC_CODIGO);
