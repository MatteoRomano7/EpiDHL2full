﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EpiDHL.Models
{
    public class User
    {
        [Key]
        public int User_ID { get; set; }

        //Email
        [Display(Name="Email")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Campo Obbligatorio")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Inserisci almeno 3 caratteri")]
        public string Email { get; set; }

        //Password
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Campo Obbligatorio")]
        [StringLength(15, MinimumLength = 8, ErrorMessage = "Min 8, max 15 caratteri")]
        public string Password { get; set; }
    }
}