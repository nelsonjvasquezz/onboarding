ALTER TABLE OBD_PAC_PLANT_ACTIVIDADES ADD CONSTRAINT CK_OBD_PAC_2
CHECK ((pac_unidad_offset_inicio='Anios' OR pac_unidad_offset_inicio='Meses' OR pac_unidad_offset_inicio='Semanas' OR pac_unidad_offset_inicio='Dias' OR pac_unidad_offset_inicio='Horas' OR pac_unidad_offset_inicio='Minutos'));
