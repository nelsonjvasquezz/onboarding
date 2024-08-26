using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using onboarding.data.bases;

namespace onboarding.persistence.configurations
{
    public class TipoActividadConfiguration : IEntityTypeConfiguration<TipoActividad>
    {
        private readonly string _schema;

        public TipoActividadConfiguration()
            : this("obd")
        {
        }

        public TipoActividadConfiguration(string schema)
        {
            _schema = schema;
        }

        public void Configure(EntityTypeBuilder<TipoActividad> builder)
        {
            builder.ToTable("tac_tipo_actividad", _schema);
            builder.HasKey(e => e.Codigo);

            builder.Property(e => e.Codigo).HasColumnName("tac_codigo").HasComment("Código de registro del tipo de actividad");
            builder.Property(e => e.Nombre).HasColumnName("tac_nombre").HasMaxLength(100).IsUnicode(false).HasComment("Nombre del tipo de actividad");
            builder.Property(e => e.Descripcion).HasColumnName("tac_descripcion").HasMaxLength(500).IsUnicode(false).HasComment("Descripción del tipo de actividad");
            builder.Property(e => e.FechaGrabacion).HasColumnName("tac_fecha_grabacion").HasColumnType("datetime").HasComment("Fecha en que se creó el registro");
            builder.Property(e => e.FechaModificacion).HasColumnName("tac_fecha_modificacion").HasColumnType("datetime").HasComment("Fecha de la última modificación del registro");
            builder.Property(e => e.RawPropertyBagData).HasColumnName("tac_property_bag_data").HasColumnType("xml").HasComment("Data de los campos adicionales");
            builder.Property(e => e.UsuarioGrabacion).HasColumnName("tac_usuario_grabacion").HasMaxLength(50).IsUnicode(false).HasComment("Usuario que creó el registro");
            builder.Property(e => e.UsuarioModificacion).HasColumnName("tac_usuario_modificacion").HasMaxLength(50).IsUnicode(false).HasComment("Usuario que modificó por última vez el registro");

            builder.HasMany(d => d.ActividadesProgramas)
                .WithOne(p => p.TipoActividad)
                .HasForeignKey(d => d.TipoActividadCodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_obdtac_obdacp");
        }
    }
}