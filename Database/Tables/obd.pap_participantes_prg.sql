CREATE TABLE [obd].[pap_participantes_prg]
(
	[pap_codigo] INT IDENTITY(1,1) NOT NULL,
	[pap_codpro] INT NOT NULL,
	[pap_codemp_resp_rrhh] INT NOT NULL,
	[pap_codpue] INT NOT NULL,
	[pap_codexp] INT NOT NULL,
	[pap_codemp] INT NULL,
	[pap_codplz] INT NULL,
	[pap_codemp_jefe] INT NOT NULL,
	[pap_codcdt] INT NOT NULL,
	[pap_coduni] INT NOT NULL,
	[pap_fecha_contratacion] DATETIME NOT NULL,
	[pap_fecha_inicio] DATETIME NOT NULL,
	[pap_fecha_fin] DATETIME NOT NULL,
	[pap_property_bag_data] XML NULL,
	[pap_usuario_grabacion] VARCHAR(50) NULL,
	[pap_fecha_grabacion] DATETIME NULL,
	[pap_usuario_modificacion] VARCHAR(50) NULL,
	[pap_fecha_modificacion] DATETIME NULL,

 	CONSTRAINT [PK_pap_participantes_prg] PRIMARY KEY CLUSTERED ([pap_codigo] ASC),
	CONSTRAINT [FK_obdpro_obdpap] FOREIGN KEY([pap_codpro]) REFERENCES [obd].[pro_programas] ([pro_codigo]) ON DELETE CASCADE,
	CONSTRAINT [FK_expemp_obdpap_resp_rrhh] FOREIGN KEY ([pap_codemp_resp_rrhh]) REFERENCES [exp].[emp_empleos] ([emp_codigo]),
	CONSTRAINT [FK_eorpue_obdpap] FOREIGN KEY ([pap_codpue]) REFERENCES [eor].[pue_puestos] ([pue_codigo]),
	CONSTRAINT [FK_expexp_obdpap] FOREIGN KEY ([pap_codexp]) REFERENCES [exp].[exp_expedientes] ([exp_codigo]),
	CONSTRAINT [FK_expemp_obdpap] FOREIGN KEY ([pap_codemp]) REFERENCES [exp].[emp_empleos] ([emp_codigo]),
    CONSTRAINT [FK_eorplz_obdpap] FOREIGN KEY ([pap_codplz]) REFERENCES [eor].[plz_plazas] ([plz_codigo]),
	CONSTRAINT [FK_expemp_obdpap_jefe] FOREIGN KEY ([pap_codemp_jefe]) REFERENCES [exp].[emp_empleos] ([emp_codigo]),
    CONSTRAINT [FK_eorcdt_obdpap] FOREIGN KEY ([pap_codcdt]) REFERENCES [eor].[cdt_centros_de_trabajo] ([cdt_codigo]),
    CONSTRAINT [FK_eoruni_obdpap] FOREIGN KEY ([pap_coduni]) REFERENCES [eor].[uni_unidades] ([uni_codigo])
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Tabla con el detalle de nuevas contrataciones que participan de un programa de onboarding',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pap_participantes_prg',
    @level2type = NULL,
    @level2name = NULL
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de registro de contratación de cada programa',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pap_participantes_prg',
    @level2type = N'COLUMN',
    @level2name = N'pap_codigo'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código del programa de onboarding',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pap_participantes_prg',
    @level2type = N'COLUMN',
    @level2name = N'pap_codpro'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de expediente de la nueva contratación',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pap_participantes_prg',
    @level2type = N'COLUMN',
    @level2name = N'pap_codexp'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de empleo, cuando la nueva contratación ya se realizó',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pap_participantes_prg',
    @level2type = N'COLUMN',
    @level2name = N'pap_codemp'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha esperada de inicio del programa',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pap_participantes_prg',
    @level2type = N'COLUMN',
    @level2name = N'pap_fecha_inicio'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha efectiva de contratación',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pap_participantes_prg',
    @level2type = N'COLUMN',
    @level2name = N'pap_fecha_contratacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha esperada de finalización del programa',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pap_participantes_prg',
    @level2type = N'COLUMN',
    @level2name = N'pap_fecha_fin'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código del puesto a donde será contratado el nuevo empleado',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pap_participantes_prg',
    @level2type = N'COLUMN',
    @level2name = N'pap_codpue'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código del empleo del jefe inmeditato superior o supervisor responsable de la nueva contratación',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pap_participantes_prg',
    @level2type = N'COLUMN',
    @level2name = N'pap_codemp_jefe'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código del centro de trabajo donde será ubicado el nuevo empleado',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pap_participantes_prg',
    @level2type = N'COLUMN',
    @level2name = N'pap_codcdt'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de la unidad organizativa donde será ubicado el nuevo empleado',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pap_participantes_prg',
    @level2type = N'COLUMN',
    @level2name = N'pap_coduni'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de plaza, cuando la nueva contratación ya se realizó',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pap_participantes_prg',
    @level2type = N'COLUMN',
    @level2name = N'pap_codplz'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código del responsable en RRHH de la nueva contratación',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pap_participantes_prg',
    @level2type = N'COLUMN',
    @level2name = N'pap_codemp_resp_rrhh'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Data de los campos adicionales',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pap_participantes_prg',
    @level2type = N'COLUMN',
    @level2name = N'pap_property_bag_data'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Usuario que creo el registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pap_participantes_prg',
    @level2type = N'COLUMN',
    @level2name = N'pap_usuario_grabacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha en que se creo el registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pap_participantes_prg',
    @level2type = N'COLUMN',
    @level2name = N'pap_fecha_grabacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Usuario que modificó por última vez el registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pap_participantes_prg',
    @level2type = N'COLUMN',
    @level2name = N'pap_usuario_modificacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha de la última modificacion del registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pap_participantes_prg',
    @level2type = N'COLUMN',
    @level2name = N'pap_fecha_modificacion'
GO