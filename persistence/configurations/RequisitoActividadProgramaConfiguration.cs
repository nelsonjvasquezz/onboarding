using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using onboarding.data.bases;

namespace onboarding.persistence.configurations
{
    public class RequisitoActividadProgramaConfiguration : IEntityTypeConfiguration<RequisitoActividadPrograma>
    {
        private readonly string _schema;

        public RequisitoActividadProgramaConfiguration()
            : this("obd")
        {
        }

        public RequisitoActividadProgramaConfiguration(string schema)
        {
            _schema = schema;
        }

        public void Configure(EntityTypeBuilder<RequisitoActividadPrograma> builder)
        {
            builder.ToTable("rap_req_actividades_programa", _schema);
            builder.HasKey(e => new { e.ActividadCodigo, e.ActividadPrerequisitoCodigo });

            builder.Property(e => e.ActividadCodigo).HasColumnName("rap_codpac");
            builder.Property(e => e.ActividadPrerequisitoCodigo).HasColumnName("rap_codacp_prerequisito");

            // Foreign keys
            builder.HasOne(d => d.ActividadPrograma).WithMany(p => p.ActividadesPrerequisitos).HasForeignKey(d => d.ActividadCodigo).OnDelete(DeleteBehavior.NoAction); // FK_obdacp_obdrpa
            builder.HasOne(d => d.ActividadPrerequisito).WithMany(p => p.ActividadesPrerequisitos).HasForeignKey(d => d.ActividadPrerequisitoCodigo).OnDelete(DeleteBehavior.NoAction); // FK_obdacp_obdrap_prerequisito
        }
    }
}