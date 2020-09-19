using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Seating.Models
{
    public class SeatingPage
    {
        [Key]
        public int SeatingId { get; set; }
        public DateTime SeatingDate { get; set; }
        public string URL { get; set; }
    }
}