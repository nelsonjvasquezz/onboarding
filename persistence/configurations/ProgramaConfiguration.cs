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
            builder.ToTable("pro_programas", _schema);
            builder.HasKey(e => e.Codigo);

            builder.Property(e => e.Codigo).HasColumnName("pro_codigo");
            builder.Property(e => e.PlantillaProgramaCodigo).HasColumnName("pro_codppr");
            builder.Property(e => e.Nombre).HasColumnName("pro_nombre").HasMaxLength(250).IsUnicode(false);
            builder.Property(e => e.Descripcion).HasColumnName("pro_descripcion").HasMaxLength(4000).IsUnicode(false);
            builder.Property(e => e.Objetivo).HasColumnName("pro_objetivo").HasMaxLength(4000).IsUnicode(false);
            builder.Property(e => e.EstadoDb).HasColumnName("pro_estado").HasMaxLength(15).IsUnicode(false);
            builder.Property(e => e.Duracion).HasColumnName("pro_duracion");
            builder.Property(e => e.UnidadDuracionDb).HasColumnName("pro_unidad_duracion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.RawPropertyBagData).HasColumnName("pro_property_bag_data");
            builder.Property(e => e.UsuarioGrabacion).HasColumnName("pro_usuario_grabacion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.FechaGrabacion).HasColumnName("pro_fecha_grabacion");
            builder.Property(e => e.UsuarioUltimaModificacion).HasColumnName("pro_usuario_modificacion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.FechaUltimaModificacion).HasColumnName("pro_fecha_modificacion");

            // Foreign keys
            builder.HasOne(d => d.Plantilla).WithMany(p => p.Programas).HasForeignKey(d => d.PlantillaProgramaCodigo).OnDelete(DeleteBehavior.NoAction); // FK_obdppr_obdpro
        }
    }
}