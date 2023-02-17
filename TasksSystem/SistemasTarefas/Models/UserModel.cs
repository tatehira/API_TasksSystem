﻿using System.ComponentModel.DataAnnotations.Schema;

namespace SistemasTarefas.Models
{
    [Table("")]
    public class UserModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
    }
}
