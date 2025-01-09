ALTER TABLE OBD_ACP_ACTIVIDADES_PRG ADD CONSTRAINT CK_OBD_ACP_2
CHECK ((acp_resultado_evaluacion='Reprobado' OR acp_resultado_evaluacion='Aprobado'));
