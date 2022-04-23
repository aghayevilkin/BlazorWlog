using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PageItemDTO
    {
        public string Text { get; set; }
        public int PageIndex { get; set; }
        public bool Enabled { get; set; }
        public bool Active { get; set; }

        public PageItemDTO(int pageIndex, bool enabled, string text)
        {
            this.PageIndex = pageIndex;
            this.Enabled = enabled;
            this.Text = text;
        }
    }
}
