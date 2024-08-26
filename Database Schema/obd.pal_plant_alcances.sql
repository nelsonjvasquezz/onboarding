CREATE TABLE [obd].[pal_plant_alcances]
(
    [pal_codigo] INT IDENTITY (1, 1) NOT NULL,
    [pal_codppr] INT NOT NULL,
    [pal_tipo]   AS  (case when NOT [pal_codtpp] IS NULL then 'TipoPuesto' when NOT [pal_codpue] IS NULL then 'Puesto' else 'Default' end),
    [pal_codtpp] INT NULL,
    [pal_codpue] INT NULL,
    [pal_property_bag_data] XML NULL,
    [pal_usuario_grabacion] VARCHAR (50) NULL,
    [pal_fecha_grabacion] DATETIME NULL,
    [pal_usuario_modificacion] VARCHAR (50) NULL,
    [pal_fecha_modificacion] DATETIME NULL,

    CONSTRAINT [PK_pal_plant_alcances] PRIMARY KEY CLUSTERED ([pal_codigo] ASC),
    CONSTRAINT [FK_obdppr_obdpap] FOREIGN KEY ([pal_codppr]) REFERENCES [obd].[ppr_plant_programa] ([ppr_codigo]),
    CONSTRAINT [FK_eortpp_obdpap] FOREIGN KEY ([pal_codtpp]) REFERENCES [eor].[tpp_tipos_puestos] ([tpp_codigo]),
    CONSTRAINT [FK_eorpue_obdpap] FOREIGN KEY ([pal_codpue]) REFERENCES [eor].[pue_puestos] ([pue_codigo]),



)

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