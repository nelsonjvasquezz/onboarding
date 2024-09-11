using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using onboarding.data.bases;

namespace onboarding.persistence.configurations
{
    public class ActividadProgramaConfiguration : IEntityTypeConfiguration<ActividadPrograma>
    {
        private readonly string _schema;

        public ActividadProgramaConfiguration()
            : this("obd")
        {
        }

        public ActividadProgramaConfiguration(string schema)
        {
            _schema = schema;
        }

        public void Configure(EntityTypeBuilder<ActividadPrograma> builder)
        {
            builder.ToTable("acp_actividades_programa", _schema);
            builder.HasKey(e => e.Codigo);

            builder.Property(e => e.Codigo).HasColumnName("acp_codigo");
            builder.Property(e => e.ParticipanteProgramaCodigo).HasColumnName("acp_codpap");
            builder.Property(e => e.Nombre).HasColumnName("acp_nombre").HasMaxLength(250).IsUnicode(false);
            builder.Property(e => e.Descripcion).HasColumnName("acp_descripcion").HasMaxLength(4000).IsUnicode(false);
            builder.Property(e => e.Objetivo).HasColumnName("acp_objetivo").HasMaxLength(4000).IsUnicode(false);
            builder.Property(e => e.EtapaProgramaCodigo).HasColumnName("acp_codetp");
            builder.Property(e => e.TipoActividadCodigo).HasColumnName("acp_codtac");
            builder.Property(e => e.EmpleoResponsableCodigo).HasColumnName("acp_codemp_responsable");
            builder.Property(e => e.FechaInicio).HasColumnName("acp_fecha_inicio");
            builder.Property(e => e.FechaFin).HasColumnName("acp_fecha_fin");
            builder.Property(e => e.Duracion).HasColumnName("acp_duracion");
            builder.Property(e => e.UnidadDuracionDb).HasColumnName("acp_unidad_duracion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.PrioridadActividadCodigo).HasColumnName("acp_codpri");
            builder.Property(e => e.Orden).HasColumnName("acp_orden");
            builder.Property(e => e.TipoResponsableActividadCodigo).HasColumnName("acp_codtra");
            builder.Property(e => e.TipoEvaluacionCodigo).HasColumnName("acp_codtev");
            builder.Property(e => e.FechaEvaluacion).HasColumnName("acp_fecha_evaluacion");
            builder.Property(e => e.NotaEvaluacion).HasColumnName("acp_nota_evaluacion").HasPrecision(5, 2);
            builder.Property(e => e.ResultadoEvaluacionDb).HasColumnName("acp_resultado_evaluacion").HasMaxLength(100).IsUnicode(false);
            builder.Property(e => e.FormularioDinamicoDataCodigo).HasColumnName("acp_codfdd");
            builder.Property(e => e.EstadoDb).HasColumnName("acp_estado").HasMaxLength(10).IsUnicode(false);
            builder.Property(e => e.FechaFinalizacion).HasColumnName("acp_fecha_finalizacion");
            builder.Property(e => e.ComentarioFinalizacion).HasColumnName("acp_comentario_finalizacion").HasMaxLength(4000).IsUnicode(false);
            builder.Property(e => e.RawPropertyBagData).HasColumnName("acp_property_bag_data");
            builder.Property(e => e.UsuarioGrabacion).HasColumnName("acp_usuario_grabacion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.FechaGrabacion).HasColumnName("acp_fecha_grabacion");
            builder.Property(e => e.UsuarioUltimaModificacion).HasColumnName("acp_usuario_modificacion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.FechaUltimaModificacion).HasColumnName("acp_fecha_modificacion");

            // Foreign keys
            builder.HasOne(d => d.Participante).WithMany(p => p.Actividades).HasForeignKey(d => d.ParticipanteProgramaCodigo).OnDelete(DeleteBehavior.NoAction); // FK_obdpap_obdacp
            builder.HasOne(d => d.Etapa).WithMany(p => p.Actividades).HasForeignKey(d => d.EtapaProgramaCodigo).OnDelete(DeleteBehavior.NoAction); // FK_obdetp_obdacp
            builder.HasOne(d => d.Prioridad).WithMany(p => p.Actividades).HasForeignKey(d => d.PrioridadActividadCodigo).OnDelete(DeleteBehavior.NoAction); // FK_obdpri_obdacp
            builder.HasOne(d => d.Tipo).WithMany(p => p.Actividades).HasForeignKey(d => d.TipoActividadCodigo).OnDelete(DeleteBehavior.NoAction); // FK_obdtac_obdacp
            builder.HasOne(d => d.TipoEvaluacion).WithMany(p => p.Actividades).HasForeignKey(d => d.TipoEvaluacionCodigo).OnDelete(DeleteBehavior.NoAction); // FK_obdtev_obdacp
            builder.HasOne(d => d.TipoResponsable).WithMany(p => p.Actividades).HasForeignKey(d => d.TipoResponsableActividadCodigo).OnDelete(DeleteBehavior.NoAction); // FK_obdtra_obdacp
        }
    }
}