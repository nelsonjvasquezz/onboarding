CREATE TABLE [obd].[pal_plant_alcances]
(
	[pal_codigo] INT IDENTITY(1,1) NOT NULL,
	[pal_codppr] INT NOT NULL,
	[pal_tipo] AS  (case when NOT [pal_codtpp] IS NULL then 'TipoPuesto' when NOT [pal_codpue] IS NULL then 'Puesto' when NOT [pal_codcdt] IS NULL then 'CentroTrabajo' when NOT [pal_coduni] IS NULL then 'UnidadOrganizativa' else 'Default' end),
	[pal_codtpp] INT NULL,
	[pal_codpue] INT NULL,
	[pal_codcdt] INT NULL,
	[pal_coduni] INT NULL,
	[pal_property_bag_data] XML NULL,
	[pal_usuario_grabacion] VARCHAR(50) NULL,
	[pal_fecha_grabacion] DATETIME NULL,
	[pal_usuario_modificacion] VARCHAR(50) NULL,
	[pal_fecha_modificacion] DATETIME NULL,
 
 	CONSTRAINT [PK_pal_plant_alcances] PRIMARY KEY CLUSTERED ([pal_codigo] ASC),
	CONSTRAINT [FK_obdppr_obdpal] FOREIGN KEY([pal_codppr]) REFERENCES [obd].[ppr_plant_programa] ([ppr_codigo]),
	CONSTRAINT [FK_eortpp_obdpal] FOREIGN KEY ([pal_codtpp]) REFERENCES [eor].[tpp_tipos_puestos] ([tpp_codigo]),
    CONSTRAINT [FK_eorpue_obdpal] FOREIGN KEY ([pal_codpue]) REFERENCES [eor].[pue_puestos] ([pue_codigo]),
    CONSTRAINT [FK_eorcdt_obdpal] FOREIGN KEY ([pal_codcdt]) REFERENCES [eor].[cdt_centros_de_trabajo] ([cdt_codigo]),
    CONSTRAINT [FK_eoruni_obdpal] FOREIGN KEY ([pal_coduni]) REFERENCES [eor].[uni_unidades] ([uni_codigo])
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Tabla que almacena el alcance para la Plantilla del programa',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pal_plant_alcances',
    @level2type = NULL,
    @level2name = NULL
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de registro de alcance para la plantilla de programa de onboarding',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pal_plant_alcances',
    @level2type = N'COLUMN',
    @level2name = N'pal_codigo'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de plantilla de programa de onboarding',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pal_plant_alcances',
    @level2type = N'COLUMN',
    @level2name = N'pal_codppr'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Tipo de Alcance',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pal_plant_alcances',
    @level2type = N'COLUMN',
    @level2name = N'pal_tipo'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de Tipo de Puesto',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pal_plant_alcances',
    @level2type = N'COLUMN',
    @level2name = N'pal_codtpp'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de Puesto',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pal_plant_alcances',
    @level2type = N'COLUMN',
    @level2name = N'pal_codpue'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código del centro de trabajo',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pal_plant_alcances',
    @level2type = N'COLUMN',
    @level2name = N'pal_codcdt'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de la unidad organizativa',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pal_plant_alcances',
    @level2type = N'COLUMN',
    @level2name = N'pal_coduni'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Data de los campos adicionales',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pal_plant_alcances',
    @level2type = N'COLUMN',
    @level2name = N'pal_property_bag_data'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Usuario que creo el registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pal_plant_alcances',
    @level2type = N'COLUMN',
    @level2name = N'pal_usuario_grabacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha en que se creo el registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pal_plant_alcances',
    @level2type = N'COLUMN',
    @level2name = N'pal_fecha_grabacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Usuario que modificó por última vez el registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pal_plant_alcances',
    @level2type = N'COLUMN',
    @level2name = N'pal_usuario_modificacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha de la última modificacion del registro',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'pal_plant_alcances',
    @level2type = N'COLUMN',
    @level2name = N'pal_fecha_modificacion'
GO