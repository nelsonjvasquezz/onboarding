CREATE TABLE [obd].[psa_part_sin_asignar]
(
	[psa_codigo] INT IDENTITY(1,1) NOT NULL,
    [psa_codpap] INT NULL,
    [psa_codcon] INT NULL,
    [psa_codcos] INT NULL,
	[psa_codpue] INT NOT NULL,
	[psa_codexp] INT NOT NULL,
	[psa_codemp] INT NULL,
	[psa_codplz] INT NULL,
    [psa_codemp_jefe] INT NOT NULL,
	[psa_codcdt] INT NOT NULL,
	[psa_coduni] INT NOT NULL,
	[psa_fecha_contratacion] DATETIME NOT NULL,
	[psa_usuario_grabacion] VARCHAR(50) NULL,
	[psa_fecha_grabacion] DATETIME NULL,
	[psa_usuario_modificacion] VARCHAR(50) NULL,
	[psa_fecha_modificacion] DATETIME NULL,

 	CONSTRAINT [PK_psa_part_sin_asignar] PRIMARY KEY CLUSTERED ([psa_codigo] ASC),
    CONSTRAINT [FK_obdpap_obdpsa] FOREIGN KEY([psa_codpap]) REFERENCES [obd].[pap_participantes_prg] ([pap_codigo]),
	CONSTRAINT [FK_eorpue_obdpsa] FOREIGN KEY ([psa_codpue]) REFERENCES [eor].[pue_puestos] ([pue_codigo]),
	CONSTRAINT [FK_expexp_obdpsa] FOREIGN KEY ([psa_codexp]) REFERENCES [exp].[exp_expedientes] ([exp_codigo]),
	CONSTRAINT [FK_expemp_obdpsa] FOREIGN KEY ([psa_codemp]) REFERENCES [exp].[emp_empleos] ([emp_codigo]),
    CONSTRAINT [FK_eorplz_obdpsa] FOREIGN KEY ([psa_codplz]) REFERENCES [eor].[plz_plazas] ([plz_codigo]),
    CONSTRAINT [FK_expemp_obdpsa_jefe] FOREIGN KEY ([psa_codemp_jefe]) REFERENCES [exp].[emp_empleos] ([emp_codigo]),
    CONSTRAINT [FK_eorcdt_obdpsa] FOREIGN KEY ([psa_codcdt]) REFERENCES [eor].[cdt_centros_de_trabajo] ([cdt_codigo]),
    CONSTRAINT [FK_eoruni_obdpsa] FOREIGN KEY ([psa_coduni]) REFERENCES [eor].[uni_unidades] ([uni_codigo])
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Tabla que almacena la información de los empleados participantes sin asignar en un programa de onboarding',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'psa_part_sin_asignar',
    @level2type = NULL,
    @level2name = NULL
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de registro del participante sin asignar en un programa de onboarding',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'psa_part_sin_asignar',
    @level2type = N'COLUMN',
    @level2name = N'psa_codigo'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código del participante cuando ya ha sido asignado a un programa de onboarding',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'psa_part_sin_asignar',
    @level2type = N'COLUMN',
    @level2name = N'psa_codpap'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de la contratación del participante sin asignar a un programa de onboarding',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'psa_part_sin_asignar',
    @level2type = N'COLUMN',
    @level2name = N'psa_codcon'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código del concurso de selección donde fue contratado el participante sin asignar a un programa de onboarding',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'psa_part_sin_asignar',
    @level2type = N'COLUMN',
    @level2name = N'psa_codcos'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de expediente del participante sin asignar a un programa de onboarding',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'psa_part_sin_asignar',
    @level2type = N'COLUMN',
    @level2name = N'psa_codexp'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de empleo del participante, cuando la nueva contratación ya se realizó',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'psa_part_sin_asignar',
    @level2type = N'COLUMN',
    @level2name = N'psa_codemp'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha efectiva de contratación',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'psa_part_sin_asignar',
    @level2type = N'COLUMN',
    @level2name = N'psa_fecha_contratacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código del puesto a donde será contratado el nuevo empleado',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'psa_part_sin_asignar',
    @level2type = N'COLUMN',
    @level2name = N'psa_codpue'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código del empleo del jefe inmeditato superior o supervisor responsable de la nueva contratación',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'psa_part_sin_asignar',
    @level2type = N'COLUMN',
    @level2name = N'psa_codemp_jefe'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código del centro de trabajo donde será ubicado el nuevo empleado',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'psa_part_sin_asignar',
    @level2type = N'COLUMN',
    @level2name = N'psa_codcdt'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de la unidad organizativa donde será ubicado el nuevo empleado',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'psa_part_sin_asignar',
    @level2type = N'COLUMN',
    @level2name = N'psa_coduni'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de plaza, cuando la nueva contratación ya se realizó',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'psa_part_sin_asignar',
    @level2type = N'COLUMN',
    @level2name = N'psa_codplz'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Usuario que creo el registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'psa_part_sin_asignar',
    @level2type = N'COLUMN',
    @level2name = N'psa_usuario_grabacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha en que se creo el registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'psa_part_sin_asignar',
    @level2type = N'COLUMN',
    @level2name = N'psa_fecha_grabacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Usuario que modificó por última vez el registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'psa_part_sin_asignar',
    @level2type = N'COLUMN',
    @level2name = N'psa_usuario_modificacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha de la última modificacion del registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'psa_part_sin_asignar',
    @level2type = N'COLUMN',
    @level2name = N'psa_fecha_modificacion'
GO