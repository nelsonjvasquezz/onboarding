using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using onboarding.data.bases;

namespace onboarding.persistence.configurations
{
    public class EtapaProgramaConfiguration : IEntityTypeConfiguration<EtapaPrograma>
    {
        private readonly string _schema;

        public EtapaProgramaConfiguration()
            : this("obd")
        {
        }

        public EtapaProgramaConfiguration(string schema)
        {
            _schema = schema;
        }

        public void Configure(EntityTypeBuilder<EtapaPrograma> builder)
        {
            builder.ToTable("etp_etapas_programa", _schema);
            builder.HasKey(e => e.Codigo);

            builder.Property(e => e.Codigo).HasColumnName("etp_codigo");
            builder.Property(e => e.AntesPrimerDia).HasColumnName("etp_antes_primer_dia");
            builder.Property(e => e.GrupoCorporativoCodigo).HasColumnName("etp_codgrc");
            builder.Property(e => e.Descripcion).HasColumnName("etp_descripcion").HasMaxLength(500).IsUnicode(false);
            builder.Property(e => e.AntesPrimerDia).HasColumnName("etp_durante_primer_dia");
            builder.Property(e => e.FechaGrabacion).HasColumnName("etp_fecha_grabacion").HasColumnType("datetime");
            builder.Property(e => e.FechaModificacion).HasColumnName("etp_fecha_modificacion").HasColumnType("datetime");
            builder.Property(e => e.Nombre).HasColumnName("etp_nombre").HasMaxLength(100).IsUnicode(false);
            builder.Property(e => e.Orden).HasColumnName("etp_orden");
            builder.Property(e => e.PeriodoPrueba).HasColumnName("etp_periodo_prueba");
            builder.Property(e => e.PosteriorPrimerDia).HasColumnName("etp_posterior_primer_dia");
            builder.Property(e => e.RawPropertyBagData).HasColumnName("etp_property_bag_data").HasColumnType("xml");
            builder.Property(e => e.UsuarioGrabacion).HasColumnName("etp_usuario_grabacion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.UsuarioModificacion).HasColumnName("etp_usuario_modificacion").HasMaxLength(50).IsUnicode(false);
        }
    }
}