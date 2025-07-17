﻿using System.ComponentModel.DataAnnotations;

namespace API_Semaine_Productive.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string? Description { get; set; }

        public bool Done { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
