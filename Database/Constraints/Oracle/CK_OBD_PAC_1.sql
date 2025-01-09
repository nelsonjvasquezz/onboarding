ALTER TABLE OBD_PAC_PLANT_ACTIVIDADES ADD CONSTRAINT CK_OBD_PAC_1
CHECK ((pac_unidad_duracion='Anios' OR pac_unidad_duracion='Meses' OR pac_unidad_duracion='Semanas' OR pac_unidad_duracion='Dias' OR pac_unidad_duracion='Horas' OR pac_unidad_duracion='Minutos'));
