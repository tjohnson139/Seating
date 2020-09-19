using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seating.Models
{
    public class Break
    {
        public int BreakID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime TimeEntered { get; set; }
        public DateTime? TimeCleared { get; set; }
        public int PositionID { get; set; }
        public bool EmpSent { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Position Position { get; set; }
    }
}