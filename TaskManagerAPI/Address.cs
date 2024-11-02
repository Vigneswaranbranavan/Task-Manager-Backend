using System.ComponentModel.DataAnnotations;

namespace TaskManagerAPI
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required string AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? street { get; set; }
        public string? city { get; set; }
        public int? userId { get; set; }

        public UserItem? UserItem { get; set; }
    }
}
