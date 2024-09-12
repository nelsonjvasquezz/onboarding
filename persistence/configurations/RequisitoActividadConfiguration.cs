using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using onboarding.data.bases;

namespace onboarding.persistence.configurations
{
    public class RequisitoActividadConfiguration : IEntityTypeConfiguration<RequisitoActividad>
    {
        private readonly string _schema;

        public RequisitoActividadConfiguration()
            : this("obd")
        {
        }

        public RequisitoActividadConfiguration(string schema)
        {
            _schema = schema;
        }

        public void Configure(EntityTypeBuilder<RequisitoActividad> builder)
        {
            builder.ToTable("rap_req_actividades_prg", _schema);
            builder.HasKey(e => new { e.ActividadCodigo, e.ActividadRequisitoCodigo });

            builder.Property(e => e.ActividadCodigo).HasColumnName("rap_codacp");
            builder.Property(e => e.ActividadRequisitoCodigo).HasColumnName("rap_codacp_requisito");

            // TODO: Analizar la configuración
            // Foreign keys
            //builder.HasOne(d => d.Actividad).WithMany(p => p.Requisitos).HasForeignKey(d => d.ActividadCodigo).OnDelete(DeleteBehavior.NoAction); // FK_obdacp_obdrpa
            builder.HasOne(d => d.Requisito).WithMany(p => p.Requisitos).HasForeignKey(d => d.ActividadRequisitoCodigo).OnDelete(DeleteBehavior.Cascade); // FK_obdacp_obdrap_requisito
        }
    }
}