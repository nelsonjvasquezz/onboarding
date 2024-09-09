using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using onboarding.data.bases;

namespace onboarding.persistence.configurations
{
    public class EventoNotificableConfiguration : IEntityTypeConfiguration<EventoNotificable>
    {
        private readonly string _schema;

        public EventoNotificableConfiguration()
            : this("obd")
        {
        }

        public EventoNotificableConfiguration(string schema)
        {
            _schema = schema;
        }

        public void Configure(EntityTypeBuilder<EventoNotificable> builder)
        {
            builder.ToTable("eno_eventos_notificables", _schema);
            builder.HasKey(e => e.Codigo);

            builder.Property(e => e.Codigo).HasColumnName("eno_codigo");
            builder.Property(e => e.Nombre).HasColumnName("eno_nombre").HasMaxLength(100).IsUnicode(false);
            builder.Property(e => e.DescripcionLocalizationKey).HasColumnName("eno_descripcion_loc_key").HasMaxLength(500).IsUnicode(false);
        }
    }
}