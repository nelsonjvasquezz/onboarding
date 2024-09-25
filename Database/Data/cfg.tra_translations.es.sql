insert into cfg.tra_translations (tra_lok_id, tra_lok_area, tra_lok_keyword, tra_lan_short_name, tra_translation) select lok_id, lok_area, lok_keyword, 'es', 'Notificación enviada cuando el empleado contratado ha comenzado formalmente su programa de onboarding, indicando el inicio de las actividades de integración.' from cfg.lok_localization_keys where lok_area = 'Onboarding' and lok_keyword = 'DescripcionInicioPrograma';
insert into cfg.tra_translations (tra_lok_id, tra_lok_area, tra_lok_keyword, tra_lan_short_name, tra_translation) select lok_id, lok_area, lok_keyword, 'es', 'Notificación para informar sobre la primera evaluación de desempeño del empleado contratado.' from cfg.lok_localization_keys where lok_area = 'Onboarding' and lok_keyword = 'DescripcionPrimeraEvaluacionDesempenio';
insert into cfg.tra_translations (tra_lok_id, tra_lok_area, tra_lok_keyword, tra_lan_short_name, tra_translation) select lok_id, lok_area, lok_keyword, 'es', 'Notificación enviada cuando se ha asignado un mentor al nuevo empleado, indicando que el empleado ahora cuenta con un punto de contacto para apoyo durante su integración.' from cfg.lok_localization_keys where lok_area = 'Onboarding' and lok_keyword = 'DescripcionAsignacionMentor';
insert into cfg.tra_translations (tra_lok_id, tra_lok_area, tra_lok_keyword, tra_lan_short_name, tra_translation) select lok_id, lok_area, lok_keyword, 'es', 'Notificación enviada cuando se ha programado o realizado la reunión de retroalimentación entre el supervisor y el nuevo empleado, para discutir su avance y responder a cualquier inquietud.' from cfg.lok_localization_keys where lok_area = 'Onboarding' and lok_keyword = 'DescripcionReunionRetroalimentacion';
insert into cfg.tra_translations (tra_lok_id, tra_lok_area, tra_lok_keyword, tra_lan_short_name, tra_translation) select lok_id, lok_area, lok_keyword, 'es', 'Notificación enviada cuando se actualiza el plan individual del empleado basado en el progreso durante el onboarding, indicando nuevos objetivos o ajustes.' from cfg.lok_localization_keys where lok_area = 'Onboarding' and lok_keyword = 'DescripcionActualizacionPlan';
insert into cfg.tra_translations (tra_lok_id, tra_lok_area, tra_lok_keyword, tra_lan_short_name, tra_translation) select lok_id, lok_area, lok_keyword, 'es', 'Notificación enviada cuando el nuevo empleado ha completado todas las fases y actividades del programa de onboarding, confirmando que ha pasado con éxito el proceso de integración y está completamente operativo en su rol.' from cfg.lok_localization_keys where lok_area = 'Onboarding' and lok_keyword = 'DescripcionFinPrograma';
insert into cfg.tra_translations (tra_lok_id, tra_lok_area, tra_lok_keyword, tra_lan_short_name, tra_translation) select lok_id, lok_area, lok_keyword, 'es', 'Notificación enviada para recordar al empleado que debe firmar el contrato y entregar toda la documentación requerida para completar su incorporación.' from cfg.lok_localization_keys where lok_area = 'Onboarding' and lok_keyword = 'DescripcionFirmaContrato';
insert into cfg.tra_translations (tra_lok_id, tra_lok_area, tra_lok_keyword, tra_lan_short_name, tra_translation) select lok_id, lok_area, lok_keyword, 'es', 'Notificación enviada para recordar al empleado que debe completar las capacitaciones técnicas requeridas para su rol dentro de la organización.' from cfg.lok_localization_keys where lok_area = 'Onboarding' and lok_keyword = 'DescripcionCapacitacionTecnica';
insert into cfg.tra_translations (tra_lok_id, tra_lok_area, tra_lok_keyword, tra_lan_short_name, tra_translation) select lok_id, lok_area, lok_keyword, 'es', 'Notificación para recordar al empleado que debe revisar las políticas internas de la empresa, como parte del proceso de onboarding.' from cfg.lok_localization_keys where lok_area = 'Onboarding' and lok_keyword = 'DescripcionRevisionPoliticas';
insert into cfg.tra_translations (tra_lok_id, tra_lok_area, tra_lok_keyword, tra_lan_short_name, tra_translation) select lok_id, lok_area, lok_keyword, 'es', 'Notificación para recordar al empleado que debe configurar las herramientas de trabajo necesarias (software y hardware) para realizar sus tareas diarias.' from cfg.lok_localization_keys where lok_area = 'Onboarding' and lok_keyword = 'DescripcionConfiguracionHerramientas';