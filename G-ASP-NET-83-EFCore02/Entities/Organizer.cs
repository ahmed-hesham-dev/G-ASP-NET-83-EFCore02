using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_ASP_NET_83_EFCore02.Entities
{
    public class Organizer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string? CompanyName { get; set; }

        public bool IsVerified { get; set; }
    }
}
