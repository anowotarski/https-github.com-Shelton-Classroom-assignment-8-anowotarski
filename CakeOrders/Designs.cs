using System;
using System.Collections.Generic;
using System.Text;


namespace CakeOrders
{
    class Designs
    {
        public Designs(string line)
        {
            var split = line.Split(',');
            DesignID = Convert.ToInt32(split[0]);
            DesignName = split[1];
        }
            public int DesignName { get; set; }
            public string DesignName { get; set; }
    }
}
