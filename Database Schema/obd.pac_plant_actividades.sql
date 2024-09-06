CREATE TABLE [obd].[pac_plant_actividades]
(
	[pac_codigo] INT IDENTITY(1,1) NOT NULL,
	[pac_codppr] INT NOT NULL,
	[pac_nombre] VARCHAR(250) NOT NULL,
	[pac_descripcion] VARCHAR(4000) NULL,
	[pac_objetivo] VARCHAR(4000) NULL,
	[pac_codetp] INT NOT NULL,
	[pac_codtac] INT NOT NULL,
	[pac_offset_inicio] INT CONSTRAINT [DF_obd_pac_offset_inicio] DEFAULT ((0)) NOT NULL,
	[pac_unidad_offset_inicio] VARCHAR(50) CONSTRAINT [DF_obd_pac_unidad_offset_inicio] DEFAULT ('Dias') NOT NULL,
	[pac_duracion_estimada] INT CONSTRAINT [DF_obd_pac_duracion_estimada] DEFAULT ((0)) NOT NULL,
	[pac_unidad_duracion] VARCHAR(50) CONSTRAINT [DF_obd_pac_unidad_duracion] DEFAULT ('Dias') NOT NULL,
	[pac_codpri] INT NOT NULL,
	[pac_orden] INT CONSTRAINT [DF_obd_pac_orden] DEFAULT ((0)) NOT NULL,
	[pac_codtra] INT NULL,
	[pac_codtev] INT NULL,
	[pac_nota_eval_esperada] DECIMAL(5, 2) NULL,

	[pac_property_bag_data] XML NULL,
	[pac_usuario_grabacion] VARCHAR(50) NULL,
	[pac_fecha_grabacion] DATETIME NULL,
	[pac_usuario_modificacion] VARCHAR(50) NULL,
	[pac_fecha_modificacion] DATETIME NULL,

 	CONSTRAINT [PK_pac_plant_actividades] PRIMARY KEY CLUSTERED ([pac_codigo] ASC),
	CONSTRAINT [FK_obdppr_obdpac] FOREIGN KEY([pac_codppr]) REFERENCES [obd].[ppr_plant_programa] ([ppr_codigo]),
	CONSTRAINT [FK_obdetp_obdpac] FOREIGN KEY([pac_codetp]) REFERENCES [obd].[etp_etapas_programa] ([etp_codigo]),
	CONSTRAINT [FK_obdtac_obdpac] FOREIGN KEY([pac_codtac]) REFERENCES [obd].[tac_tipos_actividad] ([tac_codigo]),
	CONSTRAINT [FK_obdpri_obdpac] FOREIGN KEY([pac_codpri]) REFERENCES [obd].[pri_prioridades] ([pri_codigo]),
	CONSTRAINT [FK_obdtra_obdpac] FOREIGN KEY([pac_codtra]) REFERENCES [obd].[tra_tipos_respon_actividad] ([tra_codigo]),
	CONSTRAINT [FK_obdtev_obdpac] FOREIGN KEY([pac_codtev]) REFERENCES [obd].[tev_tipos_evaluacion] ([tev_codigo]),
	CONSTRAINT [CK_pac_plant_actividades_unidad_offset_inicio] CHECK (pac_unidad_offset_inicio in ('Minutos', 'Horas', 'Dias', 'Semanas', 'Meses', 'Anios')),
    CONSTRAINT [CK_pac_plant_actividades_unidad_duracion] CHECK (pac_unidad_duracion in ('Minutos', 'Horas', 'Dias', 'Semanas', 'Meses', 'Anios'))
) 

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Tabla que almacena las actividades de la plantilla del programa de onboarding',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pac_plant_actividades',
    @level2type = NULL,
    @level2name = NULL
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de registro de la actividad de la plantilla para programa de onboarding',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pac_plant_actividades',
    @level2type = N'COLUMN',
    @level2name = N'pac_codigo'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de la plantilla de programa de onboarding',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pac_plant_actividades',
    @level2type = N'COLUMN',
    @level2name = N'pac_codppr'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Nombre de la actividad',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pac_plant_actividades',
    @level2type = N'COLUMN',
    @level2name = N'pac_nombre'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Descripción de la actividad',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pac_plant_actividades',
    @level2type = N'COLUMN',
    @level2name = N'pac_descripcion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Objetivo de la actividad',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pac_plant_actividades',
    @level2type = N'COLUMN',
    @level2name = N'pac_objetivo'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Data de los campos adicionales',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pac_plant_actividades',
    @level2type = N'COLUMN',
    @level2name = N'pac_property_bag_data'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Usuario que creo el registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pac_plant_actividades',
    @level2type = N'COLUMN',
    @level2name = N'pac_usuario_grabacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha en que se creo el registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pac_plant_actividades',
    @level2type = N'COLUMN',
    @level2name = N'pac_fecha_grabacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Usuario que modificó por última vez el registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pac_plant_actividades',
    @level2type = N'COLUMN',
    @level2name = N'pac_usuario_modificacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha de la última modificacion del registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pac_plant_actividades',
    @level2type = N'COLUMN',
    @level2name = N'pac_fecha_modificacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de Etapa o Fase del programa',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pac_plant_actividades',
    @level2type = N'COLUMN',
    @level2name = N'pac_codetp'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de Tipo de Actividad',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pac_plant_actividades',
    @level2type = N'COLUMN',
    @level2name = N'pac_codtac'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Desplazamiento de tiempo antes o despues de la contratación para determinar la fecha de inicio de la actividad',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pac_plant_actividades',
    @level2type = N'COLUMN',
    @level2name = N'pac_offset_inicio'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Unidad de medida del desplazamiento',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pac_plant_actividades',
    @level2type = N'COLUMN',
    @level2name = N'pac_unidad_offset_inicio'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de Prioridad de la actividad',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pac_plant_actividades',
    @level2type = N'COLUMN',
    @level2name = N'pac_codpri'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Orden de esta actividad respecto de las mismas que tienen los mismos requisitos',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pac_plant_actividades',
    @level2type = N'COLUMN',
    @level2name = N'pac_orden'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de Tipo de Responsable de la actividad, cuando es NULL el responsable es el nuevo empleado',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pac_plant_actividades',
    @level2type = N'COLUMN',
    @level2name = N'pac_codtra'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Codigo de Tipo de Evaluación de la activdidad',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pac_plant_actividades',
    @level2type = N'COLUMN',
    @level2name = N'pac_codtev'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Duración estimada de la actividad',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pac_plant_actividades',
    @level2type = N'COLUMN',
    @level2name = N'pac_duracion_estimada'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Unidad de medida de la duracióon estimada de la actividad',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pac_plant_actividades',
    @level2type = N'COLUMN',
    @level2name = N'pac_unidad_duracion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Nota de evaluación esperada para determinar si aprobo o no la evaluación',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pac_plant_actividades',
    @level2type = N'COLUMN',
    @level2name = N'pac_nota_eval_esperada'
GO