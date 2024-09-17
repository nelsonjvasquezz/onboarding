SET IDENTITY_INSERT [obd].[tev_tipos_evaluacion] ON 

INSERT [obd].[tev_tipos_evaluacion] ([tev_codigo], [tev_codgrc], [tev_nombre], [tev_descripcion], [tev_utiliza_fdi], [tev_codfdi_evaluacion]) VALUES (1, 1, 'Evaluación de Desempeño Inicial', 'Evaluación formal del desempeño del empleado durante sus primeros 90 días, basada en metas y expectativas iniciales.', 0, NULL)
INSERT [obd].[tev_tipos_evaluacion] ([tev_codigo], [tev_codgrc], [tev_nombre], [tev_descripcion], [tev_utiliza_fdi], [tev_codfdi_evaluacion]) VALUES (2, 1, 'Evaluación de Adaptación', 'Evaluación de cómo se adapta el nuevo empleado al entorno de trabajo durante el periodo de prueba.', 0, NULL)
INSERT [obd].[tev_tipos_evaluacion] ([tev_codigo], [tev_codgrc], [tev_nombre], [tev_descripcion], [tev_utiliza_fdi], [tev_codfdi_evaluacion]) VALUES (3, 1, 'Evaluación por Entrevista con Supervisor', 'Entrevista en persona donde el supervisor evalúa la integración del empleado en su equipo y su desempeño inicial.', 0, NULL, )
INSERT [obd].[tev_tipos_evaluacion] ([tev_codigo], [tev_codgrc], [tev_nombre], [tev_descripcion], [tev_utiliza_fdi], [tev_codfdi_evaluacion]) VALUES (4, 1, 'Evaluación de Habilidades Técnicas Iniciales', 'Evaluación directa por parte de un especialista técnico para medir el conocimiento práctico del empleado en sus primeras semanas.', 0, NULL)
INSERT [obd].[tev_tipos_evaluacion] ([tev_codigo], [tev_codgrc], [tev_nombre], [tev_descripcion], [tev_utiliza_fdi], [tev_codfdi_evaluacion]) VALUES (5, 1, 'Retroalimentación 360 del Equipo', 'Evaluación basada en la retroalimentación recibida por compañeros de trabajo y colaboradores directos sobre el desempeño y colaboración del empleado.', 0, NULL)
SET IDENTITY_INSERT [obd].[tev_tipos_evaluacion] OFF
GO
