ALTER TABLE OBD_PPR_PLANTILLA_PRG ADD CONSTRAINT CK_OBD_PPR_2
CHECK ((ppr_unidad_duracion='Anios' OR ppr_unidad_duracion='Meses' OR ppr_unidad_duracion='Semanas' OR ppr_unidad_duracion='Dias' OR ppr_unidad_duracion='Horas' OR ppr_unidad_duracion='Minutos'));
