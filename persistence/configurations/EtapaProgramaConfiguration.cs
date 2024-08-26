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

            builder.Property(e => e.Codigo).HasColumnName("etp_codigo").HasComment("Código de la etapa del programa");
            builder.Property(e => e.AntesPrimerDia).HasColumnName("etp_antes_primer_dia").HasComment("¿Corresponde con actividades antes del primer día de trabajo?");
            builder.Property(e => e.GrupoCorporativoCodigo).HasColumnName("etp_codgrc").HasComment("Código de grupo corporativo");
            builder.Property(e => e.Descripcion).HasColumnName("etp_descripcion").HasMaxLength(500).IsUnicode(false).HasComment("Descripción de la etapa del programa");
            builder.Property(e => e.AntesPrimerDia).HasColumnName("etp_durante_primer_dia").HasComment("¿Corresponde con actividades durante el primer día de trabajo?");
            builder.Property(e => e.FechaGrabacion).HasColumnName("etp_fecha_grabacion").HasColumnType("datetime").HasComment("Fecha en que se creo el registro");
            builder.Property(e => e.FechaModificacion).HasColumnName("etp_fecha_modificacion").HasColumnType("datetime").HasComment("Fecha de la última modificacion del registro");
            builder.Property(e => e.Nombre).HasColumnName("etp_nombre").HasMaxLength(100).IsUnicode(false).HasComment("Nombre de la etapa del programa");
            builder.Property(e => e.Orden).HasColumnName("etp_orden").HasComment("Orden de esta etapa respecto de las demás");
            builder.Property(e => e.PeriodoPrueba).HasColumnName("etp_periodo_prueba").HasComment("Esta fase está contenida en el período de prueba");
            builder.Property(e => e.PosteriorPrimerDia).HasColumnName("etp_posterior_primer_dia").HasComment("¿Corresponde con actividades posteriores al primer día de trabajo?");
            builder.Property(e => e.RawPropertyBagData).HasColumnName("etp_property_bag_data").HasColumnType("xml").HasComment("Data de los campos adicionales");
            builder.Property(e => e.UsuarioGrabacion).HasColumnName("etp_usuario_grabacion").HasMaxLength(50).IsUnicode(false).HasComment("Usuario que creo el registro");
            builder.Property(e => e.UsuarioModificacion).HasColumnName("etp_usuario_modificacion").HasMaxLength(50).IsUnicode(false).HasComment("Usuario que modificó por última vez el registro");
        }
    }
}