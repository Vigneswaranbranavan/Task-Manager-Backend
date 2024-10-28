﻿using System.ComponentModel.DataAnnotations;

namespace TaskManagerAPI
{
    public class UserItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        public string PhoneNumber { get; set; }
    }
}