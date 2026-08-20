using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace G_NET_55_EF_02
{
    public class Session
    {
        [Key]
        public int SessionId { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        [ForeignKey("Event")]
        public int ParentEventId { get; set; }
        public Event Event { get; set; } = null!;
    }
}
