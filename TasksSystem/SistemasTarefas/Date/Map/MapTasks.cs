using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemasTarefas.Models;

namespace TasksSystem.Date.Map
{
    public class MapTasks : IEntityTypeConfiguration<TasksModel>
    {
        public void Configure(EntityTypeBuilder<TasksModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Status).IsRequired();
        }
    }
}
