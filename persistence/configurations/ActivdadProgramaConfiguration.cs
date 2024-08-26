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
            builder.Property(e => e.ContratacionProgramaCodigo).HasColumnName("acp_codcpr");
            builder.Property(e => e.Nombre).HasColumnName("acp_nombre").HasMaxLength(250).IsUnicode(false);
            builder.Property(e => e.Descripcion).HasColumnName("acp_descripcion").HasMaxLength(500).IsUnicode(false);
            builder.Property(e => e.Objetivo).HasColumnName("acp_objetivo").HasMaxLength(500).IsUnicode(false);
            builder.Property(e => e.EtapaProgramaCodigo).HasColumnName("acp_codetp");
            builder.Property(e => e.TipoActividadCodigo).HasColumnName("acp_codtac");
            builder.Property(e => e.EmpleoResponsableCodigo).HasColumnName("acp_codemp_resp");
            builder.Property(e => e.FechaInicio).HasColumnName("acp_fecha_inicio");
            builder.Property(e => e.FechaFin).HasColumnName("acp_fecha_fin");
            builder.Property(e => e.Duracion).HasColumnName("acp_duracion");
            builder.Property(e => e.UnidadDuracion).HasColumnName("acp_unidad_duracion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.PrioridadActividadCodigo).HasColumnName("acp_codpri");
            builder.Property(e => e.Orden).HasColumnName("acp_orden");
            builder.Property(e => e.TipoResponsableActividadCodigo).HasColumnName("acp_codtra");
            builder.Property(e => e.TipoEvaluacionCodigo).HasColumnName("acp_codtev");
            builder.Property(e => e.FechaEvaluacion).HasColumnName("acp_fecha_evaluacion");
            builder.Property(e => e.NotaEvaluacion).HasColumnName("acp_nota_evaluacion").HasPrecision(19, 4);
            builder.Property(e => e.ResultadoEvaluacion).HasColumnName("acp_resultado_evaluacion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.FormularioDinamicoDataCodigo).HasColumnName("acp_codfdd");
            builder.Property(e => e.Estado).HasColumnName("acp_estado").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.FechaFinalizacion).HasColumnName("acp_fecha_finalizacion");
            builder.Property(e => e.ComentarioFinalizacion).HasColumnName("acp_comentario_finalizacion").HasMaxLength(500).IsUnicode(false);
            builder.Property(e => e.RawPropertyBagData).HasColumnName("acp_property_bag_data").HasColumnType("xml");
            builder.Property(e => e.UsuarioGrabacion).HasColumnName("acp_usuario_grabacion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.FechaGrabacion).HasColumnName("acp_fecha_grabacion");
            builder.Property(e => e.UsuarioModificacion).HasColumnName("acp_usuario_modificacion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.FechaModificacion).HasColumnName("acp_fecha_modificacion");

            // Foreign keys
            builder.HasRequired(d => d.ContratacionPrograma).WithMany(p => p.Actividades).HasForeignKey(d => d.ContratacionProgramaCodigo).WillCascadeOnDelete(false); // FK_obdcpr_obdacp
            builder.HasRequired(d => d.EtapaPrograma).WithMany(p => p.Actividades).HasForeignKey(d => d.EtapaProgramaCodigo).WillCascadeOnDelete(false); // FK_obdetp_obdacp
            builder.HasRequired(d => d.PrioridadActividad).WithMany(p => p.ActividadesProgramas).HasForeignKey(d => d.PrioridadActividadCodigo).WillCascadeOnDelete(false); // FK_obdpri_obdacp
            builder.HasRequired(d => d.TipoActividad).WithMany(p => p.ActividadesProgramas).HasForeignKey(d => d.TipoActividadCodigo).WillCascadeOnDelete(false); // FK_obdtac_obdacp
            builder.HasOne(d => d.TipoEvaluacion).WithMany(p => p.ActividadesProgramas).HasForeignKey(d => d.TipoEvaluacionCodigo).WillCascadeOnDelete(false); // FK_obdtev_obdacp
            builder.HasRequired(d => d.TipoResponsableActividad).WithMany(p => p.ActividadesProgramas).HasForeignKey(d => d.TipoResponsableActividadCodigo).WillCascadeOnDelete(false); // FK_obdtra_obdacp
        }
    }
}