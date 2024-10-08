using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using onboarding.data.bases;

namespace onboarding.persistence.configurations
{
    public class NotificacionActividadConfiguration : IEntityTypeConfiguration<NotificacionActividad>
    {
        private readonly string _schema;

        public NotificacionActividadConfiguration()
            : this("obd")
        {
        }

        public NotificacionActividadConfiguration(string schema)
        {
            _schema = schema;
        }

        public void Configure(EntityTypeBuilder<NotificacionActividad> builder)
        {
            builder.ToTable("nap_notif_actividad_prg", _schema);
            builder.HasKey(e => e.Codigo);

            builder.Property(e => e.Codigo).HasColumnName("nap_codigo");
            builder.Property(e => e.ActividadProgramaCodigo).HasColumnName("nap_codacp");
            builder.Property(e => e.EventoNotificableCodigo).HasColumnName("nap_codeno");
            builder.Property(e => e.OffsetDias).HasColumnName("nap_offset_dias");
            builder.Property(e => e.TipoDestinatarioDb).HasColumnName("nap_tipo_destinatario").HasMaxLength(25).IsUnicode(false).HasDefaultValue("Contratado");
            builder.Property(e => e.EmpleoDestinatarioCodigo).HasColumnName("nap_codemp_destinatario");
            builder.Property(e => e.ExpedienteDestinatarioCodigo).HasColumnName("nap_codexp_destinatario");
            builder.Property(e => e.EmailsDestinatario).HasColumnName("nap_emails_destinatario").HasMaxLength(4000).IsUnicode(false);
            builder.Property(e => e.OneSignalIdsDestinatario).HasColumnName("nap_onesignal_ids_destinatario").HasMaxLength(4000).IsUnicode(false);
            builder.Property(e => e.Subject).HasColumnName("nap_subject").HasMaxLength(250).IsUnicode(false);
            builder.Property(e => e.Body).HasColumnName("nap_body").HasMaxLength(4000).IsUnicode(false);
            builder.Property(e => e.FechaEvento).HasColumnName("nap_fecha_evento");
            builder.Property(e => e.FechaNotificacion).HasColumnName("nap_fecha_notificacion");
            builder.Property(e => e.EstadoDb).HasColumnName("nap_estado").HasMaxLength(10).IsUnicode(false);
            builder.Property(e => e.MensajeError).HasColumnName("nap_mensaje_error").HasMaxLength(4000).IsUnicode(false);

            builder.HasOne(d => d.Actividad).WithMany(p => p.Notificaciones)
                .HasForeignKey(d => d.ActividadProgramaCodigo)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_obdacp_obdnap");

            builder.HasOne(d => d.EventoNotificable).WithMany(p => p.Notificaciones)
                .HasForeignKey(d => d.EventoNotificableCodigo)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("FK_obdeno_obdnap");
        }
    }
}