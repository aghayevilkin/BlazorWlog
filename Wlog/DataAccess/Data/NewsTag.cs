using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class NewsTag
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30, ErrorMessage = "Maksimum 30 charakter daxil edə bilərsiniz"), Required(ErrorMessage = "Ad boş olmamalıdır!")]
        public string Name { get; set; }
        public List<TagToNews> TagToNews { get; set; }
    }
}
