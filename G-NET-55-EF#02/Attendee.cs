using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_55_EF_02
{
    public class Attendee //(Fluent API)
    {
        public int AttendeeId { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }

        public Badge Badge { get; set; }
        public ICollection<Registration> Registrations { get; set; } = new List<Registration>();
    }
}
