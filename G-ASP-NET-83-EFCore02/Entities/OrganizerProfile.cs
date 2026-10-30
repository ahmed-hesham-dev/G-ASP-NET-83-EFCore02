using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_ASP_NET_83_EFCore02.Entities
{

    [Table("EventOrganizers")]

    public class OrganizerProfile
    {

        public int Id { get; set; }


        public string Bio { get; set; }

        public string Website { get; set; }

        public string Logo
        {
            get; set;
        }
        }
}
