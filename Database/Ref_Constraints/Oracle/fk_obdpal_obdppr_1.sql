ALTER TABLE OBD_PAL_PLANT_ALCANCES ADD CONSTRAINT fk_obdpal_obdppr_1
   FOREIGN KEY (PAL_CODPPR)
   REFERENCES OBD_PPR_PLANTILLA_PRG (PPR_CODIGO) ON DELETE CASCADE;