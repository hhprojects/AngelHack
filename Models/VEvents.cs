using System;
using System.Collections.Generic;

namespace AngelHack.Models
{
    public partial class VEvents
    {
        public VEvents()
        {
            UserEvent = new HashSet<UserEvent>();
        }

        public int EventId { get; set; }
        public string Title { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public DateTime DatePosted { get; set; }
        public DateTime EventDate { get; set; }
        public string Organiser { get; set; } = null!;
        public string Locations { get; set; } = null!;
        public string Points { get; set; } = null!;
        public int Hrs { get; set; }

        public virtual ICollection<UserEvent> UserEvent { get; set; }
    }
}
