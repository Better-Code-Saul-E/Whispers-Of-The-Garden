using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WhispersOfTheGarden
{
    public class Plant
    {
        public string Name { get; set; }
        public bool IsFlourishing { get; set; }
        public List<Item> Requirments { get; set; }
        public List<Item> HarvestableItems { get; set; }

        public Plant(string type)
        {
            Name = type;
            IsFlourishing = false;
            Requirments = new List<Item>();
            HarvestableItems = new List<Item>();
        }

        public void AddRequirments(List<Item> items)
        {
            foreach (Item item in items)
            {
                Requirments.Add(item);
            }
        }
        public void AddHarvestableItems(Item item)
        {
            HarvestableItems.Add(item);
        }
        public bool CheckRequirements(List<Item> inventory)
        {
            foreach (var requirement in Requirments)
            {
                if (!inventory.Contains(requirement))
                {
                    return false;
                }
            }
            return true;
        }
        public void Flourish()
        {
            IsFlourishing = true;
        }
    }
}