using System;
using System.Collections.Generic;

namespace AngelHack.Models
{
    public partial class AppUser
    {
        public AppUser()
        {
            Posts = new HashSet<Posts>();
            UserEvent = new HashSet<UserEvent>();
        }

        public int Id { get; set; }
        public string UserId { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public byte[] UserPass { get; set; } = null!;
        public string UserRole { get; set; } = null!;
        public string DisplayName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Organisation { get; set; } = null!;
        public int TotalPts { get; set; }
        public int TotalHrs { get; set; }

        public virtual ICollection<Posts> Posts { get; set; }
        public virtual ICollection<UserEvent> UserEvent { get; set; }
    }
}
