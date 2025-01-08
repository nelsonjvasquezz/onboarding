using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using onboarding.data.bases;

namespace onboarding.persistence.configurations
{
    public class ParticipanteSinAsignarConfiguration : IEntityTypeConfiguration<ParticipanteSinAsignar>
    {
        private readonly string _schema;

        public ParticipanteSinAsignarConfiguration()
            : this("obd")
        {
        }

        public ParticipanteSinAsignarConfiguration(string schema)
        {
            _schema = schema;
        }

        public void Configure(EntityTypeBuilder<ParticipanteSinAsignar> builder)
        {
            builder.ToTable("psa_part_sin_asignar", _schema);
            builder.HasKey(e => e.Codigo);

            builder.Property(e => e.Codigo).HasColumnName("psa_codigo");
            builder.Property(e => e.ParticipanteProgramaCodigo).HasColumnName("psa_codpap");
            builder.Property(e => e.ContratacionCodigo).HasColumnName("psa_codcon");
            builder.Property(e => e.ConcursoCodigo).HasColumnName("psa_codcos");
            builder.Property(e => e.PuestoCodigo).HasColumnName("psa_codpue");
            builder.Property(e => e.ExpedienteCodigo).HasColumnName("psa_codexp");
            builder.Property(e => e.EmpleoCodigo).HasColumnName("psa_codemp");
            builder.Property(e => e.PlazaCodigo).HasColumnName("psa_codplz");
            builder.Property(e => e.EmpleoJefeCodigo).HasColumnName("psa_codemp_jefe");
            builder.Property(e => e.CentroTrabajoCodigo).HasColumnName("psa_codcdt");
            builder.Property(e => e.UnidadCodigo).HasColumnName("psa_coduni");
            builder.Property(e => e.FechaContratacion).HasColumnName("psa_fecha_contratacion");
            builder.Property(e => e.UsuarioGrabacion).HasColumnName("psa_usuario_grabacion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.FechaGrabacion).HasColumnName("psa_fecha_grabacion");
            builder.Property(e => e.UsuarioUltimaModificacion).HasColumnName("psa_usuario_modificacion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.FechaUltimaModificacion).HasColumnName("psa_fecha_modificacion");

            // Foreign keys
            builder.HasOne(d => d.Participante).WithOne(p => p.ParticipanteSinAsignar).HasForeignKey<ParticipanteSinAsignar>(d => d.ParticipanteProgramaCodigo).OnDelete(DeleteBehavior.NoAction); // FK_obdpap_obdpsa
        }
    }
}