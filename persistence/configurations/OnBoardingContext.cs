using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using onboarding.data;
using onboarding.data.bases;

namespace onboarding.persistence.configurations;

public partial class OnBoardingContext : DbContext
{
    public OnBoardingContext()
    {
    }

    public OnBoardingContext(DbContextOptions<OnBoardingContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Initial Catalog=vh4Db;Encrypt=False;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Latin1_General_CI_AS");



        modelBuilder.Entity<CprContratacionesPrograma>(entity =>
        {
            entity.HasKey(e => e.CprCodigo);

            entity.ToTable("cpr_contrataciones_programa", "obd", tb => tb.HasComment("Tabla con el detalle de nuevas contrataciones que participan de un programa de onboarding"));

            entity.Property(e => e.CprCodigo)
                .HasComment("Código de registro de contratación de cada programa")
                .HasColumnName("cpr_codigo");
            entity.Property(e => e.CprCodcdt)
                .HasComment("Código del centro de trabajo donde será ubicado el nuevo empleado")
                .HasColumnName("cpr_codcdt");
            entity.Property(e => e.CprCodemp)
                .HasComment("Código de empleo, cuando la nueva contratación ya se realizó")
                .HasColumnName("cpr_codemp");
            entity.Property(e => e.CprCodempJefe)
                .HasComment("Código del empleo del jefe inmeditato superior o supervisor responsable de la nueva contratación")
                .HasColumnName("cpr_codemp_jefe");
            entity.Property(e => e.CprCodempRespRrhh)
                .HasComment("Código del responsable en RRHH de la nueva contratación")
                .HasColumnName("cpr_codemp_resp_rrhh");
            entity.Property(e => e.CprCodexp)
                .HasComment("Código de expediente de la nueva contratación")
                .HasColumnName("cpr_codexp");
            entity.Property(e => e.CprCodpro)
                .HasComment("Código del programa de onboarding")
                .HasColumnName("cpr_codpro");
            entity.Property(e => e.CprCodpue)
                .HasComment("Código del puesto a donde será contratado el nuevo empleado")
                .HasColumnName("cpr_codpue");
            entity.Property(e => e.CprCoduni)
                .HasComment("Código de la unidad organizativa donde será ubicado el nuevo empleado")
                .HasColumnName("cpr_coduni");
            entity.Property(e => e.CprFechaContratacion)
                .HasComment("Fecha efectiva de contratación")
                .HasColumnType("datetime")
                .HasColumnName("cpr_fecha_contratacion");
            entity.Property(e => e.CprFechaFin)
                .HasComment("Fecha esperada de finalización del programa")
                .HasColumnType("datetime")
                .HasColumnName("cpr_fecha_fin");
            entity.Property(e => e.CprFechaGrabacion)
                .HasComment("Fecha en que se creo el registro")
                .HasColumnType("datetime")
                .HasColumnName("cpr_fecha_grabacion");
            entity.Property(e => e.CprFechaInicio)
                .HasComment("Fecha esperada de inicio del programa")
                .HasColumnType("datetime")
                .HasColumnName("cpr_fecha_inicio");
            entity.Property(e => e.CprFechaModificacion)
                .HasComment("Fecha de la última modificacion del registro")
                .HasColumnType("datetime")
                .HasColumnName("cpr_fecha_modificacion");
            entity.Property(e => e.CprPropertyBagData)
                .HasComment("Data de los campos adicionales")
                .HasColumnType("xml")
                .HasColumnName("cpr_property_bag_data");
            entity.Property(e => e.CprUsuarioGrabacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Usuario que creo el registro")
                .HasColumnName("cpr_usuario_grabacion");
            entity.Property(e => e.CprUsuarioModificacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Usuario que modificó por última vez el registro")
                .HasColumnName("cpr_usuario_modificacion");

            entity.HasOne(d => d.CprCodproNavigation).WithMany(p => p.CprContratacionesProgramas)
                .HasForeignKey(d => d.CprCodpro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_obdpro_obdcpr");
        });

        modelBuilder.Entity<EnoEventosNotificable>(entity =>
        {
            entity.HasKey(e => e.EnoCodigo);

            entity.ToTable("eno_eventos_notificables", "obd", tb => tb.HasComment("Tabla que almacena los evento que son notificables para el seguimiento de los programas de onboarding"));

            entity.Property(e => e.EnoCodigo)
                .HasComment("Código de evento notificable")
                .HasColumnName("eno_codigo");
            entity.Property(e => e.EnoCodgrc)
                .HasComment("Código de Grupo Corporativo")
                .HasColumnName("eno_codgrc");
            entity.Property(e => e.EnoDescripcion)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("Descripción del Evento que se puede notificar")
                .HasColumnName("eno_descripcion");
            entity.Property(e => e.EnoFechaGrabacion)
                .HasComment("Fecha en que se creo el registro")
                .HasColumnType("datetime")
                .HasColumnName("eno_fecha_grabacion");
            entity.Property(e => e.EnoFechaModificacion)
                .HasComment("Fecha de la última modificacion del registro")
                .HasColumnType("datetime")
                .HasColumnName("eno_fecha_modificacion");
            entity.Property(e => e.EnoNombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("Nombre del Evento")
                .HasColumnName("eno_nombre");
            entity.Property(e => e.EnoPropertyBagData)
                .HasComment("Data de los campos adicionales")
                .HasColumnType("xml")
                .HasColumnName("eno_property_bag_data");
            entity.Property(e => e.EnoUsuarioGrabacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Usuario que creo el registro")
                .HasColumnName("eno_usuario_grabacion");
            entity.Property(e => e.EnoUsuarioModificacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Usuario que modificó por última vez el registro")
                .HasColumnName("eno_usuario_modificacion");
        });

        modelBuilder.Entity<EtpEtapasPrograma>(entity =>
        {
            entity.HasKey(e => e.EtpCodigo);

            entity.ToTable("etp_etapas_programa", "obd", tb => tb.HasComment("Tabla con las fases o etapas de los programas de Oboarding"));

            entity.Property(e => e.EtpCodigo)
                .HasComment("Código de la etapa del programa")
                .HasColumnName("etp_codigo");
            entity.Property(e => e.EtpAntesPrimerDia)
                .HasComment("¿Corresponde con actividades antes del primer día de trabajo?")
                .HasColumnName("etp_antes_primer_dia");
            entity.Property(e => e.EtpCodgrc)
                .HasComment("Código de grupo corporativo")
                .HasColumnName("etp_codgrc");
            entity.Property(e => e.EtpDescripcion)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("Descripción de la etapa del programa")
                .HasColumnName("etp_descripcion");
            entity.Property(e => e.EtpDurantePrimerDia)
                .HasComment("¿Corresponde con actividades durante el primer día de trabajo?")
                .HasColumnName("etp_durante_primer_dia");
            entity.Property(e => e.EtpFechaGrabacion)
                .HasComment("Fecha en que se creo el registro")
                .HasColumnType("datetime")
                .HasColumnName("etp_fecha_grabacion");
            entity.Property(e => e.EtpFechaModificacion)
                .HasComment("Fecha de la última modificacion del registro")
                .HasColumnType("datetime")
                .HasColumnName("etp_fecha_modificacion");
            entity.Property(e => e.EtpNombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("Nombre de la etapa del programa")
                .HasColumnName("etp_nombre");
            entity.Property(e => e.EtpOrden)
                .HasComment("Orden de esta etapa respecto de las demás")
                .HasColumnName("etp_orden");
            entity.Property(e => e.EtpPeriodoPrueba)
                .HasComment("Esta fase está contenida en el período de prueba")
                .HasColumnName("etp_periodo_prueba");
            entity.Property(e => e.EtpPosteriorPrimerDia)
                .HasComment("¿Corresponde con actividades posteriores al primer día de trabajo?")
                .HasColumnName("etp_posterior_primer_dia");
            entity.Property(e => e.EtpPropertyBagData)
                .HasComment("Data de los campos adicionales")
                .HasColumnType("xml")
                .HasColumnName("etp_property_bag_data");
            entity.Property(e => e.EtpUsuarioGrabacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Usuario que creo el registro")
                .HasColumnName("etp_usuario_grabacion");
            entity.Property(e => e.EtpUsuarioModificacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Usuario que modificó por última vez el registro")
                .HasColumnName("etp_usuario_modificacion");
        });

        modelBuilder.Entity<NapNotifActividadPrograma>(entity =>
        {
            entity.HasKey(e => e.NapCodigo);

            entity.ToTable("nap_notif_actividad_programa", "obd");

            entity.Property(e => e.NapCodigo)
                .HasComment("Código de registro de la configuración de notificaciones de la actividad del programa")
                .HasColumnName("nap_codigo");
            entity.Property(e => e.NapBody)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasComment("Cuerpo Markdown de la notificación")
                .HasColumnName("nap_body");
            entity.Property(e => e.NapCodacp)
                .HasComment("Código de la Actividad")
                .HasColumnName("nap_codacp");
            entity.Property(e => e.NapCodeno)
                .HasComment("Tipo de Evento Notificable")
                .HasColumnName("nap_codeno");
            entity.Property(e => e.NapEstado)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("Estado de la notificación (NULL | 'Pendiente' | 'Enviada' | 'Error')")
                .HasColumnName("nap_estado");
            entity.Property(e => e.NapFechaEvento)
                .HasComment("Fecha en que sucedió el evento notificable (está null mientras no se ha dado)")
                .HasColumnType("datetime")
                .HasColumnName("nap_fecha_evento");
            entity.Property(e => e.NapFechaNotificacion)
                .HasComment("Fecha y hora de cuando se notificó")
                .HasColumnType("datetime")
                .HasColumnName("nap_fecha_notificacion");
            entity.Property(e => e.NapMensajeError)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasComment("Mensaje o excepción cuando el estado es 'Error'")
                .HasColumnName("nap_mensaje_error");
            entity.Property(e => e.NapOffsetDias)
                .HasComment("Desplazamiento en días de la fecha en que ocurre el evento para el envio de la notificación")
                .HasColumnName("nap_offset_dias");
            entity.Property(e => e.NapSubject)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("Asunto de la notificación")
                .HasColumnName("nap_subject");
            entity.Property(e => e.NapTipoDestinatario)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue("Contratado")
                .HasComment("Destinatario de la notificación: Contratado | JefeInmediato | ResponsableActividad | ResponsableRRHH")
                .HasColumnName("nap_tipo_destinatario");

            entity.HasOne(d => d.NapCodacpNavigation).WithMany(p => p.NapNotifActividadProgramas)
                .HasForeignKey(d => d.NapCodacp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_obdacp_obdnap");

            entity.HasOne(d => d.NapCodenoNavigation).WithMany(p => p.NapNotifActividadProgramas)
                .HasForeignKey(d => d.NapCodeno)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_obdeno_obdnap");
        });

        modelBuilder.Entity<PacPlantActividade>(entity =>
        {
            entity.HasKey(e => e.PacCodigo);

            entity.ToTable("pac_plant_actividades", "obd", tb => tb.HasComment("Tabla que almacena las actividades de la plantilla del programa de onboarding"));

            entity.Property(e => e.PacCodigo)
                .HasComment("Código de registro de la actividad de la plantilla para programa de onboarding")
                .HasColumnName("pac_codigo");
            entity.Property(e => e.PacCodetp)
                .HasComment("Código de Etapa o Fase del programa")
                .HasColumnName("pac_codetp");
            entity.Property(e => e.PacCodppr)
                .HasComment("Código de la plantilla de programa de onboarding")
                .HasColumnName("pac_codppr");
            entity.Property(e => e.PacCodpri)
                .HasComment("Código de Prioridad de la actividad")
                .HasColumnName("pac_codpri");
            entity.Property(e => e.PacCodtac)
                .HasComment("Código de Tipo de Actividad")
                .HasColumnName("pac_codtac");
            entity.Property(e => e.PacCodtev)
                .HasComment("Codigo de Tipo de Evaluación de la activdidad")
                .HasColumnName("pac_codtev");
            entity.Property(e => e.PacCodtra)
                .HasComment("Código de Tipo de Responsable de la actividad")
                .HasColumnName("pac_codtra");
            entity.Property(e => e.PacDescripcion)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasComment("Descripción de la actividad")
                .HasColumnName("pac_descripcion");
            entity.Property(e => e.PacDuracionEstimada)
                .HasComment("Duración estimada de la actividad")
                .HasColumnName("pac_duracion_estimada");
            entity.Property(e => e.PacFechaGrabacion)
                .HasComment("Fecha en que se creo el registro")
                .HasColumnType("datetime")
                .HasColumnName("pac_fecha_grabacion");
            entity.Property(e => e.PacFechaModificacion)
                .HasComment("Fecha de la última modificacion del registro")
                .HasColumnType("datetime")
                .HasColumnName("pac_fecha_modificacion");
            entity.Property(e => e.PacNombre)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("Nombre de la actividad")
                .HasColumnName("pac_nombre");
            entity.Property(e => e.PacNotaEvalEsperada)
                .HasComment("Nota de evaluación esperada para determinar si aprobo o no la evaluación")
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("pac_nota_eval_esperada");
            entity.Property(e => e.PacObjetivo)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasComment("Objetivo de la actividad")
                .HasColumnName("pac_objetivo");
            entity.Property(e => e.PacOffsetInicio)
                .HasComment("Desplazamiento de tiempo antes o despues de la contratación para determinar la fecha de inicio de la actividad")
                .HasColumnName("pac_offset_inicio");
            entity.Property(e => e.PacOrden)
                .HasComment("Orden de esta actividad respecto de las mismas que tienen los mismos prerequisitos")
                .HasColumnName("pac_orden");
            entity.Property(e => e.PacPropertyBagData)
                .HasComment("Data de los campos adicionales")
                .HasColumnType("xml")
                .HasColumnName("pac_property_bag_data");
            entity.Property(e => e.PacUnidadDuracion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("Días")
                .HasComment("Unidad de medida de la duracióon estimada de la actividad")
                .HasColumnName("pac_unidad_duracion");
            entity.Property(e => e.PacUnidadOffsetInicio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("Días")
                .HasComment("Unidad de medida del desplazamiento")
                .HasColumnName("pac_unidad_offset_inicio");
            entity.Property(e => e.PacUsuarioGrabacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Usuario que creo el registro")
                .HasColumnName("pac_usuario_grabacion");
            entity.Property(e => e.PacUsuarioModificacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Usuario que modificó por última vez el registro")
                .HasColumnName("pac_usuario_modificacion");

            entity.HasOne(d => d.PacCodetpNavigation).WithMany(p => p.PacPlantActividades)
                .HasForeignKey(d => d.PacCodetp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_obdetp_obdpac");

            entity.HasOne(d => d.PacCodpprNavigation).WithMany(p => p.PacPlantActividades)
                .HasForeignKey(d => d.PacCodppr)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_obdppr_obdpac");

            entity.HasOne(d => d.PacCodpriNavigation).WithMany(p => p.PacPlantActividades)
                .HasForeignKey(d => d.PacCodpri)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_obdpri_obdpac");

            entity.HasOne(d => d.PacCodtacNavigation).WithMany(p => p.PacPlantActividades)
                .HasForeignKey(d => d.PacCodtac)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_obdtac_obdpac");

            entity.HasOne(d => d.PacCodtevNavigation).WithMany(p => p.PacPlantActividades)
                .HasForeignKey(d => d.PacCodtev)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_obdtev_obdpac");

            entity.HasOne(d => d.PacCodtraNavigation).WithMany(p => p.PacPlantActividades)
                .HasForeignKey(d => d.PacCodtra)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_obdtra_obdpac");

            entity.HasMany(d => d.PpaCodpacPrerequisitos).WithMany(p => p.PpaCodpacs)
                .UsingEntity<Dictionary<string, object>>(
                    "PpaPlantPrerequisitosAct",
                    r => r.HasOne<PacPlantActividade>().WithMany()
                        .HasForeignKey("PpaCodpacPrerequisito")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_obdpac_obdppa_prerequisito"),
                    l => l.HasOne<PacPlantActividade>().WithMany()
                        .HasForeignKey("PpaCodpac")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_obdpac_obdppa"),
                    j =>
                    {
                        j.HasKey("PpaCodpac", "PpaCodpacPrerequisito");
                        j.ToTable("ppa_plant_prerequisitos_act", "obd", tb => tb.HasComment("Tabla que almacena la lista de actividades prerequisito de una actividad de la plantilla"));
                        j.IndexerProperty<int>("PpaCodpac")
                            .HasComment("Código de Actividad en la plantilla del programa de onboarding")
                            .HasColumnName("ppa_codpac");
                        j.IndexerProperty<int>("PpaCodpacPrerequisito")
                            .HasComment("Código de Actividad que es prerequisito")
                            .HasColumnName("ppa_codpac_prerequisito");
                    });

            entity.HasMany(d => d.PpaCodpacs).WithMany(p => p.PpaCodpacPrerequisitos)
                .UsingEntity<Dictionary<string, object>>(
                    "PpaPlantPrerequisitosAct",
                    r => r.HasOne<PacPlantActividade>().WithMany()
                        .HasForeignKey("PpaCodpac")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_obdpac_obdppa"),
                    l => l.HasOne<PacPlantActividade>().WithMany()
                        .HasForeignKey("PpaCodpacPrerequisito")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_obdpac_obdppa_prerequisito"),
                    j =>
                    {
                        j.HasKey("PpaCodpac", "PpaCodpacPrerequisito");
                        j.ToTable("ppa_plant_prerequisitos_act", "obd", tb => tb.HasComment("Tabla que almacena la lista de actividades prerequisito de una actividad de la plantilla"));
                        j.IndexerProperty<int>("PpaCodpac")
                            .HasComment("Código de Actividad en la plantilla del programa de onboarding")
                            .HasColumnName("ppa_codpac");
                        j.IndexerProperty<int>("PpaCodpacPrerequisito")
                            .HasComment("Código de Actividad que es prerequisito")
                            .HasColumnName("ppa_codpac_prerequisito");
                    });
        });

        modelBuilder.Entity<PalPlantAlcance>(entity =>
        {
            entity.HasKey(e => e.PalCodigo);

            entity.ToTable("pal_plant_alcances", "obd");

            entity.Property(e => e.PalCodigo)
                .HasComment("Código de registro de alcance para la plantilla de programa de onboarding")
                .HasColumnName("pal_codigo");
            entity.Property(e => e.PalCodppr)
                .HasComment("Código de plantilla de programa de onboarding")
                .HasColumnName("pal_codppr");
            entity.Property(e => e.PalCodpue)
                .HasComment("Código de Puesto")
                .HasColumnName("pal_codpue");
            entity.Property(e => e.PalCodtpp)
                .HasComment("Código de Tipo de Puesto")
                .HasColumnName("pal_codtpp");
            entity.Property(e => e.PalFechaGrabacion)
                .HasComment("Fecha en que se creo el registro")
                .HasColumnType("datetime")
                .HasColumnName("pal_fecha_grabacion");
            entity.Property(e => e.PalFechaModificacion)
                .HasComment("Fecha de la última modificacion del registro")
                .HasColumnType("datetime")
                .HasColumnName("pal_fecha_modificacion");
            entity.Property(e => e.PalPropertyBagData)
                .HasComment("Data de los campos adicionales")
                .HasColumnType("xml")
                .HasColumnName("pal_property_bag_data");
            entity.Property(e => e.PalTipo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComputedColumnSql("(case when NOT [pal_codtpp] IS NULL then 'TipoPuesto' when NOT [pal_codpue] IS NULL then 'Puesto' else 'Default' end)", false)
                .HasComment("Tipo de Alcance")
                .HasColumnName("pal_tipo");
            entity.Property(e => e.PalUsuarioGrabacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Usuario que creo el registro")
                .HasColumnName("pal_usuario_grabacion");
            entity.Property(e => e.PalUsuarioModificacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Usuario que modificó por última vez el registro")
                .HasColumnName("pal_usuario_modificacion");

            entity.HasOne(d => d.PalCodpprNavigation).WithMany(p => p.PalPlantAlcances)
                .HasForeignKey(d => d.PalCodppr)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_obdppr_obdpap");
        });

        modelBuilder.Entity<PnaPlantNotificacionAct>(entity =>
        {
            entity.HasKey(e => e.PnaCodigo);

            entity.ToTable("pna_plant_notificacion_act", "obd");

            entity.Property(e => e.PnaCodigo)
                .HasComment("Código de registro de notificaciones de la actividad de la plantilla")
                .HasColumnName("pna_codigo");
            entity.Property(e => e.PnaBody)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasComment("Cuerpo Markdown de la notificación")
                .HasColumnName("pna_body");
            entity.Property(e => e.PnaCodpac)
                .HasComment("Código de Actividad de la plantilla de programas de onboarding")
                .HasColumnName("pna_codpac");
            entity.Property(e => e.PnaEnviaContratado)
                .HasDefaultValue(true)
                .HasComment("Determina si la notificación se envía al empleado contratado")
                .HasColumnName("pna_envia_contratado");
            entity.Property(e => e.PnaEnviaJefe)
                .HasDefaultValue(true)
                .HasComment("Determina si la notificación se envía al jefe inmediato superior del empleado")
                .HasColumnName("pna_envia_jefe");
            entity.Property(e => e.PnaEnviaResponsable)
                .HasDefaultValue(true)
                .HasComment("Determina si la notificación se envía al responsable de la actividad")
                .HasColumnName("pna_envia_responsable");
            entity.Property(e => e.PnaFechaGrabacion)
                .HasComment("Fecha en que se creo el registro")
                .HasColumnType("datetime")
                .HasColumnName("pna_fecha_grabacion");
            entity.Property(e => e.PnaFechaModificacion)
                .HasComment("Fecha de la última modificacion del registro")
                .HasColumnType("datetime")
                .HasColumnName("pna_fecha_modificacion");
            entity.Property(e => e.PnaOffsetFin)
                .HasComment("Desplamiento en dias antes o despues de la fecha de finalizacion")
                .HasColumnName("pna_offset_fin");
            entity.Property(e => e.PnaOffsetInicio)
                .HasComment("Desplamiento en dias antes o despues de la fecha de inicio ")
                .HasColumnName("pna_offset_inicio");
            entity.Property(e => e.PnaPropertyBagData)
                .HasComment("Data de los campos adicionales")
                .HasColumnType("xml")
                .HasColumnName("pna_property_bag_data");
            entity.Property(e => e.PnaSubject)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("Asunto de la notificación")
                .HasColumnName("pna_subject");
            entity.Property(e => e.PnaUsaFechaInicio)
                .HasComment("Determina cual desplazamiento utiliza, si el de fecha inicio o fecha fin")
                .HasColumnName("pna_usa_fecha_inicio");
            entity.Property(e => e.PnaUsuarioGrabacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Usuario que creo el registro")
                .HasColumnName("pna_usuario_grabacion");
            entity.Property(e => e.PnaUsuarioModificacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Usuario que modificó por última vez el registro")
                .HasColumnName("pna_usuario_modificacion");

            entity.HasOne(d => d.PnaCodpacNavigation).WithMany(p => p.PnaPlantNotificacionActs)
                .HasForeignKey(d => d.PnaCodpac)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_obdpna_obdpna");
        });

        modelBuilder.Entity<PprPlantPrograma>(entity =>
        {
            entity.HasKey(e => e.PprCodigo);

            entity.ToTable("ppr_plant_programa", "obd", tb => tb.HasComment("Tabla que almacena la plantilla para los programas de onboarding"));

            entity.Property(e => e.PprCodigo)
                .HasComment("Código de plantilla de programa de onboarding")
                .HasColumnName("ppr_codigo");
            entity.Property(e => e.PprCodgrc)
                .HasComment("Código de Grupo Corporativo")
                .HasColumnName("ppr_codgrc");
            entity.Property(e => e.PprDescripcion)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasComment("Descripción del programa de onboarding")
                .HasColumnName("ppr_descripcion");
            entity.Property(e => e.PprDuracionEstimada)
                .HasComment("Duración estimada del programa")
                .HasColumnName("ppr_duracion_estimada");
            entity.Property(e => e.PprEstado)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("Activo")
                .HasComment("Estado de la plantilla 'Activa' o 'Inactiva'  (inactivas para fines de guardar históricos y que no aparezcan en la selección)")
                .HasColumnName("ppr_estado");
            entity.Property(e => e.PprFechaGrabacion)
                .HasComment("Fecha en que se creo el registro")
                .HasColumnType("datetime")
                .HasColumnName("ppr_fecha_grabacion");
            entity.Property(e => e.PprFechaModificacion)
                .HasComment("Fecha de la última modificacion del registro")
                .HasColumnType("datetime")
                .HasColumnName("ppr_fecha_modificacion");
            entity.Property(e => e.PprNombre)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("Nombre del programa de onboarding")
                .HasColumnName("ppr_nombre");
            entity.Property(e => e.PprObjetivo)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasComment("Objetivos del programa de onboarding")
                .HasColumnName("ppr_objetivo");
            entity.Property(e => e.PprPropertyBagData)
                .HasComment("Data de los campos adicionales")
                .HasColumnType("xml")
                .HasColumnName("ppr_property_bag_data");
            entity.Property(e => e.PprUnidadDuracion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("Días")
                .HasComment("Unidad de medida de la duración estimada del programa")
                .HasColumnName("ppr_unidad_duracion");
            entity.Property(e => e.PprUsuarioGrabacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Usuario que creo el registro")
                .HasColumnName("ppr_usuario_grabacion");
            entity.Property(e => e.PprUsuarioModificacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Usuario que modificó por última vez el registro")
                .HasColumnName("ppr_usuario_modificacion");
        });

        modelBuilder.Entity<PriPrioridade>(entity =>
        {
            entity.HasKey(e => e.PriCodigo);

            entity.ToTable("pri_prioridades", "obd", tb => tb.HasComment("Tabla que almacena las prioridades de las actividades del plan de onboarding"));

            entity.Property(e => e.PriCodigo)
                .HasComment("Código de la prioridad")
                .HasColumnName("pri_codigo");
            entity.Property(e => e.PriCodgrc)
                .HasComment("Código de Grupo Corporativo")
                .HasColumnName("pri_codgrc");
            entity.Property(e => e.PriColor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("#A9A9A9")
                .HasComment("Color con que se muestra la prioridad")
                .HasColumnName("pri_color");
            entity.Property(e => e.PriFechaGrabacion)
                .HasComment("Fecha en que se creo el registro")
                .HasColumnType("datetime")
                .HasColumnName("pri_fecha_grabacion");
            entity.Property(e => e.PriFechaModificacion)
                .HasComment("Fecha de la última modificacion del registro")
                .HasColumnType("datetime")
                .HasColumnName("pri_fecha_modificacion");
            entity.Property(e => e.PriIcono)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("Ícono con que se muestra la prioridad")
                .HasColumnName("pri_icono");
            entity.Property(e => e.PriNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Nombre de la prioridad")
                .HasColumnName("pri_nombre");
            entity.Property(e => e.PriOrden)
                .HasComment("Determina el orden las prioridades")
                .HasColumnName("pri_orden");
            entity.Property(e => e.PriPropertyBagData)
                .HasComment("Data de los campos adicionales")
                .HasColumnType("xml")
                .HasColumnName("pri_property_bag_data");
            entity.Property(e => e.PriUsuarioGrabacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Usuario que creo el registro")
                .HasColumnName("pri_usuario_grabacion");
            entity.Property(e => e.PriUsuarioModificacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Usuario que modificó por última vez el registro")
                .HasColumnName("pri_usuario_modificacion");
        });

        modelBuilder.Entity<ProPrograma>(entity =>
        {
            entity.HasKey(e => e.ProCodigo);

            entity.ToTable("pro_programas", "obd", tb => tb.HasComment("Tabla que almacena los programas de onboarding"));

            entity.Property(e => e.ProCodigo)
                .HasComment("Código de programa de onboarding")
                .HasColumnName("pro_codigo");
            entity.Property(e => e.ProCodppr).HasColumnName("pro_codppr");
            entity.Property(e => e.ProDescripcion)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasComment("Descripción del programa de onboarding")
                .HasColumnName("pro_descripcion");
            entity.Property(e => e.ProDuracion)
                .HasComment("Duración estimada del programa")
                .HasColumnName("pro_duracion");
            entity.Property(e => e.ProEstado)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("Planificado")
                .HasComment("Estado del programa 'Planificado' o 'En Ejecución' o 'Finalizado'")
                .HasColumnName("pro_estado");
            entity.Property(e => e.ProFechaGrabacion)
                .HasComment("Fecha en que se creo el registro")
                .HasColumnType("datetime")
                .HasColumnName("pro_fecha_grabacion");
            entity.Property(e => e.ProFechaModificacion)
                .HasComment("Fecha de la última modificacion del registro")
                .HasColumnType("datetime")
                .HasColumnName("pro_fecha_modificacion");
            entity.Property(e => e.ProNombre)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("Nombre del programa de onboarding")
                .HasColumnName("pro_nombre");
            entity.Property(e => e.ProObjetivo)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasComment("Objetivos del programa de onboarding")
                .HasColumnName("pro_objetivo");
            entity.Property(e => e.ProPropertyBagData)
                .HasComment("Data de los campos adicionales")
                .HasColumnType("xml")
                .HasColumnName("pro_property_bag_data");
            entity.Property(e => e.ProUnidadDuracion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("Días")
                .HasComment("Unidad de medida de la duración estimada del programa")
                .HasColumnName("pro_unidad_duracion");
            entity.Property(e => e.ProUsuarioGrabacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Usuario que creo el registro")
                .HasColumnName("pro_usuario_grabacion");
            entity.Property(e => e.ProUsuarioModificacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Usuario que modificó por última vez el registro")
                .HasColumnName("pro_usuario_modificacion");

            entity.HasOne(d => d.ProCodpprNavigation).WithMany(p => p.ProProgramas)
                .HasForeignKey(d => d.ProCodppr)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_obdppr_obdpro");
        });

        modelBuilder.Entity<TacTiposActividad>(entity =>
        {
            entity.HasKey(e => e.TacCodigo);

            entity.ToTable("tac_tipos_actividad", "obd", tb => tb.HasComment("Tabla que almacena los tipos de actividad para los programas de Onboarding"));

            entity.Property(e => e.TacCodigo)
                .HasComment("Código de tipo de actividad")
                .HasColumnName("tac_codigo");
            entity.Property(e => e.TacCodgrc)
                .HasComment("Código de grupo corporativo")
                .HasColumnName("tac_codgrc");
            entity.Property(e => e.TacDescripcion)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("Descripción del tipo de actividad")
                .HasColumnName("tac_descripcion");
            entity.Property(e => e.TacDuracionEstimada)
                .HasComment("Duración estimada de la actividad")
                .HasColumnName("tac_duracion_estimada");
            entity.Property(e => e.TacFechaGrabacion)
                .HasComment("Fecha en que se creo el registro")
                .HasColumnType("datetime")
                .HasColumnName("tac_fecha_grabacion");
            entity.Property(e => e.TacFechaModificacion)
                .HasComment("Fecha de la última modificacion del registro")
                .HasColumnType("datetime")
                .HasColumnName("tac_fecha_modificacion");
            entity.Property(e => e.TacNombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("Nombre del tipo de actividad")
                .HasColumnName("tac_nombre");
            entity.Property(e => e.TacPropertyBagData)
                .HasComment("Data de los campos adicionales")
                .HasColumnType("xml")
                .HasColumnName("tac_property_bag_data");
            entity.Property(e => e.TacReqDocumentos)
                .HasComment("¿Requiere Adjuntar documentos?")
                .HasColumnName("tac_req_documentos");
            entity.Property(e => e.TacReqEvaluacion)
                .HasComment("¿Requiere Evaluación del responsable? (contratado, jefe, RRHH y al responsable de la actividad si está definido)")
                .HasColumnName("tac_req_evaluacion");
            entity.Property(e => e.TacReqNotificacion)
                .HasComment("¿Requiere Notificación luego de que finalice? (contratado, jefe, RRHH y al responsable de la actividad si está definido)")
                .HasColumnName("tac_req_notificacion");
            entity.Property(e => e.TacReqRecordatorio)
                .HasComment("¿Requiere Recordatorio previo a que se inicie? (contratado, jefe, RRHH y al responsable de la actividad si está definido)")
                .HasColumnName("tac_req_recordatorio");
            entity.Property(e => e.TacReqResponsable)
                .HasComment("¿Requiere un responsable asignado?")
                .HasColumnName("tac_req_responsable");
            entity.Property(e => e.TacUnidadDuracion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("Días")
                .HasComment("Unidad de medida para la duración estimada")
                .HasColumnName("tac_unidad_duracion");
            entity.Property(e => e.TacUsuarioGrabacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Usuario que creo el registro")
                .HasColumnName("tac_usuario_grabacion");
            entity.Property(e => e.TacUsuarioModificacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Usuario que modificó por última vez el registro")
                .HasColumnName("tac_usuario_modificacion");
        });

        modelBuilder.Entity<TevTiposEvaluacion>(entity =>
        {
            entity.HasKey(e => e.TevCodigo);

            entity.ToTable("tev_tipos_evaluacion", "obd", tb => tb.HasComment("Tabla con los tipos de evaluaciones que se aplican a las actividades de los planes de onboarding"));

            entity.Property(e => e.TevCodigo)
                .HasComment("Código del tipo de evaluación")
                .HasColumnName("tev_codigo");
            entity.Property(e => e.TevCodfdiEvaluacion)
                .HasComment("Código de formulario dinámico que se utiliza para evaluar una actividad cuando si se utiliza")
                .HasColumnName("tev_codfdi_evaluacion");
            entity.Property(e => e.TevCodgrc)
                .HasComment("Código del Grupo Corporativo")
                .HasColumnName("tev_codgrc");
            entity.Property(e => e.TevDescripcion)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("Descripción del tipo de evaluación")
                .HasColumnName("tev_descripcion");
            entity.Property(e => e.TevFechaGrabacion)
                .HasComment("Fecha en que se creo el registro")
                .HasColumnType("datetime")
                .HasColumnName("tev_fecha_grabacion");
            entity.Property(e => e.TevFechaModificacion)
                .HasComment("Fecha de la última modificacion del registro")
                .HasColumnType("datetime")
                .HasColumnName("tev_fecha_modificacion");
            entity.Property(e => e.TevNombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("Nombre del tipo de evaluación")
                .HasColumnName("tev_nombre");
            entity.Property(e => e.TevPropertyBagData)
                .HasComment("Data de los campos adicionales")
                .HasColumnType("xml")
                .HasColumnName("tev_property_bag_data");
            entity.Property(e => e.TevUsuarioGrabacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Usuario que creo el registro")
                .HasColumnName("tev_usuario_grabacion");
            entity.Property(e => e.TevUsuarioModificacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Usuario que modificó por última vez el registro")
                .HasColumnName("tev_usuario_modificacion");
            entity.Property(e => e.TevUtilizaFdi)
                .HasComment("Determina si el tipo de evaluación utiliza un formulario dinámico")
                .HasColumnName("tev_utiliza_fdi");
        });

        modelBuilder.Entity<TraTiposResponActividad>(entity =>
        {
            entity.HasKey(e => e.TraCodigo);

            entity.ToTable("tra_tipos_respon_actividad", "obd", tb => tb.HasComment("Tabla de Tipos de resposnables de las Actividades"));

            entity.Property(e => e.TraCodigo)
                .HasComment("Código de Tipo de Resonsable de Actividad")
                .HasColumnName("tra_codigo");
            entity.Property(e => e.TraCodgrc)
                .HasComment("Código de Grupo Corporativo")
                .HasColumnName("tra_codgrc");
            entity.Property(e => e.TraCodvliEmpleo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Código de la lista de valores que permite seleccionar un empleo")
                .HasColumnName("tra_codvli_empleo");
            entity.Property(e => e.TraContactoExterno)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("Nombre de una persona contacto, cuando es una institución externa")
                .HasColumnName("tra_contacto_externo");
            entity.Property(e => e.TraDescripcion)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("Descripción del Tipo de Resonsable de Actividad")
                .HasColumnName("tra_descripcion");
            entity.Property(e => e.TraEmailExterno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("Email de notificaciones si es una persona o institución externa")
                .HasColumnName("tra_email_externo");
            entity.Property(e => e.TraEsInstExterna)
                .HasComment("¿Corresponde con una institución externa?")
                .HasColumnName("tra_es_inst_externa");
            entity.Property(e => e.TraEsPersonaExterna)
                .HasComment("¿Corresponde con una persona externa?")
                .HasColumnName("tra_es_persona_externa");
            entity.Property(e => e.TraFechaGrabacion)
                .HasComment("Fecha en que se creo el registro")
                .HasColumnType("datetime")
                .HasColumnName("tra_fecha_grabacion");
            entity.Property(e => e.TraFechaModificacion)
                .HasComment("Fecha de la última modificacion del registro")
                .HasColumnType("datetime")
                .HasColumnName("tra_fecha_modificacion");
            entity.Property(e => e.TraNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Nombre del Tipo de Resonsable de Actividad")
                .HasColumnName("tra_nombre");
            entity.Property(e => e.TraPropertyBagData)
                .HasComment("Data de los campos adicionales")
                .HasColumnType("xml")
                .HasColumnName("tra_property_bag_data");
            entity.Property(e => e.TraRequiereEmpleo)
                .HasDefaultValue(true)
                .HasComment("¿Requiere la selección de un empleado?")
                .HasColumnName("tra_requiere_empleo");
            entity.Property(e => e.TraTelefonoExterno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Teléfono de contacto cuando es una persona o institución externa")
                .HasColumnName("tra_telefono_externo");
            entity.Property(e => e.TraUsuarioGrabacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Usuario que creo el registro")
                .HasColumnName("tra_usuario_grabacion");
            entity.Property(e => e.TraUsuarioModificacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Usuario que modificó por última vez el registro")
                .HasColumnName("tra_usuario_modificacion");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
