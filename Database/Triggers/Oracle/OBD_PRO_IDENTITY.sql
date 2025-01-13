CREATE OR REPLACE TRIGGER OBD_PRO_IDENTITY
   BEFORE INSERT ON OBD_PRO_PROGRAMAS
   REFERENCING NEW AS NEW OLD AS OLD
   FOR EACH ROW WHEN (NVL(NEW.PRO_CODIGO, 0) = 0)
Begin
   SELECT OBD_PRO_SEQ.NEXTVAL INTO :NEW.PRO_CODIGO FROM DUAL;
End;
/