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
            builder.Property(e => e.Subject).HasColumnName("pna_subject").HasMaxLength(250).IsUnicode(false);
            builder.Property(e => e.Body).HasColumnName("pna_body").HasMaxLength(4000).IsUnicode(false);
            builder.Property(e => e.FechaGrabacion).HasColumnName("pna_fecha_grabacion");
            builder.Property(e => e.FechaUltimaModificacion).HasColumnName("pna_fecha_modificacion");
            builder.Property(e => e.RawPropertyBagData).HasColumnName("pna_property_bag_data");
            builder.Property(e => e.UsuarioGrabacion).HasColumnName("pna_usuario_grabacion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.UsuarioUltimaModificacion).HasColumnName("pna_usuario_modificacion").HasMaxLength(50).IsUnicode(false);

            builder.HasOne(d => d.PlantillaActividad).WithMany(p => p.PlantillasDeNotificacion).HasForeignKey(d => d.PlantillaActividadCodigo).OnDelete(DeleteBehavior.NoAction); // FK_obdpna_obdpna

        }
    }
}