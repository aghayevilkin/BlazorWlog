using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class NewsImage
    {
        [Key]
        public int Id { get; set; }
        public int NewsId { get; set; }
        public string NewsImageUrl { get; set; }
        [ForeignKey("NewsId")]
        public virtual News News { get; set; }
    }
}
