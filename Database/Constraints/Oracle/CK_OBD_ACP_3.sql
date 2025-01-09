ALTER TABLE OBD_ACP_ACTIVIDADES_PRG ADD CONSTRAINT CK_OBD_ACP_3
CHECK ((acp_unidad_duracion='Anios' OR acp_unidad_duracion='Meses' OR acp_unidad_duracion='Semanas' OR acp_unidad_duracion='Dias' OR acp_unidad_duracion='Horas' OR acp_unidad_duracion='Minutos'));
