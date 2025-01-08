SET IDENTITY_INSERT [obd].[pri_prioridades] ON 

INSERT [obd].[pri_prioridades] ([pri_codigo], [pri_codgrc], [pri_nombre], [pri_color], [pri_orden]) VALUES (1, 1, 'Alta', '#FF0000', 1)
INSERT [obd].[pri_prioridades] ([pri_codigo], [pri_codgrc], [pri_nombre], [pri_color], [pri_orden]) VALUES (2, 1, 'Media', '#FFFF00', 2)
INSERT [obd].[pri_prioridades] ([pri_codigo], [pri_codgrc], [pri_nombre], [pri_color], [pri_orden]) VALUES (3, 1, 'Baja', '#00FF00', 3)
SET IDENTITY_INSERT [obd].[pri_prioridades] OFF
GO
