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

            builder.Property(e => e.Codigo).HasColumnName("ppr_codigo").HasComment("Código de registro de la plantilla del programa de onboarding");
            builder.Property(e => e.Nombre).HasColumnName("ppr_nombre").HasMaxLength(250).IsUnicode(false).HasComment("Nombre de la plantilla del programa");
            builder.Property(e => e.Descripcion).HasColumnName("ppr_descripcion").HasMaxLength(500).IsUnicode(false).HasComment("Descripción de la plantilla del programa");
            builder.Property(e => e.FechaGrabacion).HasColumnName("ppr_fecha_grabacion").HasColumnType("datetime").HasComment("Fecha en que se creó el registro");
            builder.Property(e => e.FechaModificacion).HasColumnName("ppr_fecha_modificacion").HasColumnType("datetime").HasComment("Fecha de la última modificación del registro");
            builder.Property(e => e.RawPropertyBagData).HasColumnName("ppr_property_bag_data").HasColumnType("xml").HasComment("Data de los campos adicionales");
            builder.Property(e => e.UsuarioGrabacion).HasColumnName("ppr_usuario_grabacion").HasMaxLength(50).IsUnicode(false).HasComment("Usuario que creó el registro");
            builder.Property(e => e.UsuarioModificacion).HasColumnName("ppr_usuario_modificacion").HasMaxLength(50).IsUnicode(false).HasComment("Usuario que modificó por última vez el registro");

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