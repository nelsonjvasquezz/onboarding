using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using onboarding.data.bases;

namespace onboarding.persistence.configurations
{
    public class TipoResponsableActividadConfiguration : IEntityTypeConfiguration<TipoResponsableActividad>
    {
        private readonly string _schema;

        public TipoResponsableActividadConfiguration()
            : this("obd")
        {
        }

        public TipoResponsableActividadConfiguration(string schema)
        {
            _schema = schema;
        }

        public void Configure(EntityTypeBuilder<TipoResponsableActividad> builder)
        {
            builder.ToTable("tra_tipos_respon_actividad", _schema);
            builder.HasKey(e => e.Codigo);

            builder.Property(e => e.Codigo).HasColumnName("tra_codigo");
            builder.Property(e => e.GrupoCorporativoCodigo).HasColumnName("tra_codgrc");
            builder.Property(e => e.Nombre).HasColumnName("tra_nombre").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.Descripcion).HasColumnName("tra_descripcion").HasMaxLength(500).IsUnicode(false);
            builder.Property(e => e.EsParticipante).HasColumnName("tra_es_participante");
            builder.Property(e => e.RequiereEmpleo).HasColumnName("tra_requiere_empleo");
            builder.Property(e => e.EmpleoValueListCodigo).HasColumnName("tra_codvli_empleo");
            builder.Property(e => e.EsInstExterna).HasColumnName("tra_es_inst_externa");
            builder.Property(e => e.ContactoExterno).HasColumnName("tra_contacto_externo").HasMaxLength(250).IsUnicode(false);
            builder.Property(e => e.EsPersonaExterna).HasColumnName("tra_es_persona_externa");
            builder.Property(e => e.EmailExterno).HasColumnName("tra_email_externo").HasMaxLength(100).IsUnicode(false);
            builder.Property(e => e.TelefonoExterno).HasColumnName("tra_telefono_externo").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.RawPropertyBagData).HasColumnName("tra_property_bag_data");
            builder.Property(e => e.UsuarioGrabacion).HasColumnName("tra_usuario_grabacion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.FechaGrabacion).HasColumnName("tra_fecha_grabacion");
            builder.Property(e => e.UsuarioUltimaModificacion).HasColumnName("tra_usuario_modificacion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.FechaUltimaModificacion).HasColumnName("tra_fecha_modificacion");
        }
    }
}