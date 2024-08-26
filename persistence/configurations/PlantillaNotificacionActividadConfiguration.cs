using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using onboarding.data.bases;

namespace onboarding.persistence.configurations
{
    public class PlantillaNotificacionActividadConfiguration : IEntityTypeConfiguration<PlantillaNotificacionActividad>
    {
        private readonly string _schema;

        public PlantillaNotificacionActividadConfiguration()
            : this("obd")
        {
        }

        public PlantillaNotificacionActividadConfiguration(string schema)
        {
            _schema = schema;
        }

        public void Configure(EntityTypeBuilder<PlantillaNotificacionActividad> builder)
        {
            builder.ToTable("pna_plant_notif_actividad", _schema);
            builder.HasKey(e => e.Codigo);

            builder.Property(e => e.Codigo).HasColumnName("pna_codigo");
            builder.Property(e => e.PlantillaActividadCodigo).HasColumnName("pna_codpac");
            builder.Property(e => e.EventoNotificableCodigo).HasColumnName("pna_codeno");
            builder.Property(e => e.Subject).HasColumnName("pna_subject").HasMaxLength(250).IsUnicode(false);
            builder.Property(e => e.Body).HasColumnName("pna_body").HasMaxLength(4000).IsUnicode(false);
            builder.Property(e => e.OffsetDias).HasColumnName("pna_offset_dias");
            builder.Property(e => e.TipoDestinatario).HasColumnName("pna_tipo_destinatario").HasMaxLength(25).IsUnicode(false).HasDefaultValue("Contratado");
            builder.Property(e => e.FechaGrabacion).HasColumnName("pna_fecha_grabacion").HasColumnType("datetime");
            builder.Property(e => e.FechaModificacion).HasColumnName("pna_fecha_modificacion").HasColumnType("datetime");
            builder.Property(e => e.RawPropertyBagData).HasColumnName("pna_property_bag_data").HasColumnType("xml");
            builder.Property(e => e.UsuarioGrabacion).HasColumnName("pna_usuario_grabacion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.UsuarioModificacion).HasColumnName("pna_usuario_modificacion").HasMaxLength(50).IsUnicode(false);

            builder.HasOne(d => d.PlantillaActividad).WithMany(p => p.PlantillaNotificacionActividades)
                .HasForeignKey(d => d.PlantillaActividadCodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_obdpac_obdpna");

            builder.HasOne(d => d.EventoNotificable).WithMany(p => p.PlantillaNotificacionActividades)
                .HasForeignKey(d => d.EventoNotificableCodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_obdeno_obdpna");
        }
    }
}