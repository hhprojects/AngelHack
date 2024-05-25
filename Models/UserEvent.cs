using System;
using System.Collections.Generic;

namespace AngelHack.Models
{
    public partial class UserEvent
    {
        public string Id { get; set; } = null!;
        public string UeventId { get; set; } = null!;
        public string? Roles { get; set; }

        public virtual AppUser IdNavigation { get; set; } = null!;
        public virtual VEvents Uevent { get; set; } = null!;
    }
}
