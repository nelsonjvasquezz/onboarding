using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using onboarding.data.bases;

namespace onboarding.persistence.configurations
{
    public class PlantillaActividadConfiguration : IEntityTypeConfiguration<PlantillaActividad>
    {
        private readonly string _schema;

        public PlantillaActividadConfiguration()
            : this("obd")
        {
        }

        public PlantillaActividadConfiguration(string schema)
        {
            _schema = schema;
        }

        public void Configure(EntityTypeBuilder<PlantillaActividad> builder)
        {
            builder.ToTable("pac_plant_actividades", _schema);
            builder.HasKey(e => e.Codigo);

            builder.Property(e => e.Codigo).HasColumnName("pac_codigo");
            builder.Property(e => e.EtapaProgramaCodigo).HasColumnName("pac_codetp");
            builder.Property(e => e.PlantillaProgramaCodigo).HasColumnName("pac_codppr");
            builder.Property(e => e.PrioridadActividadCodigo).HasColumnName("pac_codpri");
            builder.Property(e => e.Descripcion).HasColumnName("pac_descripcion").HasMaxLength(500).IsUnicode(false);
            builder.Property(e => e.FechaGrabacion).HasColumnName("pac_fecha_grabacion").HasColumnType("datetime");
            builder.Property(e => e.FechaModificacion).HasColumnName("pac_fecha_modificacion").HasColumnType("datetime");
            builder.Property(e => e.RawPropertyBagData).HasColumnName("pac_property_bag_data").HasColumnType("xml");
            builder.Property(e => e.UsuarioGrabacion).HasColumnName("pac_usuario_grabacion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.UsuarioModificacion).HasColumnName("pac_usuario_modificacion").HasMaxLength(50).IsUnicode(false);

            builder.HasOne(d => d.EtapaPrograma).WithMany(p => p.PlantillaActividades)
                .HasForeignKey(d => d.EtapaProgramaCodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_obdetp_obdpac");

            builder.HasOne(d => d.PlantillaPrograma).WithMany(p => p.PlantillaActividades)
                .HasForeignKey(d => d.PlantillaProgramaCodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_obdppr_obdpac");

            builder.HasOne(d => d.PrioridadActividad).WithMany(p => p.PlantillaActividades)
                .HasForeignKey(d => d.PrioridadActividadCodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_obdpri_obdpac");
        }
    }
}