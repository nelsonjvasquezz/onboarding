CREATE TABLE [obd].[ppa_plant_prerequisitos_act]
(
	[ppa_codpac] INT NOT NULL,
	[ppa_codpac_prerequisito] INT NOT NULL,

 	CONSTRAINT [PK_ppa_plant_prerequisitos_act] PRIMARY KEY CLUSTERED ([ppa_codpac], [ppa_codpac_prerequisito] ASC),
	CONSTRAINT [FK_obdpac_obdppa] FOREIGN KEY([ppa_codpac]) REFERENCES [obd].[pac_plant_actividades] ([pac_codigo]),
	CONSTRAINT [FK_obdpac_obdppa_prerequisito] FOREIGN KEY([ppa_codpac_prerequisito]) REFERENCES [obd].[pac_plant_actividades] ([pac_codigo])
) 

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Tabla que almacena la lista de actividades prerequisito de una actividad de la plantilla',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'ppa_plant_prerequisitos_act',
    @level2type = NULL,
    @level2name = NULL
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de Actividad en la plantilla del programa de onboarding',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'ppa_plant_prerequisitos_act',
    @level2type = N'COLUMN',
    @level2name = N'ppa_codpac'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de Actividad que es prerequisito',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'ppa_plant_prerequisitos_act',
    @level2type = N'COLUMN',
    @level2name = N'ppa_codpac_prerequisito'
GO