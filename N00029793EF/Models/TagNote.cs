using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N00029793EF.Models
{
    public class TagNote
    {
        public int Id { get; set; }
        public int IdTag { get; set; }
        public int IdNote { get; set; }
        public Tag Tag { get; set; }
        public Note note { get; set; }
    }
}
