using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.Entity.Infrastructure;

namespace DoctorWho.Db
{
    public class DoctorWhoCoreDbContext : DbContext
    {
        public IDbConnection Connection => Database.GetDbConnection();
        public DbSet<Episode> episodes { get; set; }
        public DbSet<Author>  authors { get; set; }
        public DbSet<Doctor> doctors { get; set; }
        public DbSet<Companion> companions { get; set; }
        public DbSet<Enemy> enemies { get; set; }
        public DbSet<EpisodeCompanion> episodesCompanions { get;set; }
        public DbSet<EpisodeEnemy> episodesEnemies { get; set; }
        public DbSet<EpisodeSummaryCompanions> spSummariesEpisodesCompanions { get; set; }
        public DbSet<EpisodeSummaryEnemies> spSummariesEpisodesEnemies { get; set; }
        public DbSet<ViewEpisodes> viewEpisodes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = DoctorWhoDB");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                new Author { AuthorId=1, AuthorName = "Musab" },
                new Author { AuthorId = 2,AuthorName = "Rayyan" },
                new Author { AuthorId = 3,AuthorName = "Hamza" },
                new Author { AuthorId = 4,AuthorName = "Bob" },
                new Author { AuthorId = 5,AuthorName = "Dan" }
                );
            modelBuilder.Entity<Doctor>().HasData(
                new Doctor { DoctorId=1,DoctorNumber = 1, DoctorName = "Dr.Langstrum", BirthDate = new DateTime(2012, 1, 1), FirstEpisodeDate = new DateTime(2012, 1, 1), LastEpisodeDate = new DateTime(2013, 1, 1) },
                new Doctor { DoctorId = 2, DoctorNumber = 2, DoctorName = "Dr.Viktor", BirthDate = new DateTime(2013, 1, 1), FirstEpisodeDate = new DateTime(2013, 1, 1), LastEpisodeDate = new DateTime(2014, 1, 1) },
                new Doctor { DoctorId = 3, DoctorNumber = 3, DoctorName = "Dr.Robotnik", BirthDate = new DateTime(2014, 1, 1), FirstEpisodeDate = new DateTime(2014, 1, 1), LastEpisodeDate = new DateTime(2015, 1, 1) },
                new Doctor { DoctorId = 4, DoctorNumber = 4, DoctorName = "Dr.Briggs", BirthDate = new DateTime(2015, 1, 1), FirstEpisodeDate = new DateTime(2015, 1, 1), LastEpisodeDate = new DateTime(2016, 1, 1) },
                new Doctor { DoctorId = 5,  DoctorNumber = 5, DoctorName = "Dr.Doofenshmirtz", BirthDate = new DateTime(2016, 1, 1), FirstEpisodeDate = new DateTime(2016, 1, 1), LastEpisodeDate = new DateTime(2017, 1, 1) }
               );
            modelBuilder.Entity<Enemy>().HasData(
                new Enemy { EnemyId=1,EnemyName = "Goomba", Description = "Marching Pawn" },
                new Enemy { EnemyId = 2, EnemyName = "Koopa", Description = "Likes Shells" },
                new Enemy { EnemyId = 3, EnemyName = "Hammer Man", Description = "Throws Hammers" },
                new Enemy { EnemyId = 4, EnemyName = "Hammer Man", Description = "Throws Hammers" },
                new Enemy { EnemyId = 5, EnemyName = "Crayola Man", Description = "Uses Crayons" }
                );
            modelBuilder.Entity<Companion>().HasData(
                new Companion { CompanionId=1,CompanionName = "Freddy", WhoPlayed = "Joe" },
                new Companion { CompanionId=2,CompanionName = "Creddy", WhoPlayed = "Moe" },
                new Companion { CompanionId=3,CompanionName = "Leddy", WhoPlayed = "Loe" },
                new Companion { CompanionId = 4,CompanionName = "Teddy", WhoPlayed = "Row" },
                new Companion { CompanionId = 5,CompanionName = "Reddy", WhoPlayed = "Bow" }
                );
            modelBuilder.Entity<Episode>().HasData(
               new Episode { EpisodeId=1,SeriesNumber=1,EpisodeNumber=1,EpisodeType="Good",Title="All Ends it Ends Well",Notes="",AuthorId=1,DoctorId=1},
               new Episode { EpisodeId = 2, SeriesNumber = 2, EpisodeNumber = 2, EpisodeType = "Ok", Title = "Darkness Rising", Notes = "", AuthorId = 2, DoctorId = 2 },
               new Episode { EpisodeId = 3, SeriesNumber = 3, EpisodeNumber = 3, EpisodeType = "Bad", Title = "Sun Shining", Notes = "", AuthorId = 3, DoctorId = 3 },
               new Episode { EpisodeId = 4, SeriesNumber = 4, EpisodeNumber = 4,EpisodeType ="Excellent",Title="Last Stand",Notes="",AuthorId=4,DoctorId=4},
               new Episode { EpisodeId = 5, SeriesNumber = 5, EpisodeNumber = 5, EpisodeType = "Noice", Title = "One Chance Left", Notes = "", AuthorId = 5, DoctorId = 5 }
               );
            modelBuilder.Entity<EpisodeCompanion>().HasData(
                new EpisodeCompanion {EpisodeCompanionId=1, EpisodeId=1,CompanionId=1 },
                new EpisodeCompanion { EpisodeCompanionId = 2, EpisodeId = 2, CompanionId = 2 },
                new EpisodeCompanion { EpisodeCompanionId = 3,EpisodeId = 3, CompanionId = 3 },
                new EpisodeCompanion { EpisodeCompanionId = 4,EpisodeId = 4, CompanionId = 4 },
                new EpisodeCompanion { EpisodeCompanionId = 5, EpisodeId = 5, CompanionId = 5 }

                );
            modelBuilder.Entity<EpisodeEnemy>().HasData(
           new EpisodeEnemy {EpisodeEnemyId=1, EpisodeId = 1, EnemyId = 1 },
           new EpisodeEnemy { EpisodeEnemyId = 2, EpisodeId = 2, EnemyId = 2 },
           new EpisodeEnemy { EpisodeEnemyId = 3, EpisodeId = 3, EnemyId = 3 },
           new EpisodeEnemy { EpisodeEnemyId = 4, EpisodeId = 4, EnemyId = 4 },
           new EpisodeEnemy { EpisodeEnemyId = 5, EpisodeId = 5, EnemyId = 5 }

           );
         modelBuilder.Entity<EpisodeSummaryCompanions>().HasNoKey();
         modelBuilder.Entity<EpisodeSummaryEnemies>().HasNoKey();
         modelBuilder.Entity<ViewEpisodes>().HasNoKey().ToView("viewEpisodes");
        }
    }
}