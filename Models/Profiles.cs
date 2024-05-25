using System;
using System.Collections.Generic;

namespace AngelHack.Models
{
    public partial class Profiles
    {
        public string Id { get; set; } = null!;
        public string DisplayName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Organisation { get; set; } = null!;
        public int TotalPts { get; set; }
        public int TotalHrs { get; set; }

        public virtual AppUser IdNavigation { get; set; } = null!;
    }
}
