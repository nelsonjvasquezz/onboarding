ALTER TABLE OBD_PAP_PARTICIPANTES_PRG ADD CONSTRAINT fk_obdpap_expemp_3
   FOREIGN KEY (PAP_CODEMP_RESP_RRHH)
   REFERENCES EXP_EMP_EMPLEOS (EMP_CODIGO);
