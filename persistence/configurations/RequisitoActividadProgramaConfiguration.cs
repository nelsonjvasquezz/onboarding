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
            builder.HasKey(e => new { e.RapCodpac, e.RapCodacpPrerequisito });

            builder.Property(e => e.RapCodpac).HasColumnName("rap_codpac");
            builder.Property(e => e.RapCodacpPrerequisito).HasColumnName("rap_codacp_prerequisito");

            builder.HasOne(d => d.ActividadPrograma)
                .WithMany(p => p.RapCodpacs)
                .HasForeignKey(d => d.RapCodpac)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_obdacp_obdrpa");

            builder.HasOne(d => d.ActividadPrerequisito)
                .WithMany(p => p.RapCodacpPrerequisitos)
                .HasForeignKey(d => d.RapCodacpPrerequisito)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_obdacp_obdrap_prerequisito");
        }
    }
}