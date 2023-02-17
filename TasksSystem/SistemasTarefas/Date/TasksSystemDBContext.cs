using Microsoft.EntityFrameworkCore;
using SistemasTarefas.Models;

namespace TasksSystem.Date
{
    public class TasksSystemDBContext : DbContext
    {
        public TasksSystemDBContext(DbContextOptions<TasksSystemDBContext> options) 
            :base(options)
        {
        }
        
        public DbSet<UserModel> Users { get; set; } // creating table in BD with name 'Users'
        public DbSet<TasksModel> Taks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
