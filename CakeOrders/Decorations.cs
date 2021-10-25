using System;
using System.Collections.Generic;
using System.Text;

namespace CakeOrders
{
    class Decorations
    {
        public Decorations(string line)
        {
            var split = line.Split(',');
            DecorationID = Convert.ToInt32(split[0]);
            DecorationName = split[1];
        }
        public int DecorationName { get; set; }
        public string DecorationName { get; set; }
    }
}
