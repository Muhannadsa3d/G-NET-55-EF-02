using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace G_NET_55_EF_02
{
    public class Organizer  //(Data Annotations)
    {
        [Key]
        public int OrganizerId { get; set; }

        [Required]
        public string Name { get; set; }

        public string CompanyName { get; set; }
        public bool VerifiedStatus { get; set; }

        public Profile Profile { get; set; }
    }

