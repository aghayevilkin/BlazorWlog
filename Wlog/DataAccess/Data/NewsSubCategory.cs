using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class NewsSubCategory
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public int NewsCategoryId { get; set; }
        [ForeignKey("NewsCategoryId")]
        public NewsCategory NewsCategory { get; set; }

        public List<News> News { get; set; }
    }
}
