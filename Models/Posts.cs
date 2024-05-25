using System;
using System.Collections.Generic;

namespace AngelHack.Models
{
    public partial class Posts
    {
        public string PostId { get; set; } = null!;
        public string? Uid { get; set; }
        public string PostTitle { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public DateTime DatePosted { get; set; }
        public string Organiser { get; set; } = null!;

        public virtual AppUser? UidNavigation { get; set; }
    }
}
