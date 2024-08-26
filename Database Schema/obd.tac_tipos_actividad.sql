CREATE TABLE [obd].[tac_tipos_actividad]
(
    [tac_codigo]               INT          IDENTITY(1,1) NOT NULL,
    [tac_codgrc]               INT          NOT NULL,
    [tac_nombre]               VARCHAR(100) NOT NULL,
    [tac_descripcion]          VARCHAR(500) NULL,
    [tac_req_notificacion]     BIT          CONSTRAINT [DF_obd_tac_req_notificacion] DEFAULT ((0)) NOT NULL,
    [tac_req_recordatorio]     BIT          CONSTRAINT [DF_obd_tac_req_recordatorio] DEFAULT ((0)) NOT NULL,
    [tac_req_evaluacion]       BIT          CONSTRAINT [DF_obd_tac_req_evaluacion] DEFAULT ((0)) NOT NULL,
    [tac_req_documentos]       BIT          CONSTRAINT [DF_obd_tac_req_documentos] DEFAULT ((0)) NOT NULL,
    [tac_req_responsable]      BIT          CONSTRAINT [DF_obd_tac_req_responsable] DEFAULT ((0)) NOT NULL,
    [tac_duracion_estimada]    INT          CONSTRAINT [DF_obd_tac_duracion_estimada] DEFAULT ((0)) NOT NULL,
    [tac_unidad_duracion]      VARCHAR(50)  CONSTRAINT [DF_obd_tac_unidad_duracion] DEFAULT ('Días') NOT NULL,
    [tac_property_bag_data]    XML          NULL,
    [tac_usuario_grabacion]    VARCHAR(50)  NULL,
    [tac_fecha_grabacion]      DATETIME     NULL,
    [tac_usuario_modificacion] VARCHAR(50)  NULL,
    [tac_fecha_modificacion]   DATETIME     NULL,

    CONSTRAINT [PK_tac_tipos_actividad] PRIMARY KEY CLUSTERED ([tac_codigo] ASC),
    CONSTRAINT [FK_eorgrc_obdtac] FOREIGN KEY ([tac_codgrc]) REFERENCES [eor].[grc_grupos_corporativos] ([grc_codigo]), 
    CONSTRAINT [CK_tac_tipos_actividad_unidad_duracion] CHECK (tac_unidad_duracion in ('Minutos', 'Horas', 'Días', 'Semanas', 'Meses', 'Años'))
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha de la última modificacion del registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tac_tipos_actividad',
    @level2type = N'COLUMN',
    @level2name = N'tac_fecha_modificacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Usuario que modificó por última vez el registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tac_tipos_actividad',
    @level2type = N'COLUMN',
    @level2name = N'tac_usuario_modificacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha en que se creo el registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tac_tipos_actividad',
    @level2type = N'COLUMN',
    @level2name = N'tac_fecha_grabacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Usuario que creo el registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tac_tipos_actividad',
    @level2type = N'COLUMN',
    @level2name = N'tac_usuario_grabacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de tipo de actividad',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tac_tipos_actividad',
    @level2type = N'COLUMN',
    @level2name = 'tac_codigo'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Nombre del tipo de actividad',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tac_tipos_actividad',
    @level2type = N'COLUMN',
    @level2name = N'tac_nombre'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Descripción del tipo de actividad',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tac_tipos_actividad',
    @level2type = N'COLUMN',
    @level2name = N'tac_descripcion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de grupo corporativo',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tac_tipos_actividad',
    @level2type = N'COLUMN',
    @level2name = N'tac_codgrc'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'¿Requiere Notificación luego de que finalice? (contratado, jefe, RRHH y al responsable de la actividad si está definido)',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tac_tipos_actividad',
    @level2type = N'COLUMN',
    @level2name = N'tac_req_notificacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'¿Requiere Recordatorio previo a que se inicie? (contratado, jefe, RRHH y al responsable de la actividad si está definido)',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tac_tipos_actividad',
    @level2type = N'COLUMN',
    @level2name = N'tac_req_recordatorio'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'¿Requiere Evaluación del responsable? (contratado, jefe, RRHH y al responsable de la actividad si está definido)',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tac_tipos_actividad',
    @level2type = N'COLUMN',
    @level2name = N'tac_req_evaluacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'¿Requiere Adjuntar documentos?',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tac_tipos_actividad',
    @level2type = N'COLUMN',
    @level2name = 'tac_req_documentos'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'¿Requiere un responsable asignado?',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tac_tipos_actividad',
    @level2type = N'COLUMN',
    @level2name = N'tac_req_responsable'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Duración estimada de la actividad',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tac_tipos_actividad',
    @level2type = N'COLUMN',
    @level2name = N'tac_duracion_estimada'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Unidad de medida para la duración estimada',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tac_tipos_actividad',
    @level2type = N'COLUMN',
    @level2name = N'tac_unidad_duracion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Tabla que almacena los tipos de actividad para los programas de Onboarding',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tac_tipos_actividad',
    @level2type = NULL,
    @level2name = NULL
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Data de los campos adicionales',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tac_tipos_actividad',
    @level2type = N'COLUMN',
    @level2name = N'tac_property_bag_data'