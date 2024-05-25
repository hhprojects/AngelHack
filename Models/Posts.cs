using System;
using System.Collections.Generic;

namespace AngelHack.Models
{
    public partial class Posts
    {
        public int PostId { get; set; }
        public int UserId { get; set; }
        public string PostTitle { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public DateTime DatePosted { get; set; }
        public string Organiser { get; set; } = null!;

        public virtual AppUser User { get; set; } = null!;
    }
}
