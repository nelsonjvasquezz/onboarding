ALTER TABLE OBD_PSA_PART_SIN_ASIGNAR ADD CONSTRAINT fk_obdpsa_eorcdt_1
   FOREIGN KEY (PSA_CODCDT)
   REFERENCES EOR_CDT_CENTROS_DE_TRABAJO (CDT_CODIGO);