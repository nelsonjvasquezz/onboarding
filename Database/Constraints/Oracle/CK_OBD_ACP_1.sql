ALTER TABLE OBD_ACP_ACTIVIDADES_PRG ADD CONSTRAINT CK_OBD_ACP_1
CHECK ((acp_estado='Finalizada' OR acp_estado='EnProceso' OR acp_estado='Pendiente'));
