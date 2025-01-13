CREATE OR REPLACE TRIGGER OBD_PAL_COMP_COL
   BEFORE INSERT OR UPDATE
   OF pal_codtpp, pal_codpue, pal_codcdt, pal_coduni
   ON OBD_PAL_PLANT_ALCANCES
   REFERENCING NEW AS NEW OLD AS OLD
   FOR EACH ROW
BEGIN
   if (not :old.pal_codtpp is null) then
      :new.pal_tipo := 'TipoPuesto';
   elsif (not :old.pal_codpue is null) then
      :new.pal_tipo := 'Puesto';
   elsif (not :old.pal_codcdt is null) then
      :new.pal_tipo := 'CentroTrabajo';
   elsif (not :old.pal_coduni is null) then
      :new.pal_tipo := 'UnidadOrganizativa';
   else
      :new.pal_tipo := 'Default';
   end if;
END;
/
