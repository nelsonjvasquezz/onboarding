ALTER TABLE OBD_PAP_PARTICIPANTES_PRG ADD CONSTRAINT fk_obdpap_eorcdt_1
   FOREIGN KEY (PAP_CODCDT)
   REFERENCES EOR_CDT_CENTROS_DE_TRABAJO (CDT_CODIGO);
