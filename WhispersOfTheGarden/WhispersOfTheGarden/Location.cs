using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WhispersOfTheGarden
{
    public class Location
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Spirit> Spirits { get; set; }

        public List<List<Item>> Items = new List<List<Item>>();

        public Location(string name, string description)
        {
            Name = name;
            Description = description;
            Spirits = new List<Spirit>();
        }
        public void AddSprirt(Spirit spirit)
        {
            Spirits.Add(spirit);
        }
        public void AddItem(List<Item> items)
        {
            Items.Add(items);
        }
        public void Explore()
        {
            Console.Clear();
            Console.WriteLine($"\nExploring {Name}: {Description}\n");

            if (Spirits.Count > 0)
            {
                foreach (Spirit spirit in Spirits)
                {
                    Console.WriteLine($"{spirit.Name} appears to linger");
                }
            }
            else
            {
                Console.WriteLine("\nWhere'd those spirits go!");
            }

            if (Items.Count > 0)
            {
                Console.WriteLine("\nIt appears there are items here aswell!");

                Console.WriteLine($"\n{"Name:",-20}{"Type:",-10} Needed to collect:");
                foreach (List<Item> Items in Items)
                {
                    if (Items.Count > 1)
                    {

                        Console.WriteLine($"{Items[0].Name,-20}{Items[0].Type,-10} {Items[1].Name}");
                    }
                    else
                    {
                        Console.WriteLine($"{Items[0].Name,-20}{Items[0].Type,-10}");

                    }
                }
            }
            else
            {
                Console.WriteLine("\nNo items wonder where they went");
            }

            Console.WriteLine("\nPress any key to continue with the exploration!");
            Console.ReadKey();
        }
    }
}