using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WhispersOfTheGarden
{
    public class Player : Character
    {
        //public string Name { get; set; }
        public List<Item> Inventory { get; set; }

        public Player(string name) : base(name)
        {
            Inventory = new List<Item>();
        }
        public void DisplayInventory()
        {
            Console.WriteLine("Opening backpack");
            Thread.Sleep(2000);
            Console.Clear();

            if (Inventory.Any())
            {
                Console.WriteLine($"\n{Name}'s Inventory:");
                foreach (var item in Inventory)
                {
                    Console.WriteLine($"\t{item.Name} - {item.Type}");
                }
            }
            else
            {
                Console.WriteLine("\nYour backpack is empty. Perhaps, there are items you can collect . . .");
            }
            Console.WriteLine("\nPress any key to close your backpack");
            Console.ReadKey();
        }
        public override void Interact()
        {
            Console.WriteLine("There is nothing here to interact with.");
        }
        public  void Interact(Location location, int index)
        {
            if (location.Items[index].Count <= 1)
            {
                Inventory.Add(location.Items[index][0]);
                Console.WriteLine($"\nYou have gathered a(n) {location.Items[index][0].Name}!");
                Console.WriteLine("\n- Details of item collected -");
                Console.WriteLine($" Type: {location.Items[index][0].Type}");
                Console.WriteLine($" Description: {location.Items[index][0].Description}");
                location.Items.RemoveAt(index);
            }
            else
            {
                if (Inventory.Contains(location.Items[index][1]))
                {

                    Inventory.Add(location.Items[index][0]);
                    Console.WriteLine($"\nYou collected {location.Items[index][0].Name} using {location.Items[index][1].Name}");
                    Console.WriteLine("\n- Details of item collected -\n");
                    Console.WriteLine($" Type: {location.Items[index][0].Type}");
                    Console.WriteLine($" Description: {location.Items[index][0].Description}");
                    location.Items.RemoveAt(index);
                }
                else
                {
                    Console.WriteLine($"\nYou need {location.Items[index][1].Name} to collect {location.Items[index][0].Name}");
                }
            }
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }
        public bool Fertilize(Plant plant)
        {
            if (plant.CheckRequirements(Inventory))
            {
                foreach (var requirement in plant.Requirments)
                {
                    Inventory.Remove(requirement);
                }

                plant.Flourish();
                Console.WriteLine($"\n{plant.Name} has flourished!");
            }
            else
            {
                Console.WriteLine($"\nYou need more items to tend to {plant.Name}.");
            }
            Console.WriteLine("\nPress any key to continue searching");
            Console.ReadKey();
            return plant.IsFlourishing;
        }
        public void Harvest(Plant plant)
        {
            if (!Inventory.Contains(plant.HarvestableItems[0]))
            {
               Inventory.Add(plant.HarvestableItems[0]); 

               Console.WriteLine($"\nYou harvested {plant.HarvestableItems[0].Name} from {plant.Name}!");
            }
            else
            {
                Console.WriteLine("\nHarvest any more and you'll kill it!");
            }
            
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }
    }
}