using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using onboarding.data.bases;

namespace onboarding.persistence.configurations
{
    public class NotificacionActividadPlantillaConfiguration : IEntityTypeConfiguration<NotificacionActividadPlantilla>
    {
        private readonly string _schema;

        public NotificacionActividadPlantillaConfiguration()
            : this("obd")
        {
        }

        public NotificacionActividadPlantillaConfiguration(string schema)
        {
            _schema = schema;
        }

        public void Configure(EntityTypeBuilder<NotificacionActividadPlantilla> builder)
        {
            builder.ToTable("pna_plant_notificacion_act", _schema);
            builder.HasKey(e => e.Codigo);

            builder.Property(e => e.Codigo).HasColumnName("pna_codigo");
            builder.Property(e => e.EventoNotificableCodigo).HasColumnName("pna_codeno");
            builder.Property(e => e.ActividadPlantillaCodigo).HasColumnName("pna_codpac");
            builder.Property(e => e.UsaFechaInicio).HasColumnName("pna_usa_fecha_inicio");
            builder.Property(e => e.OffsetInicio).HasColumnName("pna_offset_inicio");
            builder.Property(e => e.OffsetFin).HasColumnName("pna_offset_fin");
            builder.Property(e => e.Subject).HasColumnName("pna_subject").HasMaxLength(250).IsUnicode(false);
            builder.Property(e => e.Body).HasColumnName("pna_body").HasMaxLength(4000).IsUnicode(false);
            builder.Property(e => e.EnviaContratado).HasColumnName("pna_envia_contratado");
            builder.Property(e => e.EnviaJefe).HasColumnName("pna_envia_jefe");
            builder.Property(e => e.EnviaResponsable).HasColumnName("pna_envia_responsable");
            builder.Property(e => e.RawPropertyBagData).HasColumnName("pna_property_bag_data");
            builder.Property(e => e.UsuarioGrabacion).HasColumnName("pna_usuario_grabacion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.FechaGrabacion).HasColumnName("pna_fecha_grabacion");
            builder.Property(e => e.UsuarioUltimaModificacion).HasColumnName("pna_usuario_modificacion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.FechaUltimaModificacion).HasColumnName("pna_fecha_modificacion");

            builder.HasOne(d => d.Actividad).WithMany(p => p.Notificaciones).HasForeignKey(d => d.ActividadPlantillaCodigo).OnDelete(DeleteBehavior.NoAction); // FK_obdpac_obdpna
            builder.HasOne(d => d.EventoNotificable).WithMany(p => p.NotificacionesPlantilla).HasForeignKey(d => d.EventoNotificableCodigo).OnDelete(DeleteBehavior.NoAction); // FK_obdeno_obdpna
        }
    }
}