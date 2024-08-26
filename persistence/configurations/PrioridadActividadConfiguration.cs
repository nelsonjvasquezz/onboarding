using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using onboarding.data.bases;

namespace onboarding.persistence.configurations
{
    public class PrioridadActividadConfiguration : IEntityTypeConfiguration<PrioridadActividad>
    {
        private readonly string _schema;

        public PrioridadActividadConfiguration()
            : this("obd")
        {
        }

        public PrioridadActividadConfiguration(string schema)
        {
            _schema = schema;
        }

        public void Configure(EntityTypeBuilder<PrioridadActividad> builder)
        {
            builder.ToTable("pri_prioridad_actividad", _schema);
            builder.HasKey(e => e.Codigo);

            builder.Property(e => e.Codigo).HasColumnName("pri_codigo").HasComment("Código de registro de la prioridad de la actividad");
            builder.Property(e => e.Nombre).HasColumnName("pri_nombre").HasMaxLength(100).IsUnicode(false).HasComment("Nombre de la prioridad de la actividad");
            builder.Property(e => e.Descripcion).HasColumnName("pri_descripcion").HasMaxLength(500).IsUnicode(false).HasComment("Descripción de la prioridad de la actividad");
            builder.Property(e => e.FechaGrabacion).HasColumnName("pri_fecha_grabacion").HasColumnType("datetime").HasComment("Fecha en que se creó el registro");
            builder.Property(e => e.FechaModificacion).HasColumnName("pri_fecha_modificacion").HasColumnType("datetime").HasComment("Fecha de la última modificación del registro");
            builder.Property(e => e.RawPropertyBagData).HasColumnName("pri_property_bag_data").HasColumnType("xml").HasComment("Data de los campos adicionales");
            builder.Property(e => e.UsuarioGrabacion).HasColumnName("pri_usuario_grabacion").HasMaxLength(50).IsUnicode(false).HasComment("Usuario que creó el registro");
            builder.Property(e => e.UsuarioModificacion).HasColumnName("pri_usuario_modificacion").HasMaxLength(50).IsUnicode(false).HasComment("Usuario que modificó por última vez el registro");

            builder.HasMany(d => d.PlantillaActividades)
                .WithOne(p => p.PrioridadActividad)
                .HasForeignKey(d => d.PrioridadActividadCodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_obdpri_obdpac");
        }
    }
}