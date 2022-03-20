﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class CustomUser : IdentityUser
    {
        [Required(ErrorMessage = "Name boş olmamalıdır!"), MaxLength(30)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Surname boş olmamalıdır!"), MaxLength(30)]
        public string Surname { get; set; }
        [Required]
        public bool IsVerify { get; set; }

        public string Profision { get; set; }
        public string About { get; set; }
        public string Adress { get; set; }


        public virtual ICollection<UserImage> UserImages { get; set; }

    }
}