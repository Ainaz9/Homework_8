using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace TaskLibrary
{
    /// <summary>
    /// Конфигурация задачи
    /// </summary>
    public class StatusModelConfiguration : IEntityTypeConfiguration<StatusModel>
    {
        /// <summary>
        /// Метод добавления конфигурации задачи
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<StatusModel> builder)
        {
            builder.HasKey(f => f.Id);

            builder
                .HasMany(f => f.Tasks)
                .WithOne(u => u.Status);
        }
    }
}
