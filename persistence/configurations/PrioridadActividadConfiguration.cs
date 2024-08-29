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
            builder.ToTable("pri_prioridades", _schema);
            builder.HasKey(e => e.Codigo);

            builder.Property(e => e.Codigo).HasColumnName("pri_codigo");
            builder.Property(e => e.GrupoCorporativoCodigo).HasColumnName("pri_codgrc");
            builder.Property(e => e.Nombre).HasColumnName("pri_nombre").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.Color).HasColumnName("pri_color").HasMaxLength(20).IsUnicode(false);
            builder.Property(e => e.Icono).HasColumnName("pri_icono").HasMaxLength(500).IsUnicode(false);
            builder.Property(e => e.Orden).HasColumnName("pri_orden");
            builder.Property(e => e.RawPropertyBagData).HasColumnName("pri_property_bag_data");
            builder.Property(e => e.UsuarioGrabacion).HasColumnName("pri_usuario_grabacion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.FechaGrabacion).HasColumnName("pri_fecha_grabacion");
            builder.Property(e => e.UsuarioUltimaModificacion).HasColumnName("pri_usuario_modificacion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.FechaUltimaModificacion).HasColumnName("pri_fecha_modificacion");
        }
    }
}