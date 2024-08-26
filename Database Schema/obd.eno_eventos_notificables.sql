CREATE TABLE [obd].[eno_eventos_notificables]
(
    [eno_codigo] INT IDENTITY(1,1) NOT NULL,
    [eno_codgrc] INT NOT NULL,
    [eno_nombre] VARCHAR(100) NOT NULL,
    [eno_descripcion] VARCHAR(500) NOT NULL,
    [eno_property_bag_data] XML NULL,
    [eno_usuario_grabacion] VARCHAR(50) NULL,
    [eno_fecha_grabacion] DATETIME NULL,
    [eno_usuario_modificacion] VARCHAR(50) NULL,
    [eno_fecha_modificacion] DATETIME NULL,    

    CONSTRAINT [PK_eno_eventos_notificables] PRIMARY KEY CLUSTERED ([eno_codigo] ASC),
    CONSTRAINT [FK_eorgrc_obdbnp] FOREIGN KEY ([eno_codgrc]) REFERENCES [eor].[grc_grupos_corporativos] (grc_codigo)
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Tabla que almacena los evento que son notificables para el seguimiento de los programas de onboarding',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'eno_eventos_notificables',
    @level2type = NULL,
    @level2name = NULL
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de evento notificable',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'eno_eventos_notificables',
    @level2type = N'COLUMN',
    @level2name = N'eno_codigo'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de Grupo Corporativo',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'eno_eventos_notificables',
    @level2type = N'COLUMN',
    @level2name = N'eno_codgrc'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Nombre del Evento',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'eno_eventos_notificables',
    @level2type = N'COLUMN',
    @level2name = N'eno_nombre'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Descripción del Evento que se puede notificar',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'eno_eventos_notificables',
    @level2type = N'COLUMN',
    @level2name = N'eno_descripcion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Data de los campos adicionales',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'eno_eventos_notificables',
    @level2type = N'COLUMN',
    @level2name = N'eno_property_bag_data'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Usuario que creo el registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'eno_eventos_notificables',
    @level2type = N'COLUMN',
    @level2name = N'eno_usuario_grabacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha en que se creo el registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'eno_eventos_notificables',
    @level2type = N'COLUMN',
    @level2name = N'eno_fecha_grabacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Usuario que modificó por última vez el registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'eno_eventos_notificables',
    @level2type = N'COLUMN',
    @level2name = N'eno_usuario_modificacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha de la última modificacion del registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'eno_eventos_notificables',
    @level2type = N'COLUMN',
    @level2name = N'eno_fecha_modificacion'