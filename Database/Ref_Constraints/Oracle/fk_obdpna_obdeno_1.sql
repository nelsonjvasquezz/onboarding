ALTER TABLE OBD_PNA_PLANT_NOTIFICACION_ACT ADD CONSTRAINT fk_obdpna_obdeno_1
   FOREIGN KEY (PNA_CODENO)
   REFERENCES OBD_ENO_EVENTOS_NOTIFICABLES (ENO_CODIGO);