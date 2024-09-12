CREATE TABLE [obd].[rap_req_actividades_prg]
(
	[rap_codacp] INT NOT NULL,
	[rap_codacp_requisito] INT NOT NULL,

 	CONSTRAINT [PK_rap_req_actividades_prg] PRIMARY KEY CLUSTERED ([rap_codacp], [rap_codacp_requisito] ASC),
	CONSTRAINT [FK_obdacp_obdrpa] FOREIGN KEY([rap_codacp]) REFERENCES [obd].[acp_actividades_prg] ([acp_codigo]),
	CONSTRAINT [FK_obdacp_obdrap_requisito] FOREIGN KEY([rap_codacp_requisito]) REFERENCES [obd].[acp_actividades_prg] ([acp_codigo])
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Tabla que almacena los requisitos de las actividades del programa de onboarding',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'rap_req_actividades_prg',
    @level2type = NULL,
    @level2name = NULL
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de Actividad en el programa de onboarding',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'rap_req_actividades_prg',
    @level2type = N'COLUMN',
    @level2name = N'rap_codacp'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de Actividad requisito en el programa de onboarding',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'rap_req_actividades_prg',
    @level2type = N'COLUMN',
    @level2name = N'rap_codacp_requisito'
GO
