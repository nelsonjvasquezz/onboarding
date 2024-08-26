using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using onboarding.data.bases;

namespace onboarding.persistence.configurations
{
    public class AlcancePlantillaProgramaConfiguration : IEntityTypeConfiguration<AlcancePlantillaPrograma>
    {
        private readonly string _schema;

        public AlcancePlantillaProgramaConfiguration()
            : this("obd")
        {
        }

        public AlcancePlantillaProgramaConfiguration(string schema)
        {
            _schema = schema;
        }

        public void Configure(EntityTypeBuilder<AlcancePlantillaPrograma> builder)
        {
            builder.ToTable("pal_plant_alcances", _schema);
            builder.HasKey(e => e.Codigo);

            builder.Property(e => e.Codigo).HasColumnName("pal_codigo");
            builder.Property(e => e.PlantillaProgramaCodigo).HasColumnName("pal_codppr");
            builder.Property(e => e.Tipo).HasColumnName("pal_tipo");
            builder.Property(e => e.TipoPuestoCodigo).HasColumnName("pal_codtpp");
            builder.Property(e => e.PuestoCodigo).HasColumnName("pal_codpue");
            builder.Property(e => e.RawPropertyBagData).HasColumnName("pal_property_bag_data");
            builder.Property(e => e.UsuarioGrabacion).HasColumnName("pal_usuario_grabacion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.FechaGrabacion).HasColumnName("pal_fecha_grabacion");
            builder.Property(e => e.UsuarioModificacion).HasColumnName("pal_usuario_modificacion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.FechaModificacion).HasColumnName("pal_fecha_modificacion");

            // Foreing keys
            builder.HasRequired(d => d.PlantillaPrograma).WithMany(p => p.Alcances).HasForeignKey(d => d.PlantillaProgramaCodigo).WillCascadeOnDelete(false); // FK_obdppr_obdpap
        }
    }
}