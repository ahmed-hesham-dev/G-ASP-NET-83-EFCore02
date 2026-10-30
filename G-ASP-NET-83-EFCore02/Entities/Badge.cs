using G_ASP_NET_83_EFCore02.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_ASP_NET_83_EFCore02.Entities
{
    public class Badge
    {
        public int Id { get; set; }

        public int BadgeNumber { get; set; }

        public DateTime IssuedDate { get; set; }

        public BadgeTier Tier { get; set; }
        public int AttendeeId { get; set; }
        public Attendee Attendee { get; set; }
    }
}
