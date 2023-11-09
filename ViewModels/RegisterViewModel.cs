﻿using System.ComponentModel.DataAnnotations;

namespace Gymmr.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
    }
}
