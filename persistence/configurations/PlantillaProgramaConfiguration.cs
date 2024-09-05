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
            builder.Property(e => e.GrupoCorporativoCodigo).HasColumnName("ppr_codgrc");
            builder.Property(e => e.Nombre).HasColumnName("ppr_nombre").HasMaxLength(250).IsUnicode(false);
            builder.Property(e => e.Descripcion).HasColumnName("ppr_descripcion").HasMaxLength(4000).IsUnicode(false);
            builder.Property(e => e.Objetivo).HasColumnName("ppr_objetivo").HasMaxLength(4000).IsUnicode(false);
            builder.Property(e => e.Estado).HasColumnName("ppr_estado").HasMaxLength(10).IsUnicode(false);
            builder.Property(e => e.DuracionEstimada).HasColumnName("ppr_duracion_estimada");
            builder.Property(e => e.UnidadDuracion).HasColumnName("ppr_unidad_duracion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.RawPropertyBagData).HasColumnName("ppr_property_bag_data");
            builder.Property(e => e.UsuarioGrabacion).HasColumnName("ppr_usuario_grabacion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.FechaGrabacion).HasColumnName("ppr_fecha_grabacion");
            builder.Property(e => e.UsuarioUltimaModificacion).HasColumnName("ppr_usuario_modificacion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.FechaUltimaModificacion).HasColumnName("ppr_fecha_modificacion");
        }
    }
}