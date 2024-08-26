CREATE TABLE [obd].[tev_tipos_evaluacion]
(
    [tev_codigo]               INT          IDENTITY (1, 1) NOT NULL,
    [tev_codgrc]               INT          NOT NULL,
    [tev_nombre]               VARCHAR(100) NOT NULL,
    [tev_descripcion]          VARCHAR(500) NULL,
    [tev_utiliza_fdi]          BIT          CONSTRAINT [DF_obd_tev_utiliza_fdi] DEFAULT ((0)) NOT NULL,
    [tev_codfdi_evaluacion]    INT NULL,
    [tev_property_bag_data]    XML          NULL,
    [tev_usuario_grabacion]    VARCHAR(50)  NULL,
    [tev_fecha_grabacion]      DATETIME     NULL,
    [tev_usuario_modificacion] VARCHAR(50)  NULL,
    [tev_fecha_modificacion]   DATETIME     NULL,

    CONSTRAINT [PK_tev_tipos_evaluacion] PRIMARY KEY CLUSTERED ([tev_codigo] ASC),
    CONSTRAINT [FK_eorgrc_obdtev] FOREIGN KEY ([tev_codgrc]) REFERENCES [eor].[grc_grupos_corporativos] ([grc_codigo]),
    CONSTRAINT [FK_genfdi_obdtev] FOREIGN KEY ([tev_codfdi_evaluacion]) REFERENCES [gen].[fdi_formulario_dinamico] ([fdi_codigo]),

)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código del tipo de evaluación',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tev_tipos_evaluacion',
    @level2type = N'COLUMN',
    @level2name = N'tev_codigo'
GO

GO

EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Descripción del tipo de evaluación',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tev_tipos_evaluacion',
    @level2type = N'COLUMN',
    @level2name = N'tev_descripcion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Nombre del tipo de evaluación',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tev_tipos_evaluacion',
    @level2type = N'COLUMN',
    @level2name = N'tev_nombre'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código del Grupo Corporativo',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tev_tipos_evaluacion',
    @level2type = N'COLUMN',
    @level2name = N'tev_codgrc'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Usuario que creo el registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tev_tipos_evaluacion',
    @level2type = N'COLUMN',
    @level2name = N'tev_usuario_grabacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha en que se creo el registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tev_tipos_evaluacion',
    @level2type = N'COLUMN',
    @level2name = N'tev_fecha_grabacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Usuario que modificó por última vez el registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tev_tipos_evaluacion',
    @level2type = N'COLUMN',
    @level2name = N'tev_usuario_modificacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha de la última modificacion del registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tev_tipos_evaluacion',
    @level2type = N'COLUMN',
    @level2name = N'tev_fecha_modificacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Tabla con los tipos de evaluaciones que se aplican a las actividades de los planes de onboarding',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tev_tipos_evaluacion',
    @level2type = NULL,
    @level2name = NULL
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Data de los campos adicionales',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tev_tipos_evaluacion',
    @level2type = N'COLUMN',
    @level2name = N'tev_property_bag_data'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Determina si el tipo de evaluación utiliza un formulario dinámico',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tev_tipos_evaluacion',
    @level2type = N'COLUMN',
    @level2name = N'tev_utiliza_fdi'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de formulario dinámico que se utiliza para evaluar una actividad cuando si se utiliza',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'tev_tipos_evaluacion',
    @level2type = N'COLUMN',
    @level2name = N'tev_codfdi_evaluacion'