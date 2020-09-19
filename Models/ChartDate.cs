using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Seating.Models
{
    public class ChartDate
    {
        [Key]
        public int ChartID { get; set; }
        public DateTime URLDate { get; set; }
        public string ChartURL { get; set; }
    }
}