ALTER TABLE OBD_TAC_TIPOS_ACTIVIDAD ADD CONSTRAINT CK_OBD_TAC_1
CHECK ((tac_unidad_duracion='Anios' OR tac_unidad_duracion='Meses' OR tac_unidad_duracion='Semanas' OR tac_unidad_duracion='Dias' OR tac_unidad_duracion='Horas' OR tac_unidad_duracion='Minutos'));
