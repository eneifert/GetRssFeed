using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetRssFeed.Models
{
    public class Channel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public string Language { get; set; }
        public string Ttl { get; set; }
        public List<Item> Items { get; set; }

    }
}
