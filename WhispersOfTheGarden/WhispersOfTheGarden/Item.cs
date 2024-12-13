using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WhispersOfTheGarden
{
    public class Item
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }

        public Item(string name, string type, string description)
        {
            Name = name;
            Type = type;
            Description = description;
        }
    }
}