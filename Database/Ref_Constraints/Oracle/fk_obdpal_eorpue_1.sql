ALTER TABLE OBD_PAL_PLANT_ALCANCES ADD CONSTRAINT fk_obdpal_eorpue_1
   FOREIGN KEY (PAL_CODPUE)
   REFERENCES EOR_PUE_PUESTOS (PUE_CODIGO);
