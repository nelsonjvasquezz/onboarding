using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using onboarding.data.bases;

namespace onboarding.persistence.configurations
{
    public class ContratacionProgramaConfiguration : IEntityTypeConfiguration<ContratacionPrograma>
    {
        private readonly string _schema;

        public ContratacionProgramaConfiguration()
            : this("obd")
        {
        }

        public ContratacionProgramaConfiguration(string schema)
        {
            _schema = schema;
        }

        public void Configure(EntityTypeBuilder<ContratacionPrograma> builder)
        {
            builder.ToTable("cpr_contrataciones_programa", _schema);
            builder.HasKey(e => e.Codigo);

            builder.Property(e => e.Codigo).HasColumnName("cpr_codigo");
            builder.Property(e => e.ProgramaCodigo).HasColumnName("cpr_codpro");
            builder.Property(e => e.EmpleoResponsableCodigo).HasColumnName("cpr_codemp_resp_rrhh");
            builder.Property(e => e.PuestoCodigo).HasColumnName("cpr_codpue");
            builder.Property(e => e.ExpedienteCodigo).HasColumnName("cpr_codexp");
            builder.Property(e => e.EmpleoCodigo).HasColumnName("cpr_codemp");
            builder.Property(e => e.EmpleoJefeCodigo).HasColumnName("cpr_codemp_jefe");
            builder.Property(e => e.CentroTrabajoCodigo).HasColumnName("cpr_codcdt");
            builder.Property(e => e.UnidadCodigo).HasColumnName("cpr_coduni");
            builder.Property(e => e.FechaContratacion).HasColumnName("cpr_fecha_contratacion");
            builder.Property(e => e.FechaInicio).HasColumnName("cpr_fecha_inicio");
            builder.Property(e => e.FechaFin).HasColumnName("cpr_fecha_fin");
            builder.Property(e => e.RawPropertyBagData).HasColumnName("cpr_property_bag_data");
            builder.Property(e => e.UsuarioGrabacion).HasColumnName("cpr_usuario_grabacion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.FechaGrabacion).HasColumnName("cpr_fecha_grabacion");
            builder.Property(e => e.UsuarioModificacion).HasColumnName("cpr_usuario_modificacion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.FechaModificacion).HasColumnName("cpr_fecha_modificacion");

            // Foreign keys
            builder.HasOne(d => d.Programa).WithMany(p => p.Contrataciones).HasForeignKey(d => d.ProgramaCodigo).OnDelete(DeleteBehavior.NoAction); // FK_obdpro_obdcpr
        }
    }
}