namespace SistemasTarefas.Models
{
    public class TasksModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public TaskStatus Status { get; set; }
    }
}
