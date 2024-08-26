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
            builder.ToTable("app_alcance_plantilla_programa", _schema);
            builder.HasKey(e => e.Codigo);

            builder.Property(e => e.Codigo).HasColumnName("app_codigo");
            builder.Property(e => e.Descripcion).HasColumnName("app_descripcion").HasMaxLength(500).IsUnicode(false);
            builder.Property(e => e.Objetivo).HasColumnName("app_objetivo").HasMaxLength(500).IsUnicode(false);
            builder.Property(e => e.FechaInicio).HasColumnName("app_fecha_inicio").HasColumnType("datetime");
            builder.Property(e => e.FechaFin).HasColumnName("app_fecha_fin").HasColumnType("datetime");
            builder.Property(e => e.FechaGrabacion).HasColumnName("app_fecha_grabacion").HasColumnType("datetime");
            builder.Property(e => e.FechaModificacion).HasColumnName("app_fecha_modificacion").HasColumnType("datetime");
            builder.Property(e => e.UsuarioGrabacion).HasColumnName("app_usuario_grabacion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.UsuarioModificacion).HasColumnName("app_usuario_modificacion").HasMaxLength(50).IsUnicode(false);

            builder.HasOne(d => d.Programa).WithMany(p => p.AlcancesPlantilla)
                .HasForeignKey(d => d.ProgramaCodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_obdprog_obdapp");
        }
    }
}