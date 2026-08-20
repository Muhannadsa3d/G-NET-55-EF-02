using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_55_EF_02
{
    public class Profile //(Flunet API)
    {
        public int ProfileId { get; set; }
        public string Biography { get; set; }
        public string Website { get; set; }
        public string Logo { get; set; }

        public int OrganizerId { get; set; }
        public Organizer Organizer { get; set; } = null!;
    }
}
