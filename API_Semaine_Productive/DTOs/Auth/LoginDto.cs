﻿using System.ComponentModel.DataAnnotations;

namespace API_Semaine_Productive.DTOs.Auth
{
    public class LoginDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
