using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using RepositoryEngine.data;

namespace RepositoryEngine.sqlite
{
    public class SlackContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<Script> Scripts { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Trivia> Trivias { get; set; }
        public DbSet<BadWords> BadWordses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=slackdb.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Property(t => t.Id).IsRequired();
            modelBuilder.Entity<History>().Property(t => t.Id).IsRequired();
            modelBuilder.Entity<Script>().Property(t => t.Id).IsRequired();
            modelBuilder.Entity<Trivia>().Property(t => t.Id).IsRequired();
            modelBuilder.Entity<Quiz>().Property(t => t.Id).IsRequired();
            modelBuilder.Entity<Attendance>().Property(t => t.Id).IsRequired();
            modelBuilder.Entity<BadWords>().Property(t => t.Id).IsRequired();
        }


    }
}
