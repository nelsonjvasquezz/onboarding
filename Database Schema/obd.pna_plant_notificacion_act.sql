CREATE TABLE [obd].[pna_plant_notificacion_act]
(
	[pna_codigo] INT IDENTITY(1,1) NOT NULL,
	[pna_codeno] INT NOT NULL,
	[pna_codpac] INT NOT NULL,
	[pna_usa_fecha_inicio] BIT CONSTRAINT [DF_obd_pna_usa_fecha_inicio] DEFAULT ((0)) NOT NULL,
	[pna_offset_inicio] INT NULL,
	[pna_offset_fin] INT NULL,
	[pna_subject] VARCHAR(250) NOT NULL,
	[pna_body] VARCHAR(4000) NOT NULL,
	[pna_envia_contratado] BIT CONSTRAINT [DF_obd_pna_envia_contratado] DEFAULT ((1)) NOT NULL,
	[pna_envia_jefe] BIT CONSTRAINT [DF_obd_pna_envia_jefe] DEFAULT ((1)) NOT NULL,
	[pna_envia_responsable] BIT CONSTRAINT [DF_obd_pna_envia_responsable] DEFAULT ((1)) NOT NULL,
	[pna_property_bag_data] XML NULL,
	[pna_usuario_grabacion] VARCHAR(50) NULL,
	[pna_fecha_grabacion] DATETIME NULL,
	[pna_usuario_modificacion] VARCHAR(50) NULL,
	[pna_fecha_modificacion] DATETIME NULL,

 	CONSTRAINT [PK_pna_plant_notificacion_act] PRIMARY KEY CLUSTERED ([pna_codigo] ASC),
	CONSTRAINT [FK_obdeno_obdpna] FOREIGN KEY([pna_codeno]) REFERENCES [obd].[eno_eventos_notificables] ([eno_codigo]),
	CONSTRAINT [FK_obdpac_obdpna] FOREIGN KEY([pna_codpac]) REFERENCES [obd].[pac_plant_actividades] ([pac_codigo]) ON DELETE CASCADE

)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Tabla que almacena las configuraciones de las notificaciones para las actividades de la plantilla',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pna_plant_notificacion_act',
    @level2type = NULL,
    @level2name = NULL
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de la configuración de las notificaciones de la actividad de la plantilla',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pna_plant_notificacion_act',
    @level2type = N'COLUMN',
    @level2name = N'pna_codigo'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de Evento Notificable',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pna_plant_notificacion_act',
    @level2type = N'COLUMN',
    @level2name = N'pna_codeno'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de Actividad de la plantilla de programas de onboarding',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pna_plant_notificacion_act',
    @level2type = N'COLUMN',
    @level2name = N'pna_codpac'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Desplamiento en dias antes o despues de la fecha de inicio ',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pna_plant_notificacion_act',
    @level2type = N'COLUMN',
    @level2name = N'pna_offset_inicio'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Desplamiento en dias antes o despues de la fecha de finalizacion',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pna_plant_notificacion_act',
    @level2type = N'COLUMN',
    @level2name = N'pna_offset_fin'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Determina cual desplazamiento utiliza, si el de fecha inicio o fecha fin',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pna_plant_notificacion_act',
    @level2type = N'COLUMN',
    @level2name = N'pna_usa_fecha_inicio'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Asunto de la notificación',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pna_plant_notificacion_act',
    @level2type = N'COLUMN',
    @level2name = N'pna_subject'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Cuerpo Markdown de la notificación',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pna_plant_notificacion_act',
    @level2type = N'COLUMN',
    @level2name = N'pna_body'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Data de los campos adicionales',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pna_plant_notificacion_act',
    @level2type = N'COLUMN',
    @level2name = N'pna_property_bag_data'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Usuario que creo el registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pna_plant_notificacion_act',
    @level2type = N'COLUMN',
    @level2name = N'pna_usuario_grabacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha en que se creo el registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pna_plant_notificacion_act',
    @level2type = N'COLUMN',
    @level2name = N'pna_fecha_grabacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Usuario que modificó por última vez el registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pna_plant_notificacion_act',
    @level2type = N'COLUMN',
    @level2name = N'pna_usuario_modificacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha de la última modificacion del registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pna_plant_notificacion_act',
    @level2type = N'COLUMN',
    @level2name = N'pna_fecha_modificacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Determina si la notificación se envía al empleado contratado',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pna_plant_notificacion_act',
    @level2type = N'COLUMN',
    @level2name = N'pna_envia_contratado'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Determina si la notificación se envía al jefe inmediato superior del empleado',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pna_plant_notificacion_act',
    @level2type = N'COLUMN',
    @level2name = N'pna_envia_jefe'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Determina si la notificación se envía al responsable de la actividad',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pna_plant_notificacion_act',
    @level2type = N'COLUMN',
    @level2name = N'pna_envia_responsable'
GO