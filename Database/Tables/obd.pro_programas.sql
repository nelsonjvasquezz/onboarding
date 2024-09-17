CREATE TABLE [obd].[pro_programas]
(
	[pro_codigo] INT IDENTITY(1,1) NOT NULL,
	[pro_codppr] INT NOT NULL,
	[pro_nombre] VARCHAR(250) NOT NULL,
	[pro_descripcion] VARCHAR(4000) NULL,
	[pro_objetivo] VARCHAR(4000) NULL,
	[pro_estado] VARCHAR(15) CONSTRAINT [DF_obd_pro_estado] DEFAULT ('Planificado') NOT NULL,
	[pro_duracion] INT CONSTRAINT [DF_obd_pro_duracion] DEFAULT ((0)) NOT NULL,
	[pro_unidad_duracion] VARCHAR(50) CONSTRAINT [DF_obd_pro_unidad_duracion] DEFAULT ('Dias') NOT NULL,
	[pro_property_bag_data] XML NULL,
	[pro_usuario_grabacion] VARCHAR(50) NULL,
	[pro_fecha_grabacion] DATETIME NULL,
	[pro_usuario_modificacion] VARCHAR(50) NULL,
	[pro_fecha_modificacion] DATETIME NULL,

 	CONSTRAINT [PK_pro_programas] PRIMARY KEY CLUSTERED ([pro_codigo] ASC),
	CONSTRAINT [FK_obdppr_obdpro] FOREIGN KEY([pro_codppr]) REFERENCES [obd].[ppr_plantilla_prg] ([ppr_codigo]),
	CONSTRAINT [CK_pro_programas_estado] CHECK (pro_estado in ('Planificado', 'EnEjecucion', 'Finalizado')),
    CONSTRAINT [CK_pro_programas_unidad_duracion] CHECK (pro_unidad_duracion in ('Minutos', 'Horas', 'Dias', 'Semanas', 'Meses', 'Anios'))
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Tabla que almacena los programas de onboarding',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pro_programas',
    @level2type = NULL,
    @level2name = NULL
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de programa de onboarding',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pro_programas',
    @level2type = N'COLUMN',
    @level2name = N'pro_codigo'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de plantilla programa',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pro_programas',
    @level2type = N'COLUMN',
    @level2name = N'pro_codppr'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Nombre del programa de onboarding',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pro_programas',
    @level2type = N'COLUMN',
    @level2name = N'pro_nombre'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Descripción del programa de onboarding',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pro_programas',
    @level2type = N'COLUMN',
    @level2name = N'pro_descripcion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Estado del programa ''Planificado'' o ''EnEjecucion'' o ''Finalizado''',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pro_programas',
    @level2type = N'COLUMN',
    @level2name = N'pro_estado'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Objetivos del programa de onboarding',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pro_programas',
    @level2type = N'COLUMN',
    @level2name = N'pro_objetivo'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Duración estimada del programa',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pro_programas',
    @level2type = N'COLUMN',
    @level2name = N'pro_duracion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Unidad de medida de la duración estimada del programa',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pro_programas',
    @level2type = N'COLUMN',
    @level2name = N'pro_unidad_duracion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Data de los campos adicionales',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pro_programas',
    @level2type = N'COLUMN',
    @level2name = N'pro_property_bag_data'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Usuario que creo el registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pro_programas',
    @level2type = N'COLUMN',
    @level2name = N'pro_usuario_grabacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha en que se creo el registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pro_programas',
    @level2type = N'COLUMN',
    @level2name = N'pro_fecha_grabacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Usuario que modificó por última vez el registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pro_programas',
    @level2type = N'COLUMN',
    @level2name = N'pro_usuario_modificacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha de la última modificacion del registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pro_programas',
    @level2type = N'COLUMN',
    @level2name = N'pro_fecha_modificacion'
GO