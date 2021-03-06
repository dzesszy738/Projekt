﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Logowanie.Models.AccountViewModels
{
    public class ForgottPassword
    {
        [Required(ErrorMessage ="Pole wymagane")]
        [EmailAddress(ErrorMessage ="Niepoprawny adres email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Pole wymagane")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Pole wymagane")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        [Required]
        public string Token { get; set; }
    }
}
