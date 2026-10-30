using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_ASP_NET_83_EFCore02.Entities
{
    public class Attendee
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string FullName { get; set; }
        [Required]
        [MaxLength(200)]

        public string Email { get; set; }
        [Required]
        [MaxLength(150)]

        public string Street { get; set; }
        [Required]
        [MaxLength(100)]

        public string City { get; set; }
        [Required]
        [MaxLength(100)]

        public string Country { get; set; }
        [Required]
        [MaxLength(20)]
        [Column("ZipCode")]
        public string PostalCode { get; set; }
        

        public string FullAddress
        {
            get
            {
                return $"{Street}, {City}, {Country}, {PostalCode}";
            }
        }
    }
}
