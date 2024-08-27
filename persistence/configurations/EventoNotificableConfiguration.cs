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
            builder.Property(e => e.GrupoCorporativoCodigo).HasColumnName("eno_codgrc");
            builder.Property(e => e.Nombre).HasColumnName("eno_nombre").HasMaxLength(100).IsUnicode(false);
            builder.Property(e => e.Descripcion).HasColumnName("eno_descripcion").HasMaxLength(500).IsUnicode(false);
            builder.Property(e => e.RawPropertyBagData).HasColumnName("eno_property_bag_data").HasColumnType("xml");
            builder.Property(e => e.UsuarioGrabacion).HasColumnName("eno_usuario_grabacion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.FechaGrabacion).HasColumnName("eno_fecha_grabacion");
            builder.Property(e => e.UsuarioModificacion).HasColumnName("eno_usuario_modificacion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.FechaModificacion).HasColumnName("eno_fecha_modificacion");
        }
    }
}