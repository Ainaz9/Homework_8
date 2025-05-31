using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace TaskLibrary
{
    /// <summary>
    /// Конфигурация задачи
    /// </summary>
    public class TaskModelConfiguration : IEntityTypeConfiguration<TaskModel>
    {
        /// <summary>
        /// Метод добавления конфигурации задачи
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<TaskModel> builder)
        {
            builder.HasKey(f => f.Id);

            builder
                .HasOne(f => f.Status)
                .WithMany(u => u.Tasks);
        }
    }
}
