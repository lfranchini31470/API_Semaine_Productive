using System.ComponentModel.DataAnnotations;

namespace API_Semaine_Productive.DTOs
{
    public class TaskItemDTO
    {
        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public string? Description { get; set; }

        public bool Done { get; set; }
    }
}
