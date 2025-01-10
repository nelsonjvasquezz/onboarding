CREATE TABLE [obd].[pri_prioridades]
(
	[pri_codigo] INT IDENTITY(1,1) NOT NULL,
	[pri_codgrc] INT NOT NULL,
	[pri_nombre] VARCHAR(50) NOT NULL,
	[pri_color] VARCHAR(20) CONSTRAINT [DF_obd_pri_color] DEFAULT ('#A9A9A9') NOT NULL,
	[pri_orden] INT CONSTRAINT [DF_obd_pri_orden] DEFAULT ((0)) NOT NULL,
	[pri_property_bag_data] XML NULL,
	[pri_usuario_grabacion] VARCHAR(50) NULL,
	[pri_fecha_grabacion] DATETIME NULL,
	[pri_usuario_modificacion] VARCHAR(50) NULL,
	[pri_fecha_modificacion] DATETIME NULL,

 	CONSTRAINT [PK_pri_prioridades] PRIMARY KEY CLUSTERED ([pri_codigo] ASC),
    CONSTRAINT [FK_eorgrc_obdpri] FOREIGN KEY ([pri_codgrc]) REFERENCES [eor].[grc_grupos_corporativos] ([grc_codigo])
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Tabla que almacena las prioridades de las actividades del plan de onboarding',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pri_prioridades',
    @level2type = NULL,
    @level2name = NULL
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de la prioridad',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pri_prioridades',
    @level2type = N'COLUMN',
    @level2name = N'pri_codigo'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Nombre de la prioridad',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pri_prioridades',
    @level2type = N'COLUMN',
    @level2name = N'pri_nombre'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de Grupo Corporativo',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pri_prioridades',
    @level2type = N'COLUMN',
    @level2name = N'pri_codgrc'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Color con que se muestra la prioridad',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pri_prioridades',
    @level2type = N'COLUMN',
    @level2name = N'pri_color'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Determina el orden las prioridades',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pri_prioridades',
    @level2type = N'COLUMN',
    @level2name = N'pri_orden'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Usuario que creo el registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pri_prioridades',
    @level2type = N'COLUMN',
    @level2name = N'pri_usuario_grabacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha en que se creo el registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pri_prioridades',
    @level2type = N'COLUMN',
    @level2name = N'pri_fecha_grabacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Usuario que modificó por última vez el registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pri_prioridades',
    @level2type = N'COLUMN',
    @level2name = N'pri_usuario_modificacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha de la última modificacion del registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pri_prioridades',
    @level2type = N'COLUMN',
    @level2name = N'pri_fecha_modificacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Data de los campos adicionales',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pri_prioridades',
    @level2type = N'COLUMN',
    @level2name = N'pri_property_bag_data'
GO