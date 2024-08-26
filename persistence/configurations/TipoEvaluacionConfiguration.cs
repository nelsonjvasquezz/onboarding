using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using onboarding.data.bases;

namespace onboarding.persistence.configurations
{
    public class TipoEvaluacionConfiguration : IEntityTypeConfiguration<TipoEvaluacion>
    {
        private readonly string _schema;

        public TipoEvaluacionConfiguration()
            : this("obd")
        {
        }

        public TipoEvaluacionConfiguration(string schema)
        {
            _schema = schema;
        }

        public void Configure(EntityTypeBuilder<TipoEvaluacion> builder)
        {
            builder.ToTable("tev_tipo_evaluacion", _schema);
            builder.HasKey(e => e.Codigo);

            builder.Property(e => e.Codigo).HasColumnName("tev_codigo");
            builder.Property(e => e.Nombre).HasColumnName("tev_nombre").HasMaxLength(100).IsUnicode(false);
            builder.Property(e => e.Descripcion).HasColumnName("tev_descripcion").HasMaxLength(500).IsUnicode(false);
            builder.Property(e => e.FechaGrabacion).HasColumnName("tev_fecha_grabacion").HasColumnType("datetime");
            builder.Property(e => e.FechaModificacion).HasColumnName("tev_fecha_modificacion").HasColumnType("datetime");
            builder.Property(e => e.RawPropertyBagData).HasColumnName("tev_property_bag_data").HasColumnType("xml");
            builder.Property(e => e.UsuarioGrabacion).HasColumnName("tev_usuario_grabacion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.UsuarioModificacion).HasColumnName("tev_usuario_modificacion").HasMaxLength(50).IsUnicode(false);

            builder.HasMany(d => d.Evaluaciones)
                .WithOne(p => p.TipoEvaluacion)
                .HasForeignKey(d => d.TipoEvaluacionCodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_obdtev_obdevl");
        }
    }
}