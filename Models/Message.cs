using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seating.Models
{
    public class Message
    {
        public int MessageID { get; set; }
        public DateTime TimeEntered { get; set; }
        public int Priority { get; set; }
        public string MessageText { get; set; }
        public DateTime TimeToClear { get; set; }
    }
}