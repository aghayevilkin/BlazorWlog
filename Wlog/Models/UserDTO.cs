using DataAccess.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class UserDTO
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "Name boş olmamalıdır!"), MaxLength(30)]
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Profision { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string Adress { get; set; }
        public string About { get; set; }
        public string Images { get; set; }
        public string Role { get; set; }
        public bool IsVerify { get; set; }
    }
}
