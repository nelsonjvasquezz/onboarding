ALTER TABLE OBD_PAP_PARTICIPANTES_PRG ADD CONSTRAINT fk_obdpap_eorplz_1
   FOREIGN KEY (PAP_CODPLZ)
   REFERENCES EOR_PLZ_PLAZAS (PLZ_CODIGO);
