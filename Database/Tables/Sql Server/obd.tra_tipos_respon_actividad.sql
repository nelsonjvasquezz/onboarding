CREATE TABLE [obd].[tra_tipos_respon_actividad]
(
	[tra_codigo] INT IDENTITY(1,1) NOT NULL,
	[tra_codgrc] INT NOT NULL,
	[tra_nombre] VARCHAR(50) NOT NULL,
	[tra_descripcion] VARCHAR(500) NULL,
    [tra_es_participante] BIT CONSTRAINT [DF_obd_tra_es_participante] DEFAULT ((0)) NOT NULL,
	[tra_requiere_empleo] BIT CONSTRAINT [DF_obd_tra_requiere_empleo] DEFAULT ((1)) NOT NULL,
	[tra_codvli_empleo] VARCHAR(50) NULL,
	[tra_es_inst_externa] BIT CONSTRAINT [DF_obd_tra_es_inst_externa] DEFAULT ((0)) NOT NULL,
	[tra_contacto_externo] VARCHAR(250) NULL,
	[tra_es_persona_externa] BIT CONSTRAINT [DF_obd_tra_es_persona_externa] DEFAULT ((0)) NOT NULL,
	[tra_email_externo] VARCHAR(100) NULL,
	[tra_telefono_externo] VARCHAR(50) NULL,
	[tra_property_bag_data] XML NULL,
	[tra_usuario_grabacion] VARCHAR(50) NULL,
	[tra_fecha_grabacion] DATETIME NULL,
	[tra_usuario_modificacion] VARCHAR(50) NULL,
	[tra_fecha_modificacion] DATETIME NULL,

 	CONSTRAINT [PK_tra_tipos_respon_actividad] PRIMARY KEY CLUSTERED ([tra_codigo] ASC),
	CONSTRAINT [FK_eorgrc_obdtra] FOREIGN KEY ([tra_codgrc]) REFERENCES [eor].[grc_grupos_corporativos] ([grc_codigo]),
    CONSTRAINT [FK_cfgvli_obdtra] FOREIGN KEY ([tra_codvli_empleo]) REFERENCES [cfg].[vli_value_lists] ([vli_id])
) 

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Tabla de Tipos de responsables de las Actividades',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tra_tipos_respon_actividad',
    @level2type = NULL,
    @level2name = NULL
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de Tipo de Responsable de Actividad',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tra_tipos_respon_actividad',
    @level2type = N'COLUMN',
    @level2name = N'tra_codigo'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha de la última modificacion del registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tra_tipos_respon_actividad',
    @level2type = N'COLUMN',
    @level2name = N'tra_fecha_modificacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Usuario que modificó por última vez el registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tra_tipos_respon_actividad',
    @level2type = N'COLUMN',
    @level2name = N'tra_usuario_modificacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha en que se creo el registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tra_tipos_respon_actividad',
    @level2type = N'COLUMN',
    @level2name = N'tra_fecha_grabacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Usuario que creo el registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tra_tipos_respon_actividad',
    @level2type = N'COLUMN',
    @level2name = N'tra_usuario_grabacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Nombre del Tipo de Responsable de Actividad',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tra_tipos_respon_actividad',
    @level2type = N'COLUMN',
    @level2name = N'tra_nombre'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Descripción del Tipo de Responsable de Actividad',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tra_tipos_respon_actividad',
    @level2type = N'COLUMN',
    @level2name = N'tra_descripcion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de Grupo Corporativo',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tra_tipos_respon_actividad',
    @level2type = N'COLUMN',
    @level2name = N'tra_codgrc'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de la lista de valores que permite seleccionar un empleo',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tra_tipos_respon_actividad',
    @level2type = N'COLUMN',
    @level2name = N'tra_codvli_empleo'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'¿El participante es el responsable?',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tra_tipos_respon_actividad',
    @level2type = N'COLUMN',
    @level2name = N'tra_es_participante'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'¿Corresponde con una persona externa?',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tra_tipos_respon_actividad',
    @level2type = N'COLUMN',
    @level2name = N'tra_es_persona_externa'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'¿Corresponde con una institución externa?',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tra_tipos_respon_actividad',
    @level2type = N'COLUMN',
    @level2name = N'tra_es_inst_externa'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Email de notificaciones si es una persona o institución externa',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tra_tipos_respon_actividad',
    @level2type = N'COLUMN',
    @level2name = N'tra_email_externo'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Teléfono de contacto cuando es una persona o institución externa',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tra_tipos_respon_actividad',
    @level2type = N'COLUMN',
    @level2name = N'tra_telefono_externo'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Nombre de una persona contacto, cuando es una institución externa',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tra_tipos_respon_actividad',
    @level2type = N'COLUMN',
    @level2name = N'tra_contacto_externo'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'¿Requiere la selección de un empleado?',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tra_tipos_respon_actividad',
    @level2type = N'COLUMN',
    @level2name = N'tra_requiere_empleo'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Data de los campos adicionales',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tra_tipos_respon_actividad',
    @level2type = N'COLUMN',
    @level2name = N'tra_property_bag_data'
GO
