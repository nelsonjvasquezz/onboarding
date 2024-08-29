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
            builder.Property(e => e.PlantillaProgramaCodigo).HasColumnName("pac_codppr");
            builder.Property(e => e.Nombre).HasColumnName("pac_nombre").HasMaxLength(250).IsUnicode(false);
            builder.Property(e => e.Descripcion).HasColumnName("pac_descripcion").HasMaxLength(4000).IsUnicode(false);
            builder.Property(e => e.Objetivo).HasColumnName("pac_objetivo").HasMaxLength(4000).IsUnicode(false);
            builder.Property(e => e.EtapaProgramaCodigo).HasColumnName("pac_codetp");
            builder.Property(e => e.TipoActividadCodigo).HasColumnName("pac_codtac");
            builder.Property(e => e.OffsetInicio).HasColumnName("pac_offset_inicio");
            builder.Property(e => e.UnidadOffsetInicio).HasColumnName("pac_unidad_offset_inicio").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.DuracionEstimada).HasColumnName("pac_duracion_estimada");
            builder.Property(e => e.UnidadDuracion).HasColumnName("pac_unidad_duracion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.PrioridadActividadCodigo).HasColumnName("pac_codpri");
            builder.Property(e => e.Orden).HasColumnName("pac_orden");
            builder.Property(e => e.TipoResponsableActividadCodigo).HasColumnName("pac_codtra");
            builder.Property(e => e.TipoEvaluacionCodigo).HasColumnName("pac_codtev");
            builder.Property(e => e.NotaEvalEsperada).HasColumnName("pac_nota_eval_esperada").HasPrecision(19, 4);
            builder.Property(e => e.RawPropertyBagData).HasColumnName("pac_property_bag_data");
            builder.Property(e => e.UsuarioGrabacion).HasColumnName("pac_usuario_grabacion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.FechaGrabacion).HasColumnName("pac_fecha_grabacion");
            builder.Property(e => e.UsuarioUltimaModificacion).HasColumnName("pac_usuario_modificacion").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.FechaUltimaModificacion).HasColumnName("pac_fecha_modificacion");

            builder.HasOne(d => d.EtapaPrograma).WithMany(p => p.PlantillasDeActividades).HasForeignKey(d => d.EtapaProgramaCodigo).OnDelete(DeleteBehavior.NoAction); // FK_obdetp_obdpac
            builder.HasOne(d => d.PlantillaPrograma).WithMany(p => p.PlantillasDeActividades).HasForeignKey(d => d.PlantillaProgramaCodigo).OnDelete(DeleteBehavior.NoAction); // FK_obdppr_obdpac
            builder.HasOne(d => d.PrioridadActividad).WithMany(p => p.PlantillasDeActividades).HasForeignKey(d => d.PrioridadActividadCodigo).OnDelete(DeleteBehavior.NoAction); // FK_obdpri_obdpac
            builder.HasOne(d => d.TipoActividad).WithMany(p => p.PlantillasDeActividades).HasForeignKey(d => d.TipoActividadCodigo).OnDelete(DeleteBehavior.NoAction); // FK_obdtac_obdpac
            builder.HasOne(d => d.TipoEvaluacion).WithMany(p => p.PlantillasDeActividades).HasForeignKey(d => d.TipoEvaluacionCodigo).OnDelete(DeleteBehavior.NoAction); // FK_obdtev_obdpac
            builder.HasOne(d => d.TipoResponsableActividad).WithMany(p => p.PlantillasDeActividades).HasForeignKey(d => d.TipoResponsableActividadCodigo).OnDelete(DeleteBehavior.NoAction); // FK_obdtra_obdpac
        }
    }
}