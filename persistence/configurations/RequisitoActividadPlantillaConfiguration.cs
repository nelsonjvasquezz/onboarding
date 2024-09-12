using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using onboarding.data.bases;

namespace onboarding.persistence.configurations
{
    public class RequisitoActividadPlantillaConfiguration : IEntityTypeConfiguration<RequisitoActividadPlantilla>
    {
        private readonly string _schema;

        public RequisitoActividadPlantillaConfiguration()
            : this("obd")
        {
        }

        public RequisitoActividadPlantillaConfiguration(string schema)
        {
            _schema = schema;
        }

        public void Configure(EntityTypeBuilder<RequisitoActividadPlantilla> builder)
        {
            builder.ToTable("ppa_plant_requisitos_act", _schema);
            builder.HasKey(e => new { e.ActividadCodigo, e.ActividadRequisitoCodigo });

            builder.Property(e => e.ActividadCodigo).HasColumnName("ppa_codpac");
            builder.Property(e => e.ActividadRequisitoCodigo).HasColumnName("ppa_codpac_requisito");

            // TODO: Analizar la configuración
            // Foreign keys
            //builder.HasOne(d => d.Actividad).WithMany(p => p.Requisitos).HasForeignKey(d => d.ActividadCodigo).OnDelete(DeleteBehavior.NoAction); // FK_obdpac_obdppa
            builder.HasOne(d => d.Requisito).WithMany(p => p.Requisitos).HasForeignKey(d => d.ActividadRequisitoCodigo).OnDelete(DeleteBehavior.Cascade); // FK_obdpac_obdppa_requisito
        }
    }
}