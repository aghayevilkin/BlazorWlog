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
    public class NewsDTO
    {
        public int Id { get; set; }
        [MaxLength(500), Required(ErrorMessage = "Title boş olmamalıdır!")]
        public string Title { get; set; }

        public string Details { get; set; }
        public DateTime AddedDate { get; set; }

        public NewsStatus NewsStatus { get; set; }

        [Required(ErrorMessage = "Category Secmelisiniz!")]
        public int CategoryId { get; set; }
        public NewsSubCategory Category { get; set; }

        public int ViewCount { get; set; }

        [NotMapped]
        public int[] TagIds { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public CustomUser User { get; set; }


        public virtual ICollection<NewsComment> NewsComments { get; set; }
        public virtual ICollection<TagToNews> TagToNews { get; set; }
        public virtual ICollection<SavedNews> SavedNews { get; set; }

        public virtual ICollection<NewsImageDTO> NewsImages { get; set; }
        public List<string> ImageUrls { get; set; }
    }
}
