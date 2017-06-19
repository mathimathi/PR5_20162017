using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InLES.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Cardname { get; set; }
        public string Cardlink { get; set; }

        public Card(string name, string link)
        {
            this.Cardname = name;
            this.Cardlink = link;
        }
    }
}
