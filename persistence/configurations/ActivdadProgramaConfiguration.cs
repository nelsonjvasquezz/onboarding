using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using onboarding.data.bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onboarding.persistence.configurations
{
    internal class ActivdadProgramaConfiguration
    {
        public void Configure(ModelBuilder builder)
        {
            builder.Entity<ActividadPrograma>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("acp_actividades_programa", "obd");

                entity.Property(e => e.Codigo)
                    .HasComment("Código de registro de la actividad de la plantilla para programa de onboarding")
                    .HasColumnName("acp_codigo");
                entity.Property(e => e.ContratacionProgramaCodigo)
                    .HasComment("Código de la plantilla de programa de onboarding")
                    .HasColumnName("acp_codcpr");
                entity.Property(e => e.EmpleoResponsableCodigo)
                    .HasComment("Código de empleo responsable de la evaluación")
                    .HasColumnName("acp_codemp_responsable");
                entity.Property(e => e.EtapaProgramaCodigo)
                    .HasComment("Código de Etapa o Fase del programa")
                    .HasColumnName("acp_codetp");
                entity.Property(e => e.FormularioDinamicoDataCodigo)
                    .HasComment("Código de la data del formulario dinámico (cuando está definido según el tipo de evaluación)")
                    .HasColumnName("acp_codfdd");
                entity.Property(e => e.PrioridadActividadCodigo)
                    .HasComment("Código de Prioridad de la actividad")
                    .HasColumnName("acp_codpri");
                entity.Property(e => e.TipoActividadCodigo)
                    .HasComment("Código de Tipo de Actividad")
                    .HasColumnName("acp_codtac");
                entity.Property(e => e.TipoEvaluacionCodigo)
                    .HasComment("Codigo de Tipo de Evaluación de la activdidad (NULL cuando no requiere evaluación)")
                    .HasColumnName("acp_codtev");
                entity.Property(e => e.TipoResponsableActividadCodigo)
                    .HasComment("Código de Tipo de Responsable de la actividad")
                    .HasColumnName("acp_codtra");
                entity.Property(e => e.ComentarioFinalizacion)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasComment("Comentarios de evaluador o quien finaliza la actividad")
                    .HasColumnName("acp_comentario_finalizacion");
                entity.Property(e => e.Descripcion)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasComment("Descripción de la actividad")
                    .HasColumnName("acp_descripcion");
                entity.Property(e => e.Duracion)
                    .HasComment("Duración de la actividad")
                    .HasColumnName("acp_duracion");
                entity.Property(e => e.Estado)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValue("Pendiente")
                    .HasComment("Estado de la actividad (Pendiente, En Proceso, Finalizada)")
                    .HasColumnName("acp_estado");
                entity.Property(e => e.FechaEvaluacion)
                    .HasComment("Fecha de evaluación de la actividad")
                    .HasColumnType("datetime")
                    .HasColumnName("acp_fecha_evaluacion");
                entity.Property(e => e.FechaFin)
                    .HasComment("Fecha calculada de infalización de la actividad")
                    .HasColumnType("datetime")
                    .HasColumnName("acp_fecha_fin");
                entity.Property(e => e.FechaFinalizacion)
                    .HasComment("Fecha de finalización de la actividad (fecha en el estado cambio a finalizada)")
                    .HasColumnType("datetime")
                    .HasColumnName("acp_fecha_finalizacion");
                entity.Property(e => e.FechaGrabacion)
                    .HasComment("Fecha en que se creo el registro")
                    .HasColumnType("datetime")
                    .HasColumnName("acp_fecha_grabacion");
                entity.Property(e => e.FechaInicio)
                    .HasComment("Fecha calculada de inicio de la actividad")
                    .HasColumnType("datetime")
                    .HasColumnName("acp_fecha_inicio");
                entity.Property(e => e.FechaModificacion)
                    .HasComment("Fecha de la última modificacion del registro")
                    .HasColumnType("datetime")
                    .HasColumnName("acp_fecha_modificacion");
                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("Nombre de la actividad")
                    .HasColumnName("acp_nombre");
                entity.Property(e => e.NotaEvaluacion)
                    .HasComment("Nota de la evaluación dada por el responsable de la actividad")
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("acp_nota_evaluacion");
                entity.Property(e => e.Objetivo)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasComment("Objetivo de la actividad")
                    .HasColumnName("acp_objetivo");
                entity.Property(e => e.Orden)
                    .HasComment("Orden de esta actividad respecto de las mismas que tienen los mismos prerequisitos")
                    .HasColumnName("acp_orden");
                entity.Property(e => e.RawPropertyBagData)
                    .HasComment("Data de los campos adicionales")
                    .HasColumnType("xml")
                    .HasColumnName("acp_property_bag_data");
                entity.Property(e => e.ResultadoEvaluacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Determina si la evaluación fue aprobada o no")
                    .HasColumnName("acp_resultado_evaluacion");
                entity.Property(e => e.UnidadDuracion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValue("Días")
                    .HasComment("Unidad de medida de la duración de la actividad")
                    .HasColumnName("acp_unidad_duracion");
                entity.Property(e => e.UsuarioGrabacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Usuario que creo el registro")
                    .HasColumnName("acp_usuario_grabacion");
                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Usuario que modificó por última vez el registro")
                    .HasColumnName("acp_usuario_modificacion");

                entity.HasOne(d => d.ContratacionPrograma).WithMany(p => p.ActividadesProgramas)
                    .HasForeignKey(d => d.ContratacionProgramaCodigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_obdcpr_obdacp");

                entity.HasOne(d => d.EtapaPrograma).WithMany(p => p.ActividadesProgramas)
                    .HasForeignKey(d => d.EtapaProgramaCodigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_obdetp_obdacp");

                entity.HasOne(d => d.PrioridadActividad).WithMany(p => p.ActividadesProgramas)
                    .HasForeignKey(d => d.PrioridadActividadCodigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_obdpri_obdacp");

                entity.HasOne(d => d.TipoActividad).WithMany(p => p.ActividadesProgramas)
                    .HasForeignKey(d => d.TipoActividadCodigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_obdtac_obdacp");

                entity.HasOne(d => d.TipoEvaluacion).WithMany(p => p.ActividadesProgramas)
                    .HasForeignKey(d => d.TipoEvaluacionCodigo)
                    .HasConstraintName("FK_obdte_obdacp");

                entity.HasOne(d => d.TipoResponsableActividad).WithMany(p => p.ActividadesProgramas)
                    .HasForeignKey(d => d.TipoResponsableActividadCodigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_obdtra_obdacp");

                entity.HasMany(d => d.RapCodacpPrerequisitos).WithMany(p => p.RapCodpacs)
                    .UsingEntity<Dictionary<string, object>>(
                        "RapReqActividadesPrograma",
                        r => r.HasOne<ActividadPrograma>().WithMany()
                            .HasForeignKey("RapCodacpPrerequisito")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("FK_obdacp_obdrap_prerequisito"),
                        l => l.HasOne<ActividadPrograma>().WithMany()
                            .HasForeignKey("RapCodpac")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("FK_obdacp_obdrpa"),
                        j =>
                        {
                            j.HasKey("RapCodpac", "RapCodacpPrerequisito");
                            j.ToTable("rap_req_actividades_programa", "obd", tb => tb.HasComment("Tabla que almacena la lista de actividades prerequisito de una actividad para el programa de onboarding"));
                            j.IndexerProperty<int>("RapCodpac")
                                .HasComment("Código de Actividad en el programa de onboarding")
                                .HasColumnName("rap_codpac");
                            j.IndexerProperty<int>("RapCodacpPrerequisito")
                                .HasComment("Código de Actividad que es prerequisito")
                                .HasColumnName("rap_codacp_prerequisito");
                        });

                entity.HasMany(d => d.RapCodpacs).WithMany(p => p.RapCodacpPrerequisitos)
                    .UsingEntity<Dictionary<string, object>>(
                        "RapReqActividadesPrograma",
                        r => r.HasOne<ActividadPrograma>().WithMany()
                            .HasForeignKey("RapCodpac")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("FK_obdacp_obdrpa"),
                        l => l.HasOne<ActividadPrograma>().WithMany()
                            .HasForeignKey("RapCodacpPrerequisito")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("FK_obdacp_obdrap_prerequisito"),
                        j =>
                        {
                            j.HasKey("RapCodpac", "RapCodacpPrerequisito");
                            j.ToTable("rap_req_actividades_programa", "obd", tb => tb.HasComment("Tabla que almacena la lista de actividades prerequisito de una actividad para el programa de onboarding"));
                            j.IndexerProperty<int>("RapCodpac")
                                .HasComment("Código de Actividad en el programa de onboarding")
                                .HasColumnName("rap_codpac");
                            j.IndexerProperty<int>("RapCodacpPrerequisito")
                                .HasComment("Código de Actividad que es prerequisito")
                                .HasColumnName("rap_codacp_prerequisito");
                        });
            });
        }
    }
}
