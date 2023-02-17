using System.ComponentModel;

namespace TasksSystem.Enums
{
    public enum TaskStatus
    {
        [Description("A fazer")]
        ToDo = 1,
        [Description("Em Andamento")]
        InProgress = 2,
        [Description("Concluido")]
        Concluded = 3
    }
}
