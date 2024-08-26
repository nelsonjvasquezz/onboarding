using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using onboarding.data.bases;

namespace onboarding.persistence.configurations
{
    public class NotificacionActividadProgramaConfiguration : IEntityTypeConfiguration<NotificacionActividadPrograma>
    {
        private readonly string _schema;

        public NotificacionActividadProgramaConfiguration()
            : this("obd")
        {
        }

        public NotificacionActividadProgramaConfiguration(string schema)
        {
            _schema = schema;
        }

        public void Configure(EntityTypeBuilder<NotificacionActividadPrograma> builder)
        {
            builder.ToTable("nap_notif_actividad_programa", _schema);
            builder.HasKey(e => e.Codigo);

            builder.Property(e => e.Codigo).HasColumnName("nap_codigo").HasComment("Código de registro de la configuración de notificaciones de la actividad del programa");
            builder.Property(e => e.Body).HasColumnName("nap_body").HasMaxLength(4000).IsUnicode(false).HasComment("Cuerpo Markdown de la notificación");
            builder.Property(e => e.ActividadProgramaCodigo).HasColumnName("nap_codacp").HasComment("Código de la Actividad");
            builder.Property(e => e.EventoNotificableCodigo).HasColumnName("nap_codeno").HasComment("Tipo de Evento Notificable");
            builder.Property(e => e.Estado).HasColumnName("nap_estado").HasMaxLength(10).IsUnicode(false).HasComment("Estado de la notificación (NULL | 'Pendiente' | 'Enviada' | 'Error')");
            builder.Property(e => e.FechaEvento).HasColumnName("nap_fecha_evento").HasColumnType("datetime").HasComment("Fecha en que sucedió el evento notificable (está null mientras no se ha dado)");
            builder.Property(e => e.FechaNotificacion).HasColumnName("nap_fecha_notificacion").HasColumnType("datetime").HasComment("Fecha y hora de cuando se notificó");
            builder.Property(e => e.MensajeError).HasColumnName("nap_mensaje_error").HasMaxLength(4000).IsUnicode(false).HasComment("Mensaje o excepción cuando el estado es 'Error'");
            builder.Property(e => e.OffsetDias).HasColumnName("nap_offset_dias").HasComment("Desplazamiento en días de la fecha en que ocurre el evento para el envio de la notificación");
            builder.Property(e => e.Subject).HasColumnName("nap_subject").HasMaxLength(250).IsUnicode(false).HasComment("Asunto de la notificación");
            builder.Property(e => e.TipoDestinatario).HasColumnName("nap_tipo_destinatario").HasMaxLength(25).IsUnicode(false).HasDefaultValue("Contratado").HasComment("Destinatario de la notificación: Contratado | JefeInmediato | ResponsableActividad | ResponsableRRHH");

            builder.HasOne(d => d.ActividadPrograma).WithMany(p => p.NotificacionActividadProgramas)
                .HasForeignKey(d => d.ActividadProgramaCodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_obdacp_obdnap");

            builder.HasOne(d => d.EventoNotificable).WithMany(p => p.NotificacionActividadProgramas)
                .HasForeignKey(d => d.EventoNotificableCodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_obdeno_obdnap");
        }
    }
}