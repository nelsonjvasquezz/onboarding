CREATE OR REPLACE TRIGGER OBD_PSA_IDENTITY
   BEFORE INSERT ON OBD_PSA_PART_SIN_ASIGNAR
   REFERENCING NEW AS NEW OLD AS OLD
   FOR EACH ROW WHEN (NVL(NEW.PSA_CODIGO, 0) = 0)
Begin
   SELECT OBD_PSA_SEQ.NEXTVAL INTO :NEW.PSA_CODIGO FROM DUAL;
End;
/
