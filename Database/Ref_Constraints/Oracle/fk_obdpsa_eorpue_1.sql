ALTER TABLE OBD_PSA_PART_SIN_ASIGNAR ADD CONSTRAINT fk_obdpsa_eorpue_1
   FOREIGN KEY (PSA_CODPUE)
   REFERENCES EOR_PUE_PUESTOS (PUE_CODIGO);
