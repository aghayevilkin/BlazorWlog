using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SubscribeDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Email boş ola bilməz")]
        [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", ErrorMessage = "Zəhmət olmasa email ünvanınızı istifadə edin")]
        public string Email { get; set; }
    }
}
