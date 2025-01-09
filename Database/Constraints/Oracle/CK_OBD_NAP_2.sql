ALTER TABLE OBD_NAP_NOTIF_ACTIVIDAD_PRG ADD CONSTRAINT CK_OBD_NAP_2
CHECK ((nap_tipo_destinatario IS NULL OR nap_tipo_destinatario='Participante' OR nap_tipo_destinatario='JefeInmediato' OR nap_tipo_destinatario='ResponsableActividad' OR nap_tipo_destinatario='ResponsableRRHH'));
