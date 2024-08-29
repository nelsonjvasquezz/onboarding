using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using onboarding.data.bases;

namespace onboarding.persistence.configurations
{
    public class TipoEvaluacionConfiguration : IEntityTypeConfiguration<TipoEvaluacion>
    {
        private readonly string _schema;

        public TipoEvaluacionConfiguration()
            : this("obd")
        {
        }

        public TipoEvaluacionConfiguration(string schema)
        {
            _schema = schema;
        }

        public void Configure(EntityTypeBuilder<TipoEvaluacion> builder)
        {
            builder.ToTable("tev_tipos_evaluacion", _schema);
            builder.HasKey(e => e.Codigo);

            builder.Property(e => e.Codigo).HasColumnName("tev_codigo");
            builder.Property(e => e.GrupoCorporativoCodigo).HasColumnName("tev_codgrc");
            builder.Property(e => e.Nombre).HasColumnName("tev_nombre").HasMaxLength(100).IsUnicode(false);
            builder.Property(e => e.Descripcion).HasColumnName("tev_descripcion").HasMaxLength(500).IsUnicode(false);
            builder.Property(e => e.UtilizaFormularioDinamico).HasColumnName("tev_utiliza_fdi");
            builder.Property(e => e.FormularioDinamicoCodigo).HasColumnName("tev_codfdi_evaluacion");
            builder.Property(e => e.RawPropertyBagData).HasColumnName("tev_property_bag_data");
            builder.Property(e => e.UsuarioGrabacion).HasColumnName("tev_usuario_grabacion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.FechaGrabacion).HasColumnName("tev_fecha_grabacion");
            builder.Property(e => e.UsuarioUltimaModificacion).HasColumnName("tev_usuario_modificacion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.FechaUltimaModificacion).HasColumnName("tev_fecha_modificacion");
        }
    }
}