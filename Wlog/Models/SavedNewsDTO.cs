using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SavedNewsDTO
    {
        public int Id { get; set; }
        public int NewsId { get; set; }
        public string UserId { get; set; }
    }
}
