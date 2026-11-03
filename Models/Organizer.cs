using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET69_EF_Assignment_2.Models
{
    public class Organizer
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string? CompanyName { get; set; }
    }
}
