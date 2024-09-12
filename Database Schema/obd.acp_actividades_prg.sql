CREATE TABLE [obd].[acp_actividades_prg]
(
	[acp_codigo] INT IDENTITY(1,1) NOT NULL,
	[acp_codpap] INT NOT NULL,
	[acp_nombre] VARCHAR(250) NOT NULL,
	[acp_descripcion] VARCHAR(4000) NULL,
	[acp_objetivo] VARCHAR(4000) NULL,
	[acp_codetp] INT NOT NULL,
	[acp_codtac] INT NOT NULL,
	[acp_codemp_responsable] INT NULL,
	[acp_fecha_inicio] DATETIME NOT NULL,
	[acp_fecha_fin] DATETIME NOT NULL,
	[acp_duracion] INT CONSTRAINT [DF_obd_acp_duracion] DEFAULT ((0)) NOT NULL,
	[acp_unidad_duracion] VARCHAR(50) CONSTRAINT [DF_obd_acp_unidad_duracion] DEFAULT ('Dias') NOT NULL,
	[acp_codpri] INT NOT NULL,
	[acp_orden] INT CONSTRAINT [DF_obd_acp_orden] DEFAULT ((0)) NOT NULL,
	[acp_codtra] INT NULL,

	[acp_codtev] INT NULL,

	[acp_fecha_evaluacion] DATETIME NULL,
	[acp_nota_evaluacion] DECIMAL(5, 2) NULL,
	[acp_resultado_evaluacion] VARCHAR(100) NULL,
	[acp_codfdd] INT NULL,

	[acp_estado] VARCHAR(10) CONSTRAINT [DF_obd_acp_estado] DEFAULT ('Pendiente') NOT NULL,
	[acp_fecha_finalizacion] DATETIME NULL,
	[acp_comentario_finalizacion] VARCHAR(4000) NULL,

	[acp_property_bag_data] XML NULL,
	[acp_usuario_grabacion] VARCHAR(50) NULL,
	[acp_fecha_grabacion] DATETIME NULL,
	[acp_usuario_modificacion] VARCHAR(50) NULL,
	[acp_fecha_modificacion] DATETIME NULL,

 	CONSTRAINT [PK_acp_actividades_prg] PRIMARY KEY CLUSTERED ([acp_codigo] ASC),
	CONSTRAINT [FK_obdpap_obdacp] FOREIGN KEY([acp_codpap]) REFERENCES [obd].[pap_participantes_prg] ([pap_codigo]) ON DELETE CASCADE,
	CONSTRAINT [FK_obdetp_obdacp] FOREIGN KEY([acp_codetp]) REFERENCES [obd].[etp_etapas_prg] ([etp_codigo]),
	CONSTRAINT [FK_obdtac_obdacp] FOREIGN KEY([acp_codtac]) REFERENCES [obd].[tac_tipos_actividad] ([tac_codigo]),
	CONSTRAINT [FK_expemp_obdacp] FOREIGN KEY ([acp_codemp_responsable]) REFERENCES [exp].[emp_empleos] ([emp_codigo]),
    CONSTRAINT [FK_obdpri_obdacp] FOREIGN KEY([acp_codpri]) REFERENCES [obd].[pri_prioridades] ([pri_codigo]),
	CONSTRAINT [FK_obdtra_obdacp] FOREIGN KEY([acp_codtra]) REFERENCES [obd].[tra_tipos_respon_actividad] ([tra_codigo]),
	CONSTRAINT [FK_obdtev_obdacp] FOREIGN KEY([acp_codtev]) REFERENCES [obd].[tev_tipos_evaluacion] ([tev_codigo]),
	CONSTRAINT [FK_genfdd_obdacp] FOREIGN KEY ([acp_codfdd]) REFERENCES [gen].[fdd_form_dinamico_data] ([fdd_codigo]),
	CONSTRAINT [CK_acp_actividades_prg_unidad_duracion] CHECK (acp_unidad_duracion in ('Minutos', 'Horas', 'Dias', 'Semanas', 'Meses', 'Anios')),
    CONSTRAINT [CK_acp_actividades_prg_resultado_evaluacion] CHECK (acp_resultado_evaluacion in ('Aprobado', 'Reprobado')),
    CONSTRAINT [CK_acp_actividades_prg_estado] CHECK (acp_estado in ('Pendiente', 'EnProceso', 'Finalizada'))
) 

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Tabla que almacena las actividades de los participantes de un programa de onboarding',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'acp_actividades_prg',
    @level2type = NULL,
    @level2name = NULL
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de registro de la actividad de un participante para un programa de onboarding',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'acp_actividades_prg',
    @level2type = N'COLUMN',
    @level2name = N'acp_codigo'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código del participante de un programa de onboarding',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'acp_actividades_prg',
    @level2type = N'COLUMN',
    @level2name = N'acp_codpap'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Nombre de la actividad',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'acp_actividades_prg',
    @level2type = N'COLUMN',
    @level2name = N'acp_nombre'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Descripción de la actividad',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'acp_actividades_prg',
    @level2type = N'COLUMN',
    @level2name = N'acp_descripcion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Objetivo de la actividad',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'acp_actividades_prg',
    @level2type = N'COLUMN',
    @level2name = N'acp_objetivo'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Data de los campos adicionales',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'acp_actividades_prg',
    @level2type = N'COLUMN',
    @level2name = N'acp_property_bag_data'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Usuario que creo el registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'acp_actividades_prg',
    @level2type = N'COLUMN',
    @level2name = N'acp_usuario_grabacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha en que se creo el registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'acp_actividades_prg',
    @level2type = N'COLUMN',
    @level2name = N'acp_fecha_grabacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Usuario que modificó por última vez el registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'acp_actividades_prg',
    @level2type = N'COLUMN',
    @level2name = N'acp_usuario_modificacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha de la última modificacion del registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'acp_actividades_prg',
    @level2type = N'COLUMN',
    @level2name = N'acp_fecha_modificacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de Etapa o Fase del programa',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'acp_actividades_prg',
    @level2type = N'COLUMN',
    @level2name = N'acp_codetp'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de Tipo de Actividad',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'acp_actividades_prg',
    @level2type = N'COLUMN',
    @level2name = N'acp_codtac'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha calculada de inicio de la actividad',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'acp_actividades_prg',
    @level2type = N'COLUMN',
    @level2name = N'acp_fecha_inicio'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha calculada de finalización de la actividad',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'acp_actividades_prg',
    @level2type = N'COLUMN',
    @level2name = N'acp_fecha_fin'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de Prioridad de la actividad',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'acp_actividades_prg',
    @level2type = N'COLUMN',
    @level2name = N'acp_codpri'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Orden de esta actividad respecto de las mismas que tienen los mismos requisitos',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'acp_actividades_prg',
    @level2type = N'COLUMN',
    @level2name = N'acp_orden'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de Tipo de Responsable de la actividad, NULL cuando el participante es el responsable',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'acp_actividades_prg',
    @level2type = N'COLUMN',
    @level2name = N'acp_codtra'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Codigo de Tipo de Evaluación de la activdidad (NULL cuando no requiere evaluación)',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'acp_actividades_prg',
    @level2type = N'COLUMN',
    @level2name = N'acp_codtev'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Duración de la actividad',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'acp_actividades_prg',
    @level2type = N'COLUMN',
    @level2name = N'acp_duracion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Unidad de medida de la duración de la actividad',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'acp_actividades_prg',
    @level2type = N'COLUMN',
    @level2name = N'acp_unidad_duracion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Nota de la evaluación dada por el responsable de la actividad',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'acp_actividades_prg',
    @level2type = N'COLUMN',
    @level2name = N'acp_nota_evaluacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Determina si la evaluación fue aprobada o no',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'acp_actividades_prg',
    @level2type = N'COLUMN',
    @level2name = N'acp_resultado_evaluacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de empleo responsable de la evaluación',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'acp_actividades_prg',
    @level2type = N'COLUMN',
    @level2name = N'acp_codemp_responsable'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha de evaluación de la actividad',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'acp_actividades_prg',
    @level2type = N'COLUMN',
    @level2name = N'acp_fecha_evaluacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha de finalización de la actividad (fecha en el estado cambio a finalizada)',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'acp_actividades_prg',
    @level2type = N'COLUMN',
    @level2name = N'acp_fecha_finalizacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Comentarios de evaluador o quien finaliza la actividad',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'acp_actividades_prg',
    @level2type = N'COLUMN',
    @level2name = N'acp_comentario_finalizacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Estado de la actividad (Pendiente, En Proceso, Finalizada)',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'acp_actividades_prg',
    @level2type = N'COLUMN',
    @level2name = N'acp_estado'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de la data del formulario dinámico (cuando está definido según el tipo de evaluación)',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'acp_actividades_prg',
    @level2type = N'COLUMN',
    @level2name = N'acp_codfdd'
GO