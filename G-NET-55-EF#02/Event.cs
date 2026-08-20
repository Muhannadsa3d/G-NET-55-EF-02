using System;
using System.Collections.Generic;
using System.Text;
using static System.Collections.Specialized.BitVector32;

namespace G_NET_55_EF_02
{
    public class Event //(Configuration)
    {
        public int EventId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int MaxAttendees { get; set; }

        public ICollection<Session> Sessions { get; set; } = new List<Session>();
        public ICollection<Registration> Registrations { get; set; } = new List<Registration>();
    }
}
