using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class NewsPaginationDTO
    {
        public PaginationDTO Pagination { get; set; }
        public IEnumerable<NewsDTO> NewsList { get; set; }
    }
}
