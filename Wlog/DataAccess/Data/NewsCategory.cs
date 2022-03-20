using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class NewsCategory
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Category Name boş olmamalıdır!")]
        public string Name { get; set; }
        public List<NewsSubCategory> NewsSubCategories { get; set; }
    }
}
