ALTER TABLE OBD_PAP_PARTICIPANTES_PRG ADD CONSTRAINT fk_obdpap_eorpue_1
   FOREIGN KEY (PAP_CODPUE)
   REFERENCES EOR_PUE_PUESTOS (PUE_CODIGO);