using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using onboarding.data.bases;

namespace onboarding.persistence.configurations
{
    public class TipoResponsableActividadConfiguration : IEntityTypeConfiguration<TipoResponsableActividad>
    {
        private readonly string _schema;

        public TipoResponsableActividadConfiguration()
            : this("obd")
        {
        }

        public TipoResponsableActividadConfiguration(string schema)
        {
            _schema = schema;
        }

        public void Configure(EntityTypeBuilder<TipoResponsableActividad> builder)
        {
            builder.ToTable("tra_tipo_responsable_actividad", _schema);
            builder.HasKey(e => e.Codigo);

            builder.Property(e => e.Codigo).HasColumnName("tra_codigo");
            builder.Property(e => e.Nombre).HasColumnName("tra_nombre").HasMaxLength(100).IsUnicode(false);
            builder.Property(e => e.Descripcion).HasColumnName("tra_descripcion").HasMaxLength(500).IsUnicode(false);
            builder.Property(e => e.FechaGrabacion).HasColumnName("tra_fecha_grabacion").HasColumnType("datetime");
            builder.Property(e => e.FechaModificacion).HasColumnName("tra_fecha_modificacion").HasColumnType("datetime");
            builder.Property(e => e.RawPropertyBagData).HasColumnName("tra_property_bag_data").HasColumnType("xml");
            builder.Property(e => e.UsuarioGrabacion).HasColumnName("tra_usuario_grabacion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.UsuarioModificacion).HasColumnName("tra_usuario_modificacion").HasMaxLength(50).IsUnicode(false);

            builder.HasMany(d => d.ActividadesProgramas)
                .WithOne(p => p.TipoResponsableActividad)
                .HasForeignKey(d => d.TipoResponsableActividadCodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_obdtra_obdacp");
        }
    }
}