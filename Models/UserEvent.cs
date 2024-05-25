using System;
using System.Collections.Generic;

namespace AngelHack.Models
{
    public partial class UserEvent
    {
        public int Id { get; set; }
        public int UeventId { get; set; }
        public string? Roles { get; set; }

        public virtual AppUser IdNavigation { get; set; } = null!;
        public virtual VEvents Uevent { get; set; } = null!;
    }
}
