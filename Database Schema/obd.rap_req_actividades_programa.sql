CREATE TABLE [obd].[rap_req_actividades_programa]
(
    [rap_codpac] INT NOT NULL,
    [rap_codacp_prerequisito] INT NOT NULL,

    CONSTRAINT [PK_rap_req_actividades_programa] PRIMARY KEY CLUSTERED ([rap_codpac], [rap_codacp_prerequisito] ASC),
    CONSTRAINT [FK_obdacp_obdrpa] FOREIGN KEY ([rap_codpac]) REFERENCES [obd].[acp_actividades_programa] ([acp_codigo]),
    CONSTRAINT [FK_obdacp_obdrap_prerequisito] FOREIGN KEY ([rap_codacp_prerequisito]) REFERENCES [obd].[acp_actividades_programa] ([acp_codigo])
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de Actividad en el programa de onboarding',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'rap_req_actividades_programa',
    @level2type = N'COLUMN',
    @level2name = N'rap_codpac'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Código de Actividad que es prerequisito',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'rap_req_actividades_programa',
    @level2type = N'COLUMN',
    @level2name = N'rap_codacp_prerequisito'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Tabla que almacena la lista de actividades prerequisito de una actividad para el programa de onboarding',
    @level0type = N'SCHEMA',
    @level0name = N'obd',
    @level1type = N'TABLE',
    @level1name = N'rap_req_actividades_programa',
    @level2type = NULL,
    @level2name = NULL