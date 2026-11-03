using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET69_EF_Assignment_2.Models
{
    [Table("EventOrganizers")]
    public class Organizer
    {
        public int Id { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        [MaxLength(150)]
        public string? CompanyName { get; set; }

        public OrganizerProfile? OrganizerProfile { get; set; }
        public ICollection<Event> Events { get; set; } = new List<Event>();
    }
}
