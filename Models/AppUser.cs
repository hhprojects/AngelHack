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

        public string Id { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public byte[] UserPass { get; set; } = null!;
        public string UserRole { get; set; } = null!;

        public virtual ICollection<Posts> Posts { get; set; }
        public virtual ICollection<UserEvent> UserEvent { get; set; }
    }
}
