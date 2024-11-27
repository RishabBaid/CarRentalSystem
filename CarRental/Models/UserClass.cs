﻿using System.ComponentModel.DataAnnotations;

namespace CarRental.Models
{
    public class UserClass
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required string Role { get; set; } // Admin or User
    }
}
