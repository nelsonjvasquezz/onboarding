using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using onboarding.data.bases;

namespace onboarding.persistence.configurations
{
    public class ParticipanteProgramaConfiguration : IEntityTypeConfiguration<ParticipantePrograma>
    {
        private readonly string _schema;

        public ParticipanteProgramaConfiguration()
            : this("obd")
        {
        }

        public ParticipanteProgramaConfiguration(string schema)
        {
            _schema = schema;
        }

        public void Configure(EntityTypeBuilder<ParticipantePrograma> builder)
        {
            builder.ToTable("pap_participantes_prg", _schema);
            builder.HasKey(e => e.Codigo);

            builder.Property(e => e.Codigo).HasColumnName("pap_codigo");
            builder.Property(e => e.ProgramaCodigo).HasColumnName("pap_codpro");
            builder.Property(e => e.EmpleoResponsableCodigo).HasColumnName("pap_codemp_resp_rrhh");
            builder.Property(e => e.PuestoCodigo).HasColumnName("pap_codpue");
            builder.Property(e => e.ExpedienteCodigo).HasColumnName("pap_codexp");
            builder.Property(e => e.EmpleoCodigo).HasColumnName("pap_codemp");
            builder.Property(e => e.PlazaCodigo).HasColumnName("pap_codplz");
            builder.Property(e => e.EmpleoJefeCodigo).HasColumnName("pap_codemp_jefe");
            builder.Property(e => e.CentroTrabajoCodigo).HasColumnName("pap_codcdt");
            builder.Property(e => e.UnidadCodigo).HasColumnName("pap_coduni");
            builder.Property(e => e.FechaContratacion).HasColumnName("pap_fecha_contratacion");
            builder.Property(e => e.FechaInicio).HasColumnName("pap_fecha_inicio");
            builder.Property(e => e.FechaFin).HasColumnName("pap_fecha_fin");
            builder.Property(e => e.RawPropertyBagData).HasColumnName("pap_property_bag_data");
            builder.Property(e => e.UsuarioGrabacion).HasColumnName("pap_usuario_grabacion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.FechaGrabacion).HasColumnName("pap_fecha_grabacion");
            builder.Property(e => e.UsuarioUltimaModificacion).HasColumnName("pap_usuario_modificacion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.FechaUltimaModificacion).HasColumnName("pap_fecha_modificacion");

            // Foreign keys
            builder.HasOne(d => d.Programa).WithMany(p => p.Participantes).HasForeignKey(d => d.ProgramaCodigo).OnDelete(DeleteBehavior.NoAction); // FK_obdpro_obdpap
        }
    }
}