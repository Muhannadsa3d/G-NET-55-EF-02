using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace G_NET_55_EF_02
{
    public class Registration //(Data Annotations)
    {
        [Key]
        public int RegistrationId { get; set; }

        public int AttendeeId { get; set; }
        public Attendee Attendee { get; set; } = null!;

        public int EventId { get; set; }
        public Event Event { get; set; } = null!;

        public string? Note { get; set; }
        public DateTime RegistrationDateTime { get; set; }
    }
}
