using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using LibraryManagement.Enums;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace LibraryManagement.Model
{
    public class LoginModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }


    }
}