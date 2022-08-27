using Microsoft.EntityFrameworkCore;

namespace DoctorWho.Db
{
    public class DoctorWhoCoreDbContext : DbContext
    {
        DbSet<Episode> episodes { get; set; }
        DbSet<Author>  authors { get; set; }
        DbSet<Doctor> doctors { get; set; }
        DbSet<Companion> companions { get; set; }
        DbSet<Enemy> enemies { get; set; }
        DbSet<EpisodeCompanion> episodesCompanions { get;set; }
        DbSet<EpisodeEnemy> episodesEnemies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = DoctorWhoDB");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }
    }
}