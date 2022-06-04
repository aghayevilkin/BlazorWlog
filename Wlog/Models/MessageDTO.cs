using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MessageDTO
    {
        public int Id { get; set; }

        [MaxLength(20, ErrorMessage = "Maksimum 20 charakter daxil edə bilərsiniz"), Required(ErrorMessage = "Name boş olmamalıdır!")]
        public string Name { get; set; }

        [MaxLength(50, ErrorMessage = "Maksimum 50 charakter daxil edə bilərsiniz"), Required(ErrorMessage = "Email boş olmamalıdır!")]
        [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", ErrorMessage = "Zəhmət olmasa email ünvanınızı istifadə edin")]
        public string Email { get; set; }

        [MaxLength(50, ErrorMessage = "Maksimum 50 charakter daxil edə bilərsiniz"), Required(ErrorMessage = "Subject boş olmamalıdır!")]
        public string Subject { get; set; }
        [Column(TypeName = "ntext"), Required(ErrorMessage = "Content boş olmamalıdır!")]
        public string Content { get; set; }
        public DateTime AddedDate { get; set; } = DateTime.Now;
    }
}
