using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_55_EF_02
{
    public class Badge  //(Configuration Class)
    {
        public int BadgeId { get; set; }
        public string Number { get; set; } = string.Empty;
        public DateTime IssueDate { get; set; }
        public string Tier { get; set; } = string.Empty;

        public int AttendeeId { get; set; }
        public Attendee Attendee { get; set; } = null!;
    }
}
