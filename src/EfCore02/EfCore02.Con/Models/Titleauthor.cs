using System;
using System.Collections.Generic;

namespace EfCore02.Con.Models
{
    public partial class Titleauthor
    {
        public string AuId { get; set; }
        public string TitleId { get; set; }
        public byte? AuOrd { get; set; }
        public int? Royaltyper { get; set; }

        public Authors Au { get; set; }
        public Titles Title { get; set; }
    }
}
