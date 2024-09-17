CREATE TABLE [obd].[eno_eventos_notificables]
(
	[eno_codigo] INT IDENTITY(1,1) NOT NULL,
	[eno_nombre] VARCHAR(100) NOT NULL,
	[eno_descripcion_loc_key] VARCHAR(500) NOT NULL,

 	CONSTRAINT [PK_eno_eventos_notificables] PRIMARY KEY CLUSTERED ([eno_codigo] ASC)
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Tabla que almacena los eventos que son notificables para el seguimiento de los programas de onboarding',
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
    @value = N'Nombre del Evento',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'eno_eventos_notificables',
    @level2type = N'COLUMN',
    @level2name = N'eno_nombre'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Llave de localización de la descripción del evento que se puede notificar',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'eno_eventos_notificables',
    @level2type = N'COLUMN',
    @level2name = N'eno_descripcion_loc_key'
GO