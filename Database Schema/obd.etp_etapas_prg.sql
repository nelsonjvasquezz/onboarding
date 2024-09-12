CREATE TABLE [obd].[etp_etapas_prg]
(
	[etp_codigo] INT IDENTITY(1,1) NOT NULL,
	[etp_codgrc] INT NOT NULL,
	[etp_nombre] VARCHAR(100) NOT NULL,
	[etp_descripcion] VARCHAR(500) NULL,
	[etp_orden] INT CONSTRAINT [DF_obd_etp_orden] DEFAULT ((0)) NOT NULL,
	[etp_antes_primer_dia] BIT CONSTRAINT [DF_obd_etp_antes_primer_dia] DEFAULT ((0)) NOT NULL,
	[etp_durante_primer_dia] BIT CONSTRAINT [DF_obd_etp_durante_primer_dia] DEFAULT ((0)) NOT NULL,
	[etp_posterior_primer_dia] BIT CONSTRAINT [DF_obd_etp_posterior_primer_dia] DEFAULT ((0)) NOT NULL,
	[etp_periodo_prueba] BIT CONSTRAINT [DF_obd_etp_periodo_prueba] DEFAULT ((0)) NOT NULL,
	[etp_property_bag_data] XML NULL,
	[etp_usuario_grabacion] VARCHAR(50) NULL,
	[etp_fecha_grabacion] DATETIME NULL,
	[etp_usuario_modificacion] VARCHAR(50) NULL,
	[etp_fecha_modificacion] DATETIME NULL,

 	CONSTRAINT [PK_etp_etapas_prg] PRIMARY KEY CLUSTERED ([etp_codigo] ASC),
	CONSTRAINT [FK_eorgrc_obdetp] FOREIGN KEY ([etp_codgrc]) REFERENCES [eor].[grc_grupos_corporativos] ([grc_codigo])
) 

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Tabla con las fases o etapas de los programas de Onboarding',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'etp_etapas_prg',
    @level2type = NULL,
    @level2name = NULL
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de la etapa del programa',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'etp_etapas_prg',
    @level2type = N'COLUMN',
    @level2name = N'etp_codigo'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Descripción de la etapa del programa',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'etp_etapas_prg',
    @level2type = N'COLUMN',
    @level2name = N'etp_descripcion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Nombre de la etapa del programa',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'etp_etapas_prg',
    @level2type = N'COLUMN',
    @level2name = N'etp_nombre'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de grupo corporativo',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'etp_etapas_prg',
    @level2type = N'COLUMN',
    @level2name = N'etp_codgrc'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha de la última modificacion del registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'etp_etapas_prg',
    @level2type = N'COLUMN',
    @level2name = N'etp_fecha_modificacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Usuario que modificó por última vez el registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'etp_etapas_prg',
    @level2type = N'COLUMN',
    @level2name = N'etp_usuario_modificacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha en que se creo el registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'etp_etapas_prg',
    @level2type = N'COLUMN',
    @level2name = N'etp_fecha_grabacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Usuario que creo el registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'etp_etapas_prg',
    @level2type = N'COLUMN',
    @level2name = N'etp_usuario_grabacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'¿Corresponde con actividades antes del primer día de trabajo?',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'etp_etapas_prg',
    @level2type = N'COLUMN',
    @level2name = N'etp_antes_primer_dia'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'¿Corresponde con actividades durante el primer día de trabajo?',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'etp_etapas_prg',
    @level2type = N'COLUMN',
    @level2name = N'etp_durante_primer_dia'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'¿Corresponde con actividades posteriores al primer día de trabajo?',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'etp_etapas_prg',
    @level2type = N'COLUMN',
    @level2name = N'etp_posterior_primer_dia'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Orden de esta etapa respecto de las demás',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'etp_etapas_prg',
    @level2type = N'COLUMN',
    @level2name = N'etp_orden'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Esta fase está contenida en el período de prueba',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'etp_etapas_prg',
    @level2type = N'COLUMN',
    @level2name = N'etp_periodo_prueba'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Data de los campos adicionales',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'etp_etapas_prg',
    @level2type = N'COLUMN',
    @level2name = N'etp_property_bag_data'
GO