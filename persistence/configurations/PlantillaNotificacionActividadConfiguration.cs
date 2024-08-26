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

            builder.Property(e => e.Codigo).HasColumnName("pna_codigo").HasComment("Código de registro de la plantilla de notificación de la actividad del programa de onboarding");
            builder.Property(e => e.PlantillaActividadCodigo).HasColumnName("pna_codpac").HasComment("Código de la actividad de la plantilla del programa de onboarding");
            builder.Property(e => e.EventoNotificableCodigo).HasColumnName("pna_codeno").HasComment("Código del evento notificable");
            builder.Property(e => e.Subject).HasColumnName("pna_subject").HasMaxLength(250).IsUnicode(false).HasComment("Asunto de la notificación");
            builder.Property(e => e.Body).HasColumnName("pna_body").HasMaxLength(4000).IsUnicode(false).HasComment("Cuerpo Markdown de la notificación");
            builder.Property(e => e.OffsetDias).HasColumnName("pna_offset_dias").HasComment("Desplazamiento en días de la fecha en que ocurre el evento para el envío de la notificación");
            builder.Property(e => e.TipoDestinatario).HasColumnName("pna_tipo_destinatario").HasMaxLength(25).IsUnicode(false).HasDefaultValue("Contratado").HasComment("Destinatario de la notificación: Contratado | JefeInmediato | ResponsableActividad | ResponsableRRHH");
            builder.Property(e => e.FechaGrabacion).HasColumnName("pna_fecha_grabacion").HasColumnType("datetime").HasComment("Fecha en que se creó el registro");
            builder.Property(e => e.FechaModificacion).HasColumnName("pna_fecha_modificacion").HasColumnType("datetime").HasComment("Fecha de la última modificación del registro");
            builder.Property(e => e.RawPropertyBagData).HasColumnName("pna_property_bag_data").HasColumnType("xml").HasComment("Data de los campos adicionales");
            builder.Property(e => e.UsuarioGrabacion).HasColumnName("pna_usuario_grabacion").HasMaxLength(50).IsUnicode(false).HasComment("Usuario que creó el registro");
            builder.Property(e => e.UsuarioModificacion).HasColumnName("pna_usuario_modificacion").HasMaxLength(50).IsUnicode(false).HasComment("Usuario que modificó por última vez el registro");

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