CREATE TABLE [obd].[ppr_plant_programa]
(
    [ppr_codigo] INT IDENTITY(1,1) NOT NULL,
    [ppr_codgrc] INT NOT NULL,
    [ppr_nombre] VARCHAR(250) NOT NULL,
    [ppr_descripcion] VARCHAR(4000) NULL,
    [ppr_objetivo] VARCHAR(4000) NULL,
    [ppr_estado] VARCHAR(10) CONSTRAINT [DF_obd_ppr_estado] DEFAULT ('Activo') NOT NULL,
    [ppr_duracion_estimada] INT CONSTRAINT [DF_obd_ppr_duracion_estimada] DEFAULT ((0)) NOT NULL,
    [ppr_unidad_duracion] VARCHAR(50) CONSTRAINT [DF_obd_ppr_unidad_duracion] DEFAULT ('Días') NOT NULL,
    [ppr_property_bag_data] XML NULL,
    [ppr_usuario_grabacion] VARCHAR(50) NULL,
    [ppr_fecha_grabacion] DATETIME NULL,
    [ppr_usuario_modificacion] VARCHAR(50) NULL,
    [ppr_fecha_modificacion] DATETIME NULL,

    CONSTRAINT [PK_ppr_plant_programa] PRIMARY KEY CLUSTERED ([ppr_codigo] ASC),
    CONSTRAINT [FK_eorgrc_obdppr] FOREIGN KEY ([ppr_codgrc]) REFERENCES [eor].[grc_grupos_corporativos] ([grc_codigo]),
    CONSTRAINT [CK_ppr_plant_programa_estado] CHECK (ppr_estado in ('Activo', 'Inactivo')),
    CONSTRAINT [CK_ppr_plant_programa_unidad_duracion] CHECK (ppr_unidad_duracion in ('Minutos', 'Horas', 'Días', 'Semanas', 'Meses', 'Años'))
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Tabla que almacena la plantilla para los programas de onboarding',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'ppr_plant_programa',
    @level2type = NULL,
    @level2name = NULL
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de plantilla de programa de onboarding',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'ppr_plant_programa',
    @level2type = N'COLUMN',
    @level2name = N'ppr_codigo'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Nombre del programa de onboarding',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'ppr_plant_programa',
    @level2type = N'COLUMN',
    @level2name = N'ppr_nombre'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Descripción del programa de onboarding',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'ppr_plant_programa',
    @level2type = N'COLUMN',
    @level2name = N'ppr_descripcion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Estado de la plantilla ''Activa'' o ''Inactiva''  (inactivas para fines de guardar históricos y que no aparezcan en la selección)',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'ppr_plant_programa',
    @level2type = N'COLUMN',
    @level2name = N'ppr_estado'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de Grupo Corporativo',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'ppr_plant_programa',
    @level2type = N'COLUMN',
    @level2name = N'ppr_codgrc'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Objetivos del programa de onboarding',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'ppr_plant_programa',
    @level2type = N'COLUMN',
    @level2name = N'ppr_objetivo'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Duración estimada del programa',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'ppr_plant_programa',
    @level2type = N'COLUMN',
    @level2name = N'ppr_duracion_estimada'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Unidad de medida de la duración estimada del programa',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'ppr_plant_programa',
    @level2type = N'COLUMN',
    @level2name = N'ppr_unidad_duracion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Data de los campos adicionales',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'ppr_plant_programa',
    @level2type = N'COLUMN',
    @level2name = N'ppr_property_bag_data'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Usuario que creo el registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'ppr_plant_programa',
    @level2type = N'COLUMN',
    @level2name = N'ppr_usuario_grabacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha en que se creo el registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'ppr_plant_programa',
    @level2type = N'COLUMN',
    @level2name = N'ppr_fecha_grabacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Usuario que modificó por última vez el registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'ppr_plant_programa',
    @level2type = N'COLUMN',
    @level2name = N'ppr_usuario_modificacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha de la última modificacion del registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'ppr_plant_programa',
    @level2type = N'COLUMN',
    @level2name = N'ppr_fecha_modificacion'