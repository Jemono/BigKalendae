using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigKalendae.Models
{
    public class Event
    {
        public int EventID { get; set; }
        public string Title { get; set; }
        public DateTime When { get; set; }
        public string Category { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public decimal Cost { get; set; }
        public string Details { get; set; }
    }
}