using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InLES.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int Price { get; set; }
    }
}