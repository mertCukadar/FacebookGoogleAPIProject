using System;

namespace FacebookGoogleAPIProject.Models
{
    public class User{
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}