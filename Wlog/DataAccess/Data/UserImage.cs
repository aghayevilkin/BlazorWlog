using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class UserImage
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public string UserImageUrl { get; set; }
        [ForeignKey("UserId")]
        public virtual CustomUser CustomUser { get; set; }
    }
}
