CREATE OR REPLACE TRIGGER OBD_TRA_IDENTITY
   BEFORE INSERT ON OBD_TRA_TIPOS_RESPON_ACTIVIDAD
   REFERENCING NEW AS NEW OLD AS OLD
   FOR EACH ROW WHEN (NVL(NEW.TRA_CODIGO, 0) = 0)
Begin
   SELECT OBD_TRA_SEQ.NEXTVAL INTO :NEW.TRA_CODIGO FROM DUAL;
End;
/