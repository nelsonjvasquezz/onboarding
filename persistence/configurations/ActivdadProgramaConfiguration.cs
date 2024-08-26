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
            builder.Property(e => e.Descripcion).HasColumnName("acp_descripcion").HasMaxLength(500).IsUnicode(false);
            builder.Property(e => e.Objetivo).HasColumnName("acp_objetivo").HasMaxLength(500).IsUnicode(false);
            builder.Property(e => e.EtapaProgramaCodigo).HasColumnName("acp_codetp");
            builder.Property(e => e.TipoActividadCodigo).HasColumnName("acp_codtac");
            builder.Property(e => e.EmpleoResponsableCodigo).HasColumnName("acp_codemp_resp");
            builder.Property(e => e.FechaInicio).HasColumnName("acp_fecha_inicio").HasColumnType("datetime");
            builder.Property(e => e.FechaFin).HasColumnName("acp_fecha_fin").HasColumnType("datetime");
            builder.Property(e => e.FechaGrabacion).HasColumnName("acp_fecha_grabacion").HasColumnType("datetime");
            builder.Property(e => e.FechaModificacion).HasColumnName("acp_fecha_modificacion").HasColumnType("datetime");
            builder.Property(e => e.RawPropertyBagData).HasColumnName("acp_property_bag_data").HasColumnType("xml");
            builder.Property(e => e.UsuarioGrabacion).HasColumnName("acp_usuario_grabacion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.UsuarioModificacion).HasColumnName("acp_usuario_modificacion").HasMaxLength(50).IsUnicode(false);

            builder.HasOne(d => d.EtapaPrograma).WithMany(p => p.ActividadesProgramas)
                .HasForeignKey(d => d.EtapaProgramaCodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_obdetp_obdacp");

            builder.HasOne(d => d.TipoActividad).WithMany(p => p.ActividadesProgramas)
                .HasForeignKey(d => d.TipoActividadCodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_obdtac_obdacp");

            builder.HasOne(d => d.EmpleoResponsable).WithMany(p => p.ActividadesProgramas)
                .HasForeignKey(d => d.EmpleoResponsableCodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_obdemp_obdacp");
        }
    }
}