using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WhispersOfTheGarden
{
    public class Puzzle
    {
        public string Riddle { get; set; }
        public string Quest { get; set; }
        public List<Item> Requirments { get; set; }
        public Puzzle(string riddle, string quest, Item itemToRecieve, Item itemToTurnIn)
        {
            Riddle = riddle;
            Quest = quest;
            Requirments = new List<Item> { itemToRecieve, itemToTurnIn };
        }
        public bool Solve(Player player)
        {
            if (player.Inventory.Contains(Requirments[1]))
            {
                player.Inventory.Remove(Requirments[1]);
                Console.WriteLine($"\nYou completed the quest: {Quest}!");
                Thread.Sleep(1000);

                player.Inventory.Add(Requirments[0]);
                Console.WriteLine($"\nIn return you recieve {Requirments[0].Name}");
                Thread.Sleep(2000);

                return true;
            }
            else
            {
                Console.WriteLine($"\nYou need {Requirments[1].Name}, to complete this quest!");
                return false;
            }
        }
    }
}