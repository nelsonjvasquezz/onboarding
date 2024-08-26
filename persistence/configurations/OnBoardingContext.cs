using Microsoft.EntityFrameworkCore;
using onboarding.data.bases;
using onboarding.persistence.configurations;

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

        modelBuilder.ApplyConfiguration(new ContratacionProgramaConfiguration());
        modelBuilder.ApplyConfiguration(new EventoNotificableConfiguration());
        modelBuilder.ApplyConfiguration(new EtapaProgramaConfiguration());


        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}