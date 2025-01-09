ALTER TABLE OBD_PRO_PROGRAMAS ADD CONSTRAINT CK_OBD_PRO_1
CHECK ((pro_estado='Finalizado' OR pro_estado='EnEjecucion' OR pro_estado='Planificado'));
