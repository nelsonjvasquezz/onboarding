﻿CREATE TABLE [obd].[nap_notif_actividad_programa]
(
    [nap_codigo] INT IDENTITY(1,1) NOT NULL,
    [nap_codacp] INT NOT NULL,
    [nap_codeno] INT NOT NULL,
    [nap_offset_dias] INT CONSTRAINT [DF_obd_nap_offset_dias] DEFAULT ((0)) NOT NULL,
    [nap_tipo_destinatario] VARCHAR(25) CONSTRAINT [DF_obd_nap_tipo_destinatario] DEFAULT ('Contratado') NOT NULL,
    [nap_subject] VARCHAR(250) NULL,
    [nap_body] VARCHAR(4000) NULL,
    [nap_fecha_evento] DATETIME NULL,
    [nap_fecha_notificacion] DATETIME NULL,
    [nap_estado] VARCHAR(10) NULL,
    [nap_mensaje_error] VARCHAR(4000) NULL,

    CONSTRAINT [PK_nap_notif_actividad_programa] PRIMARY KEY CLUSTERED ([nap_codigo] ASC),
    CONSTRAINT [FK_obdacp_obdnap] FOREIGN KEY (nap_codacp) REFERENCES [obd].[acp_actividades_programa] (acp_codigo),
    CONSTRAINT [FK_obdeno_obdnap] FOREIGN KEY (nap_codeno) REFERENCES [obd].[eno_eventos_notificables] (eno_codigo),

    CONSTRAINT [CK_nap_notif_actividad_programa_estado] CHECK (nap_estado in ('Pendiente', 'Enviado', 'Error')),
    CONSTRAINT [CK_nap_notif_actividad_programa_tipo_destinatario] CHECK (nap_tipo_destinatario is null or nap_tipo_destinatario = 'Contratado' or nap_tipo_destinatario = 'JefeInmediato' or nap_tipo_destinatario = 'ResponsableActividad' or nap_tipo_destinatario =  'ResponsableRRHH')
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Destinatario de la notificación: Contratado | JefeInmediato | ResponsableActividad | ResponsableRRHH',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'nap_notif_actividad_programa',
    @level2type = N'COLUMN',
    @level2name = N'nap_tipo_destinatario'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de registro de la configuración de notificaciones de la actividad del programa',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'nap_notif_actividad_programa',
    @level2type = N'COLUMN',
    @level2name = N'nap_codigo'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de la Actividad',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'nap_notif_actividad_programa',
    @level2type = N'COLUMN',
    @level2name = N'nap_codacp'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Tipo de Evento Notificable',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'nap_notif_actividad_programa',
    @level2type = N'COLUMN',
    @level2name = N'nap_codeno'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Desplazamiento en días de la fecha en que ocurre el evento para el envio de la notificación',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'nap_notif_actividad_programa',
    @level2type = N'COLUMN',
    @level2name = N'nap_offset_dias'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Asunto de la notificación',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'nap_notif_actividad_programa',
    @level2type = N'COLUMN',
    @level2name = N'nap_subject'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Cuerpo Markdown de la notificación',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'nap_notif_actividad_programa',
    @level2type = N'COLUMN',
    @level2name = N'nap_body'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha y hora de cuando se notificó',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'nap_notif_actividad_programa',
    @level2type = N'COLUMN',
    @level2name = N'nap_fecha_notificacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha en que sucedió el evento notificable (está null mientras no se ha dado)',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'nap_notif_actividad_programa',
    @level2type = N'COLUMN',
    @level2name = N'nap_fecha_evento'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Estado de la notificación (NULL | ''Pendiente'' | ''Enviada'' | ''Error'')',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'nap_notif_actividad_programa',
    @level2type = N'COLUMN',
    @level2name = N'nap_estado'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Mensaje o excepción cuando el estado es ''Error''',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'nap_notif_actividad_programa',
    @level2type = N'COLUMN',
    @level2name = N'nap_mensaje_error'