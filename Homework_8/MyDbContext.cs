using Microsoft.EntityFrameworkCore;
using TaskLibrary;

namespace Homework_8
{
    public class MyDbContext : DbContext
    {
        public DbSet<TaskModel> Tasks { get; set; }
        public DbSet<StatusModel> Statuses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbPath = Path.Combine(AppContext.BaseDirectory, "tasks.db");
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new TaskModelConfiguration());
            modelBuilder.ApplyConfiguration(new StatusModelConfiguration());

            modelBuilder.Entity<StatusModel>().HasData(
                new StatusModel
                {
                    Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                    Status = StatusForTask.Queue
                },
                new StatusModel
                {
                    Id = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                    Status = StatusForTask.InProgress
                },
                new StatusModel
                {
                    Id = Guid.Parse("33333333-3333-3333-3333-333333333333"),
                    Status = StatusForTask.Completed
                }
            );
        }
    }
}
