using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class Subscribe
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "Maksimum 50 charakter daxil edə bilərsiniz"), Required(ErrorMessage = "Email boş olmamalıdır!")]
        public string Email { get; set; }
        public DateTime AddedDate { get; set; } = DateTime.Now;
    }
}
