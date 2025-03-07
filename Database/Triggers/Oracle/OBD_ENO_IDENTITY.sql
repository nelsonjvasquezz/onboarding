CREATE OR REPLACE TRIGGER OBD_ENO_IDENTITY
   BEFORE INSERT ON OBD_ENO_EVENTOS_NOTIFICABLES
   REFERENCING NEW AS NEW OLD AS OLD
   FOR EACH ROW WHEN (NVL(NEW.ENO_CODIGO, 0) = 0)
Begin
   SELECT OBD_ENO_SEQ.NEXTVAL INTO :NEW.ENO_CODIGO FROM DUAL;
End;
/
