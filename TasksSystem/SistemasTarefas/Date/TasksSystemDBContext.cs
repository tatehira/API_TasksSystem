using Microsoft.EntityFrameworkCore;
using SistemasTarefas.Models;
using TasksSystem.Date.Map;

namespace TasksSystem.Date
{
    public class TasksSystemDBContext : DbContext
    {
        public TasksSystemDBContext(DbContextOptions<TasksSystemDBContext> options) 
            :base(options)
        {
        }
        
        public DbSet<UserModel> Users { get; set; } // creating table in BD with name 'Users'
        public DbSet<TasksModel> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MapUser());
            modelBuilder.ApplyConfiguration(new MapTasks());

            base.OnModelCreating(modelBuilder);
        }
    }
}
