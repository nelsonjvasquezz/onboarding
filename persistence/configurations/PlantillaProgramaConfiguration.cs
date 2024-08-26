using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using onboarding.data.bases;

namespace onboarding.persistence.configurations
{
    public class PlantillaProgramaConfiguration : IEntityTypeConfiguration<PlantillaPrograma>
    {
        private readonly string _schema;

        public PlantillaProgramaConfiguration()
            : this("obd")
        {
        }

        public PlantillaProgramaConfiguration(string schema)
        {
            _schema = schema;
        }

        public void Configure(EntityTypeBuilder<PlantillaPrograma> builder)
        {
            builder.ToTable("ppr_plant_programa", _schema);
            builder.HasKey(e => e.Codigo);

            builder.Property(e => e.Codigo).HasColumnName("ppr_codigo");
            builder.Property(e => e.Nombre).HasColumnName("ppr_nombre").HasMaxLength(250).IsUnicode(false);
            builder.Property(e => e.Descripcion).HasColumnName("ppr_descripcion").HasMaxLength(500).IsUnicode(false);
            builder.Property(e => e.FechaGrabacion).HasColumnName("ppr_fecha_grabacion").HasColumnType("datetime");
            builder.Property(e => e.FechaModificacion).HasColumnName("ppr_fecha_modificacion").HasColumnType("datetime");
            builder.Property(e => e.RawPropertyBagData).HasColumnName("ppr_property_bag_data").HasColumnType("xml");
            builder.Property(e => e.UsuarioGrabacion).HasColumnName("ppr_usuario_grabacion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.UsuarioModificacion).HasColumnName("ppr_usuario_modificacion").HasMaxLength(50).IsUnicode(false);

            builder.HasMany(d => d.AlcancesPlantillaProgramas)
                .WithOne(p => p.PlantillaPrograma)
                .HasForeignKey(d => d.PlantillaProgramaCodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_obdppr_obdapp");

            builder.HasMany(d => d.PlantillaActividades)
                .WithOne(p => p.PlantillaPrograma)
                .HasForeignKey(d => d.PlantillaProgramaCodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_obdppr_obdpac");
        }
    }
}