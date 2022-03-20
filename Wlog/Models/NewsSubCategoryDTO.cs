using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class NewsSubCategoryDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Category name is empty!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "You must choose a category!")]
        public int NewsCategoryId { get; set; }
    }
}
