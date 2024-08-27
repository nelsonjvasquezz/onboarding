using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using onboarding.data.bases;

namespace onboarding.persistence.configurations
{
    public class TipoActividadConfiguration : IEntityTypeConfiguration<TipoActividad>
    {
        private readonly string _schema;

        public TipoActividadConfiguration()
            : this("obd")
        {
        }

        public TipoActividadConfiguration(string schema)
        {
            _schema = schema;
        }

        public void Configure(EntityTypeBuilder<TipoActividad> builder)
        {
            builder.ToTable("tac_tipos_actividad", _schema);
            builder.HasKey(e => e.Codigo);

            builder.Property(e => e.Codigo).HasColumnName("tac_codigo");
            builder.Property(e => e.GrupoCorporativoCodigo).HasColumnName("tac_codgrc");
            builder.Property(e => e.Nombre).HasColumnName("tac_nombre").HasMaxLength(100).IsUnicode(false);
            builder.Property(e => e.Descripcion).HasColumnName("tac_descripcion").HasMaxLength(500).IsUnicode(false);
            builder.Property(e => e.RequiereNotificacion).HasColumnName("tac_req_notificacion");
            builder.Property(e => e.RequiereRecordatorio).HasColumnName("tac_req_recordatorio");
            builder.Property(e => e.RequiereEvaluacion).HasColumnName("tac_req_evaluacion");
            builder.Property(e => e.RequiereDocumentos).HasColumnName("tac_req_documentos");
            builder.Property(e => e.RequiereResponsable).HasColumnName("tac_req_responsable");
            builder.Property(e => e.DuracionEstimada).HasColumnName("tac_duracion_estimada");
            builder.Property(e => e.UnidadDuracion).HasColumnName("tac_unidad_duracion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.RawPropertyBagData).HasColumnName("tac_property_bag_data");
            builder.Property(e => e.UsuarioGrabacion).HasColumnName("tac_usuario_grabacion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.FechaGrabacion).HasColumnName("tac_fecha_grabacion");
            builder.Property(e => e.UsuarioModificacion).HasColumnName("tac_usuario_modificacion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.FechaModificacion).HasColumnName("tac_fecha_modificacion");
        }
    }
}