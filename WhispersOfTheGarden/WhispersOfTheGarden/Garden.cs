using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace WhispersOfTheGarden
{
    public class Garden
    {
        public string Name { get; set; }
        public List<Location> Areas { get; set; }
        public List<Plant> Plants { get; set; }
        public List<Plant> FlourishedPlants {  get; set; }
        public bool Flourishing { get; set; }

        public Garden(string name)
        {
            FlourishedPlants = new List<Plant>();
            Name = name;

            //Whispering willow
            Item elderOakBark = new Item("Elder Oak Bark", "Material", "Bark from the ancient Elder Oak tree");
            Item willowBark = new Item("Willow Bark", "Material", "Bark from a willow tree");
            Item willowTears = new Item("Willow Tears", "Material", "Drops of sap from willow trees");
            Item fireflyJar = new Item("Firefly Jar", "Container", "A jar for capturing fireflies");
            Item ancientBark = new Item("Ancient Bark", "Material", "Bark from an ancient tree");
            Item whisperingLeaf = new Item("Whispering Leaf", "Material", "A leaf that carries whispers of the past");
            Item forestEssence = new Item("Forest Essence", "Liquid", "A vial containing the pure essence of an ancient forest, brimming with life");

            //rose valley
            Item goldenRose = new Item("Golden Rose", "Flower", "A rare rose that shines like gold");
            Item sunshineBottle = new Item("Sunshine Bottle", "Container", "A bottle that holds sunlight");
            Item solarLens = new Item("Solar Lens", "Tool", "A lens that focuses sunlight");
            Item roseBouquet = new Item("Rose Bouquet", "Flower", "A bouquet of beautiful roses.");
            Item mysticFlower = new Item("Mystic Flower", "Flower", "A flower said to have mystical powers");
            Item fadedPetal = new Item("Faded Petal", "Flower", "A petal that has lost its color");
            Item goldenSeed = new Item("Golden Seed", "Seed", "A seed that glimmers like gold");
            Item dyingRose = new Item("Dying Rose", "Flower", "A rose nearing the end of its life");
            Item crystalPetal = new Item("Crystal Petal", "Flower", "A petal made of crystal");
            Item phoenixFeather = new Item("Phoenix Feather", "Material", "A rare feather from a mystical phoenix, said to hold regenerative properties");

            //moonlit canyon
            Item celestialPendant = new Item("Celestial Pendant", "Accessory", "A pendant that holds the essence of stars");
            Item lunarNectar = new Item("Lunar Nectar", "Liquid", "A nectar that glows under moonlight");
            Item moonlightVial = new Item("Moonlight Vial", "Container", "A vial that captures moonlight");
            Item lunarGlass = new Item("Lunar Glass", "Tool", "Glass that reflects the moon's glow");
            Item waterContainer = new Item("Water Container", "Container", "A container for collecting water");
            Item starDust = new Item("Star Dust", "Material", "Dust from the stars");
            Item twilightDew = new Item("Twilight Dew", "Liquid", "Dew collected from the leaves of plants at the exact moment day turns to night");
            Item wispLantern = new Item("Wisp Lantern", "Tool", "A lantern that guides the user through dark, enchanted forests, lighting the path ahead");

            //orchid lagoon
            Item crystalWaterContainer = new Item("Crystal Water Container", "Container", "A crystal container for water");
            Item mistCollector = new Item("Mist Collector", "Tool", "A tool for collecting mist");
            Item veilOfFog = new Item("Veil of Fog", "Material", "A piece of the fog veil");
            Item sunSpot = new Item("Sun Spot", "Material", "A spot that captures sunlight");
            Item potentWater = new Item("Potent Water", "Liquid", "Water infused with powerful properties");
            Item dewdrop = new Item("Dewdrop", "Liquid", "A drop of dew collected from the early morning");
            Item glimmeringPearl = new Item("Glimmering Pearl", "Material", "A pearl that shines with a soft, ethereal glow");
            Item sapphireShard = new Item("Sapphire Shard", "Material", "A shard of sapphire, said to hold the essence of the deep sea");
            Item emeraldVine = new Item("Emerald Vine", "Material", "A rare vine with emerald green leaves, known for its resilience and beauty");

            //enchanting ruins
            Item rareSeed = new Item("Rare Seed", "Seed", "A rare seed that can grow into a unique plant");
            Item fertilizer = new Item("Fertilizer", "Material", "A nutrient-rich substance for plants");
            Item thornShield = new Item("Thorn Shield", "Tool", "A protective shield made of thorns");
            Item guardiansEmblem = new Item("Guardian's Emblem", "Accessory", "An emblem that signifies a guardian");
            Item enchantedStone = new Item("Enchanted Stone", "Stone", "A stone that holds enchantments");
            Item lostSoul = new Item("Lost Soul", "Material", "A soul that has lost its way");
            Item potentSand = new Item("Potent Sand", "Material", "Sand with enhanced magical properties");
            Item appleBlossom = new Item("Apple Blossom", "Flower", "A blooming apple flower");
            Item rootCollectorTool = new Item("Root Collector Tool", "Tool", "A tool used to collect roots");
            Item spiritDust = new Item("Spirit Dust", "Material", "Dust infused with spirit energy");
            Item dragonScale = new Item("Dragon Scale", "Material", "A scale from a legendary dragon, radiating heat and power");
            Item mossyStone = new Item("Mossy Stone", "Stone", "A stone covered in soft moss, often found near ancient ruins");
            Item obsidianBlade = new Item("Obsidian Blade", "Tool", "A sharp blade made of dark, volcanic glass, used to cut through the toughest roots");

            Areas = new List<Location>
            {
            new Location("Whispering Willows", "A serene forest with ancient willow trees whose leaves."),
            new Location("Rose Valley", "A never ending field of roses that always point north, said to grant immortality."),
            new Location("Moonlit Canyon", "A silent but colorful canyon where sunlight never touches."),
            new Location("Orchid Lagoon", "A body of water containing purple water, where everything that touches it loses its color."),
            new Location("Enchanting Ruins", "A civilization of botanists, overrun with plants that can touch the sky and trees that can walk.")
            };

            // Adding spirits to locations
            Areas[0].AddSprirt(new Spirit(
                "Wisdom Spirit", "A rose, it represents everything and yet nothing.", "That wizard's gifts? They hold curses deeper than what appears.", "Bring me the dying rose, it still has a chance.",
                celestialPendant, dyingRose, @"
       ___.-.    
     _/ww/ ..\_    
    /-/  \ ww/ ) 
         /  Y\/        
        /     \
      _/       \ 
     (   __.-._/"));
            Areas[0].AddSprirt(new Spirit(
                "Leaf Spirit", "Water at day nectar at night", "Thank you for the nectar! Maybe one day it will turn me in to a tree!", "Please, bring me some lunar nectar. I aspire to be a tree.",
                phoenixFeather, lunarNectar,
                @"
         ___
        /T_T\__
        \___/-/
        
                
            "));

            Areas[1].AddSprirt(new Spirit(
                "Rose Spirit", "My petals are falling, a sign of sorrow. Yet i cannot feel it.", "Thank you for these tears, each drop carries memories, and each memory helps me bloom.", "I need some willow tears. I have yet to recive in some time.",
                rootCollectorTool, willowTears, @"
       o___
     --/ ''\-l
   '   \  ~/
       WWW W 
      /     \
 p   /  u    \  w"));
            Areas[1].AddSprirt(new Spirit(
                "Sun Spirit", "It rose in the east and brought warmth upon this land.", "Thank you for this feather, it as healing properties.", "Bring me the remnants of a phoenix. Its feather!",
                 lunarNectar, phoenixFeather, @"
         ____ 
         /- -\   
         \  o/ *cough
         /   |
        /     \
      _/       \ 
      ----------"));
            Areas[1].AddSprirt(new Spirit(
                "Fire Spirit", "Born from flame, it consumes and protects from it to.", "Thank you... this warmth it speaks to me.", "Legends say a ddragon's scale holds flame. Bring me the last dragon scale.",
                guardiansEmblem, dragonScale, @"
         wwwww  
         / **\   
         \  y/__
         /    __| ',''','  
        /     \
      _/       \ 
      ##########"));

            Areas[2].AddSprirt(new Spirit(
                "Moon Spirit", "It glows at night, but vanishes at dawn.", "I remeber bathing with sunlight . . . but that wizard to-", "Bring me a bottle of sunshine. Its dark down here.",
                 moonlightVial, sunshineBottle, @"
          .-.    
         / ee\   
     ____\  o/_____
    (____     ____p)      
        /     \
      _/       \ 
     (   __.-._/"));
            Areas[2].AddSprirt(new Spirit(
                "Star Spirit", "It shines brigher than them, even though its one of them", "If you encounter the wizard again, keep your distance.", "Bring me the golden rose. ",
                solarLens, goldenRose, @"
        .-.
       /** \
       \-  /_
       /    /    
      /     \      
     /       \__    
     \_.-._._   ) 
             `-` "));
            Areas[2].AddSprirt(new Spirit(
                "Wind Spirit", "Invisible, but it flows freely where spirits roam.", "So, this is what spirit dust looks like, if i had known. I would've picked it off the ground.", "I myself have yet to see it. Spirit Dust!",
                goldenSeed, spiritDust, @"
        ___
      _/ ''\
     ( \  ~/__
      \    \__)
      /     \
     /       \"));

            Areas[3].AddSprirt(new Spirit(
                "Water Spirit", "This water flows freely, just like me!", "Thanks! The leaf you gave me carries secrets.", "Could you find me a leaf that whisphers? Please?",
                waterContainer, whisperingLeaf, @"
          .-.    
         / ee\_    
       __\  o/ )  
      (___   \/        
        /     \
      _/       \ 
     (   __.-._/"));
            Areas[3].AddSprirt(new Spirit(
                "Fog Spirit", "It is like mist but yet it lingers.", "Sorry for tantrum earlier. . .", "GIVE ME STAR DUST! GIVE ME STAR DUST! GIVE ME STAR DUST!",
                mistCollector, starDust,
                @"
         ___
        /! !\
        \ X /
        /   \
       /     \
      /       \
      \_______/"));
            Areas[3].AddSprirt(new Spirit(
                "Earth Spirit", "They say each crack in the bark tells a story.", "Thanks? We spirits have no memory of how we came to be.", "Please give me some ancient bark, it might help me remember a past.",
                crystalWaterContainer, ancientBark,
                @"
         ___
        /? ?\
        \ _ /
        /   \
       /=====\
      /=======\
     `''''''''''``"));

            Areas[4].AddSprirt(new Spirit(
                "Apple Spirit", "What grows from a tree and is often red or green? ", "With this blossom i will restore what once grew.", "I need an apple blossom. It hasn't grown here in decades.",
                rareSeed, appleBlossom,
                @"
         ___
        / ^^\
        \  u/__
        /    \__@)
       / @@@@\
      /      _\
     `''''''''''``"));
            Areas[4].AddSprirt(new Spirit(
                "Growth Spirit", "Long ago, this gardem flourished, it was filled with colors and life.", "Is this what hope feels like.", "I would like some start dust, maybe that would cheer me up.",
                lostSoul, starDust,
                @"
         ___
       _/T~T\
       (\    /
        /    \_
       /      _\
     `''''''''''``"));
            Areas[4].AddSprirt(new Spirit(
                "Guardian Spirit", "It gives me my strength, without it i am nothing but a ghost.", "Thank you for you kindness, It brings much memories. Sadly, there is little left protect.", "Bring me my emblem. For it reminds me of the strength i once had.",
                thornShield, guardiansEmblem,
                @"
         ___    ^
        / ,,\   |
        \  0/__ |
        /|||\__o)
       /|||||\
      /      _\
     `''''''''''``"));
            Areas[4].AddSprirt(new Spirit(
                "Frost Spirit", "This warth brings joy to some, but to me, it makes me fade i cannot enjoy it.", "Thank You, i shall continute to preserve!", "Find the enchanted stone. Without it i will melt.",
                veilOfFog, enchantedStone,
                @"
         ___
        /X X\
      __\  O/__
     (__/    \__)"));

            Areas[0].AddItem(new List<Item> { elderOakBark, obsidianBlade });
            Areas[0].AddItem(new List<Item> { willowBark, obsidianBlade });
            Areas[0].AddItem(new List<Item> { willowTears, waterContainer });
            Areas[0].AddItem(new List<Item> { ancientBark, obsidianBlade });
            Areas[0].AddItem(new List<Item> { forestEssence, fireflyJar });
            Areas[0].AddItem(new List<Item> { fireflyJar });
            Areas[0].AddItem(new List<Item> { starDust });
            Areas[0].AddItem(new List<Item> { whisperingLeaf });

            Areas[1].AddItem(new List<Item> { sunshineBottle });
            Areas[1].AddItem(new List<Item> { dyingRose });
            Areas[1].AddItem(new List<Item> { appleBlossom });
            Areas[1].AddItem(new List<Item> { spiritDust, fireflyJar });
            Areas[1].AddItem(new List<Item> { sunSpot, fireflyJar });
            Areas[1].AddItem(new List<Item> { goldenRose, thornShield });
            Areas[1].AddItem(new List<Item> { mysticFlower, thornShield });

            Areas[2].AddItem(new List<Item> { wispLantern });
            Areas[2].AddItem(new List<Item> { lunarGlass });
            Areas[2].AddItem(new List<Item> { roseBouquet });
            Areas[2].AddItem(new List<Item> { twilightDew, moonlightVial });
            Areas[2].AddItem(new List<Item> { lunarNectar, moonlightVial });

            Areas[3].AddItem(new List<Item> { mossyStone });
            Areas[3].AddItem(new List<Item> { glimmeringPearl });
            Areas[3].AddItem(new List<Item> { crystalPetal });
            Areas[3].AddItem(new List<Item> { potentWater, crystalWaterContainer });
            Areas[3].AddItem(new List<Item> { potentSand, celestialPendant });
            Areas[3].AddItem(new List<Item> { veilOfFog, mistCollector });

            Areas[4].AddItem(new List<Item> { obsidianBlade });
            Areas[4].AddItem(new List<Item> { enchantedStone });
            Areas[4].AddItem(new List<Item> { starDust });
            Areas[4].AddItem(new List<Item> { emeraldVine, thornShield });
            Areas[4].AddItem(new List<Item> { dragonScale, celestialPendant });
            Areas[4].AddItem(new List<Item> { spiritDust, fireflyJar });

            Plants = new List<Plant>
            {
            new Plant("Blood Rose"),
            new Plant("Sugarsap"),
            new Plant("Dragon Vines"),
            new Plant("Hollow Sage"),
            new Plant("Celestial Carnation")
            };

            Plants[0].AddRequirments(new List<Item> { potentSand, roseBouquet, sunSpot, solarLens, waterContainer });
            Plants[1].AddRequirments(new List<Item> { willowBark, forestEssence });
            Plants[2].AddRequirments(new List<Item> { dewdrop, elderOakBark, mossyStone, thornShield, rootCollectorTool });
            Plants[3].AddRequirments(new List<Item> { mysticFlower, rareSeed, spiritDust });
            Plants[4].AddRequirments(new List<Item> { lunarNectar, twilightDew, emeraldVine, goldenSeed, glimmeringPearl, lostSoul });


            Plants[0].AddHarvestableItems(fadedPetal);
            Plants[1].AddHarvestableItems(fertilizer);
            Plants[2].AddHarvestableItems(dragonScale);
            Plants[3].AddHarvestableItems(dewdrop);
            Plants[4].AddHarvestableItems(celestialPendant);

            Flourishing = false;
        }
        public bool IsFlourishing()
        {
            int flourishingPlants = Plants.Count;
            foreach (Plant plant in Plants)
            {
                if (plant.IsFlourishing)
                {
                    flourishingPlants--;
                }
            }
            if (flourishingPlants == 0)
            {
                Flourishing = true;
            }
            return Flourishing;
        }
        public void FlourishingPlants()
        {
            List<Plant> flourished = new List<Plant>();
            foreach (Plant plant in Plants)
            {
                if (plant.IsFlourishing)
                {
                    flourished.Add(plant);
                }
            }
            foreach(Plant plant in flourished)
            {

                FlourishedPlants.Add(plant);
                Plants.Remove(plant);
            }
        }
        public List<string> returnLocations()
        {
            List<string> locationNames = new List<string>();
            foreach (Location location in Areas)
            {
                locationNames.Add(location.Name);
            }
            return locationNames;
        }
        public void CheckPlantRequirments(Plant plant, Player player)
        {
            Console.WriteLine($"\n{plant.Name} needs:");

            int requirmentAmount = plant.Requirments.Count;
            foreach (Item item in plant.Requirments)
            {
                if (player.Inventory.Contains(item))
                {
                    requirmentAmount--;
                    Console.WriteLine($"O - You have {item.Name}!");
                }
                else
                {
                    Console.WriteLine($"X - You still need {item.Name}. The spirits might be of use . . .");
                }
            }

            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }
    }
}