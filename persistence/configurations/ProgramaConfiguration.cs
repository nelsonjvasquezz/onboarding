using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using onboarding.data.bases;

namespace onboarding.persistence.configurations
{
    public class ProgramaConfiguration : IEntityTypeConfiguration<Programa>
    {
        private readonly string _schema;

        public ProgramaConfiguration()
            : this("obd")
        {
        }

        public ProgramaConfiguration(string schema)
        {
            _schema = schema;
        }

        public void Configure(EntityTypeBuilder<Programa> builder)
        {
            builder.ToTable("pro_programa", _schema);
            builder.HasKey(e => e.Codigo);

            builder.Property(e => e.Codigo).HasColumnName("pro_codigo");
            builder.Property(e => e.Nombre).HasColumnName("pro_nombre").HasMaxLength(250).IsUnicode(false);
            builder.Property(e => e.Descripcion).HasColumnName("pro_descripcion").HasMaxLength(500).IsUnicode(false);
            builder.Property(e => e.FechaInicio).HasColumnName("pro_fecha_inicio").HasColumnType("datetime");
            builder.Property(e => e.FechaFin).HasColumnName("pro_fecha_fin").HasColumnType("datetime");
            builder.Property(e => e.FechaGrabacion).HasColumnName("pro_fecha_grabacion").HasColumnType("datetime");
            builder.Property(e => e.FechaModificacion).HasColumnName("pro_fecha_modificacion").HasColumnType("datetime");
            builder.Property(e => e.RawPropertyBagData).HasColumnName("pro_property_bag_data").HasColumnType("xml");
            builder.Property(e => e.UsuarioGrabacion).HasColumnName("pro_usuario_grabacion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.UsuarioModificacion).HasColumnName("pro_usuario_modificacion").HasMaxLength(50).IsUnicode(false);

            builder.HasMany(d => d.ActividadesProgramas)
                .WithOne(p => p.Programa)
                .HasForeignKey(d => d.ProgramaCodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_obdpro_obdacp");
        }
    }
}