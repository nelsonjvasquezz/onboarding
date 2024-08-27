using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using onboarding.data.bases;

namespace onboarding.persistence.configurations
{
    public class PrerequisitoPlantillaActividadConfiguration : IEntityTypeConfiguration<PrerequisitoPlantillaActividad>
    {
        private readonly string _schema;

        public PrerequisitoPlantillaActividadConfiguration()
            : this("obd")
        {
        }

        public PrerequisitoPlantillaActividadConfiguration(string schema)
        {
            _schema = schema;
        }

        public void Configure(EntityTypeBuilder<PrerequisitoPlantillaActividad> builder)
        {
            builder.ToTable("ppa_plant_prerequisitos_act", _schema);
            builder.HasKey(e => new { e.PlantillaActividadCodigo, e.PlantillaPrerequisitoCodigo });

            builder.Property(e => e.PlantillaActividadCodigo).HasColumnName("ppa_codpac");
            builder.Property(e => e.PlantillaPrerequisitoCodigo).HasColumnName("ppa_codpac_prerequisito");

            // Foreign keys
            builder.HasOne(d => d.PlantillaActividad).WithMany(p => p.Prerequisitos).HasForeignKey(d => d.PlantillaActividadCodigo).OnDelete(DeleteBehavior.NoAction); // FK_obdpac_obdppa
            builder.HasOne(d => d.PlantillaPrerequisito).WithMany(p => p.Prerequisitos).HasForeignKey(d => d.PlantillaPrerequisitoCodigo).OnDelete(DeleteBehavior.NoAction); // FK_obdpac_obdppa_prerequisito
        }
    }
}