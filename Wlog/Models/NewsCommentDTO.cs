using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class NewsCommentDTO
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Message boş ola bilməz")]
        [MaxLength(2000)]
        public string Message { get; set; }
        public int NewsId { get; set; }

        public string UserId { get; set; }

        public int? CommentId { get; set; }

        public DateTime AddedDate { get; set; } = DateTime.Now;
    }
}
