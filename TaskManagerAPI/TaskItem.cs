using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace TaskManagerAPI
{
    public class TaskItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        [Required]
        public string Priority { get; set; } = string.Empty;

        //for table bind 
        public UserItem? Assignee { get; set; }

        //forign key
        public int? AssigneeId { get; set; }
        
    }
}
