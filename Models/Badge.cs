using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G_NET69_EF_Assignment_2.Enums;

namespace G_NET69_EF_Assignment_2.Models
{
    public class Badge
    {
        public int Id { get; set; }
        public string Number { get; set; } = null!;
        public DateTime IssueDate { get; set; }
        public BadgeTier Tier { get; set; }
    }
}
