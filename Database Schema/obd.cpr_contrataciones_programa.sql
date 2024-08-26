CREATE TABLE [obd].[cpr_contrataciones_programa]
(
    [cpr_codigo] INT IDENTITY(1,1) NOT NULL,
    [cpr_codpro] INT NOT NULL,
    [cpr_codemp_resp_rrhh] INT NOT NULL,
    [cpr_codpue] INT NOT NULL,
    [cpr_codexp] INT NOT NULL,
    [cpr_codemp] INT NULL,
    [cpr_codemp_jefe] INT NOT NULL,
    [cpr_codcdt] INT NOT NULL,
    [cpr_coduni] INT NOT NULL,
    [cpr_fecha_contratacion] DATETIME NOT NULL,
    [cpr_fecha_inicio] DATETIME NOT NULL,
    [cpr_fecha_fin] DATETIME NOT NULL,
    [cpr_property_bag_data] XML NULL,
    [cpr_usuario_grabacion] VARCHAR(50) NULL,
    [cpr_fecha_grabacion] DATETIME NULL,
    [cpr_usuario_modificacion] VARCHAR(50) NULL,
    [cpr_fecha_modificacion] DATETIME NULL,


    CONSTRAINT [PK_cpr_contrataciones_programa] PRIMARY KEY CLUSTERED ([cpr_codigo] ASC),
    CONSTRAINT [FK_obdpro_obdcpr] FOREIGN KEY ([cpr_codpro]) REFERENCES [obd].[pro_programas] ([pro_codigo]),
    CONSTRAINT [FK_expexp_obdcpr] FOREIGN KEY ([cpr_codexp]) REFERENCES [exp].[exp_expedientes] ([exp_codigo]),
    CONSTRAINT [FK_expemp_obdcpr] FOREIGN KEY ([cpr_codemp]) REFERENCES [exp].[emp_empleos] ([emp_codigo]),
    CONSTRAINT [FK_expemp_obdcpr_jefe] FOREIGN KEY ([cpr_codemp_jefe]) REFERENCES [exp].[emp_empleos] ([emp_codigo]),
    CONSTRAINT [FK_expemp_obdcpr_resp_rrhh] FOREIGN KEY ([cpr_codemp_resp_rrhh]) REFERENCES [exp].[emp_empleos] ([emp_codigo]),
    CONSTRAINT [FK_eorpue_obdcpr] FOREIGN KEY ([cpr_codpue]) REFERENCES [eor].[pue_puestos] ([pue_codigo]),
    CONSTRAINT [FK_eorcdt_obdcpr] FOREIGN KEY ([cpr_codcdt]) REFERENCES [eor].[cdt_centros_de_trabajo] ([cdt_codigo]),
    CONSTRAINT [FK_eoruni_obdcpr] FOREIGN KEY ([cpr_coduni]) REFERENCES [eor].[uni_unidades] ([uni_codigo])


)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Tabla con el detalle de nuevas contrataciones que participan de un programa de onboarding',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'cpr_contrataciones_programa',
    @level2type = NULL,
    @level2name = NULL
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de registro de contratación de cada programa',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'cpr_contrataciones_programa',
    @level2type = N'COLUMN',
    @level2name = N'cpr_codigo'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código del programa de onboarding',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'cpr_contrataciones_programa',
    @level2type = N'COLUMN',
    @level2name = N'cpr_codpro'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de expediente de la nueva contratación',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'cpr_contrataciones_programa',
    @level2type = N'COLUMN',
    @level2name = N'cpr_codexp'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de empleo, cuando la nueva contratación ya se realizó',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'cpr_contrataciones_programa',
    @level2type = N'COLUMN',
    @level2name = N'cpr_codemp'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha esperada de inicio del programa',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'cpr_contrataciones_programa',
    @level2type = N'COLUMN',
    @level2name = N'cpr_fecha_inicio'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha efectiva de contratación',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'cpr_contrataciones_programa',
    @level2type = N'COLUMN',
    @level2name = N'cpr_fecha_contratacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha esperada de finalización del programa',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'cpr_contrataciones_programa',
    @level2type = N'COLUMN',
    @level2name = N'cpr_fecha_fin'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código del puesto a donde será contratado el nuevo empleado',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'cpr_contrataciones_programa',
    @level2type = N'COLUMN',
    @level2name = N'cpr_codpue'
GO

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código del empleo del jefe inmeditato superior o supervisor responsable de la nueva contratación',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'cpr_contrataciones_programa',
    @level2type = N'COLUMN',
    @level2name = N'cpr_codemp_jefe'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código del centro de trabajo donde será ubicado el nuevo empleado',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'cpr_contrataciones_programa',
    @level2type = N'COLUMN',
    @level2name = N'cpr_codcdt'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de la unidad organizativa donde será ubicado el nuevo empleado',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'cpr_contrataciones_programa',
    @level2type = N'COLUMN',
    @level2name = N'cpr_coduni'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Data de los campos adicionales',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'cpr_contrataciones_programa',
    @level2type = N'COLUMN',
    @level2name = N'cpr_property_bag_data'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Usuario que creo el registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'cpr_contrataciones_programa',
    @level2type = N'COLUMN',
    @level2name = N'cpr_usuario_grabacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha en que se creo el registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'cpr_contrataciones_programa',
    @level2type = N'COLUMN',
    @level2name = N'cpr_fecha_grabacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Usuario que modificó por última vez el registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'cpr_contrataciones_programa',
    @level2type = N'COLUMN',
    @level2name = N'cpr_usuario_modificacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha de la última modificacion del registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'cpr_contrataciones_programa',
    @level2type = N'COLUMN',
    @level2name = N'cpr_fecha_modificacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código del responsable en RRHH de la nueva contratación',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'cpr_contrataciones_programa',
    @level2type = N'COLUMN',
    @level2name = N'cpr_codemp_resp_rrhh'