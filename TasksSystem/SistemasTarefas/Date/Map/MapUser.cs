using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemasTarefas.Models;

namespace TasksSystem.Date.Map
{
    public class MapUser : IEntityTypeConfiguration<UserModel>
    {
        public void Configure(EntityTypeBuilder<UserModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(50);
        }
    }
}
