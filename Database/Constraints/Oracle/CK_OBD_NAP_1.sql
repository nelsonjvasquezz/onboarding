ALTER TABLE OBD_NAP_NOTIF_ACTIVIDAD_PRG ADD CONSTRAINT CK_OBD_NAP_1
CHECK ((nap_estado='Error' OR nap_estado='Enviado' OR nap_estado='Pendiente'));
