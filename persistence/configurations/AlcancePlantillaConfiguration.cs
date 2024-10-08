using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using onboarding.data.bases;

namespace onboarding.persistence.configurations
{
    public class AlcancePlantillaConfiguration : IEntityTypeConfiguration<AlcancePlantilla>
    {
        private readonly string _schema;

        public AlcancePlantillaConfiguration()
            : this("obd")
        {
        }

        public AlcancePlantillaConfiguration(string schema)
        {
            _schema = schema;
        }

        public void Configure(EntityTypeBuilder<AlcancePlantilla> builder)
        {
            builder.ToTable("pal_plant_alcances", _schema);
            builder.HasKey(e => e.Codigo);

            builder.Property(e => e.Codigo).HasColumnName("pal_codigo");
            builder.Property(e => e.PlantillaProgramaCodigo).HasColumnName("pal_codppr");
            builder.Property(e => e.TipoDb).HasColumnName("pal_tipo");
            builder.Property(e => e.TipoPuestoCodigo).HasColumnName("pal_codtpp");
            builder.Property(e => e.PuestoCodigo).HasColumnName("pal_codpue");
            builder.Property(e => e.CentroTrabajoCodigo).HasColumnName("pal_codcdt");
            builder.Property(e => e.UnidadCodigo).HasColumnName("pal_coduni");
            builder.Property(e => e.RawPropertyBagData).HasColumnName("pal_property_bag_data");
            builder.Property(e => e.UsuarioGrabacion).HasColumnName("pal_usuario_grabacion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.FechaGrabacion).HasColumnName("pal_fecha_grabacion");
            builder.Property(e => e.UsuarioUltimaModificacion).HasColumnName("pal_usuario_modificacion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.FechaUltimaModificacion).HasColumnName("pal_fecha_modificacion");

            // Foreing keys
            builder.HasOne(d => d.Plantilla).WithMany(p => p.Alcances).HasForeignKey(d => d.PlantillaProgramaCodigo).OnDelete(DeleteBehavior.Cascade); // FK_obdppr_obdpal
        }
    }
}