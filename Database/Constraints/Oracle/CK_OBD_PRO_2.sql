ALTER TABLE OBD_PRO_PROGRAMAS ADD CONSTRAINT CK_OBD_PRO_2
CHECK ((pro_unidad_duracion='Anios' OR pro_unidad_duracion='Meses' OR pro_unidad_duracion='Semanas' OR pro_unidad_duracion='Dias' OR pro_unidad_duracion='Horas' OR pro_unidad_duracion='Minutos'));
