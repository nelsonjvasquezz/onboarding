ALTER TABLE OBD_PAC_PLANT_ACTIVIDADES ADD CONSTRAINT fk_obdpac_obdpri_1
   FOREIGN KEY (PAC_CODPRI)
   REFERENCES OBD_PRI_PRIORIDADES (PRI_CODIGO);
