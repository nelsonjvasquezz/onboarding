ALTER TABLE OBD_PPR_PLANTILLA_PRG ADD CONSTRAINT CK_OBD_PPR_1
CHECK ((ppr_estado='Inactivo' OR ppr_estado='Activo'));
