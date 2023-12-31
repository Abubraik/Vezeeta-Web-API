﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static Vezeeta.Core.Enums.Enums;

namespace Vezeeta.Core.Models.Users
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public required string FirstName { get; set; }
        [Required]
        public required string LastName { get; set; }
        [Required]
        public override string Email { get; set; }


        [Required]
        public Gender Gender { get; set; }
        [Required]
        public DateOnly DateOfBirth { get; set; }
        
    }
}
