using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PaginationDTO
    {
        public int CurrentPage { get; set; }
        public int Count { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public int IndexOne { get; set; }
        public int IndexTwo { get; set; }
        public bool ShowPrevious { get; set; }
        public bool ShoowFirst { get; set; }
        public bool ShowLast { get; set; }
    }
}
