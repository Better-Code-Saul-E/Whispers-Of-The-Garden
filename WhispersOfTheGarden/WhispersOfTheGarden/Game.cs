using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhispersOfTheGarden
{
    public class Game
    {
        Garden garden = new Garden("MoonShade Sanctuary");
        Player player;

        private string UserInput;
        private bool validInput = false;

        private int Index;
        private int OptionsAvailible;

        private void titleScreen()
        {
            setConsoleTitle("Welcome");
            Console.Clear();
            Console.WriteLine(@"  (`\ .-') /` ('-. .-.           .-')     _ (`-.    ('-.  _  .-')    .-')         
   `.( OO ),'( OO )  /          ( OO ).  ( (OO  ) _(  OO)( \( -O )  ( OO ).       
,--./  .--.  ,--. ,--.  ,-.-') (_)---\_)_.`     \(,------.,------. (_)---\_)      
|      |  |  |  | |  |  |  |OO)/    _ |(__...--'' |  .---'|   /`. '/    _ |       
|  |   |  |, |   .|  |  |  |  \\  :` `. |  /  | | |  |    |  /  | |\  :` `.       
|  |.'.|  |_)|       |  |  |(_/ '..`''.)|  |_.' |(|  '--. |  |_.' | '..`''.)      
|         |  |  .-.  | ,|  |_.'.-._)   \|  .___.' |  .--' |  .  '.'.-._)   \      
|   ,'.   |  |  | |  |(_|  |   \       /|  |      |  `---.|  |\  \ \       /      
'--'   '--'  `--' `--'  `--'    `-----' `--'      `------'`--' '--' `-----'       
                               .-') _    ('-. .-.   ('-.                          
                              (  OO) )  ( OO )  / _(  OO)                         
 .-'),-----.    ,------.      /     '._ ,--. ,--.(,------.                        
( OO'  .-.  '('-| _.---'      |'--...__)|  | |  | |  .---'                        
/   |  | |  |(OO|(_\          '--.  .--'|   .|  | |  |                            
\_) |  |\|  |/  |  '--.          |  |   |       |(|  '--.                         
  \ |  | |  |\_)|  .--'          |  |   |  .-.  | |  .--'                         
   `'  '-'  '  \|  |_)           |  |   |  | |  | |  `---.                        
     `-----'    `--'             `--'   `--' `--' `------'                        
               ('-.     _  .-')  _ .-') _     ('-.       .-') _                   
              ( OO ).-.( \( -O )( (  OO) )  _(  OO)     ( OO ) )                  
  ,----.      / . --. / ,------. \     .'_ (,------.,--./ ,--,'                   
 '  .-./-')   | \-.  \  |   /`. ',`'--..._) |  .---'|   \ |  |\                   
 |  |_( O- ).-'-'  |  | |  /  | ||  |  \  ' |  |    |    \|  | )                  
 |  | .--, \ \| |_.'  | |  |_.' ||  |   ' |(|  '--. |  .     |/                   
(|  | '. (_/  |  .-.  | |  .  '.'|  |   / : |  .--' |  |\    |                    
 |  '--'  |   |  | |  | |  |\  \ |  '--'  / |  `---.|  | \   |                    
  `------'    `--' `--' `--' '--'`-------'  `------'`--'  `--'  ");
            Console.WriteLine("\nPress Enter play");
            Console.ReadKey();
        }
        private void giveProlouge()
        {
            setConsoleTitle("Prolouge");
            Console.Clear();

            List<string> dialouge = new List<string>
            {
                $"Welcome to the {garden.Name}, {player.Name}.",
                "Our paths have crossed at last!",
                "Im a wizard, and I've spent many centuries mastering magic.",
                "This magic brings me those who are worthy of this challenge.",
                "Will you help me culitvate a flourishing garden?",
                "If you succeed, a reward beyond imagination awaits you...",
                "Listen to the spirits they will guide you in bringing life.",


            };
            foreach (string sentence in dialouge)
            {
                Console.Clear();
                if (dialouge[dialouge.Count - 1] == sentence)
                {
                    Console.WriteLine($@"

     *            '         *       *.              ''
            *          .       '            ,               .
                   *       '
           '   *                *      ,    *       *           '
*           '                   .*           '                   .
    {sentence}
            '       .       '           *       *       .   
            *       .    '
       ,           *            *           .       '   *
   *   '*               .
           *        '       .       '.          *       ,'  *   
                *               .'          .           '           '
    ,       .           *           .           ',          ,* ,
               *                '       *       .   .
                     **                 ',',                .   .   '
");
                }
                else
                {
                    Console.WriteLine($@"
                 ,
                /|
               /*|
              /.+| 
             /* .|
             |:+.:\
             /+.:*.\
            |:.*.:+|
           /+.---.Z\
         ,(((/o^o\))\     {sentence}
        (())) ' > ()))
        )(())(/~\))))(
       /((()'`))((()(\)
      /::)).&& (()))():\
     /:*::)'||.   /\+:::\
    /:::::( || \ / |:/:::)
    \:::+/-'L|, &  |::*:/
     |::(|_  _'   _\+::|
     |*::\ `-'   //,):/\
     |:::+| || 
");
                }
                Console.WriteLine(Environment.NewLine + "Press any key to Continue");
                Console.ReadKey();
            }

        }
        private void getPlayerName()
        {
            setConsoleTitle("Enter Name");
            Console.Clear();
            validInput = false;
            while (!validInput)
            {
                Console.WriteLine("\nWhat would you like to name your self?");
                UserInput = Console.ReadLine();

                if (UserInput.Length <= 2)
                {
                    Console.WriteLine("\nPlease enter a name longer than two charcters.");
                }
                else if (isString(UserInput))
                {
                    validInput = true;
                }
            }
            player = new Player(UserInput);
        }
        private void setUserInterface()
        {
            setConsoleTitle("Choose Theme");
            Index = 1;
            List<Colors> colors = new List<Colors>
            {
                new Colors(ColorsEnum.Black, ColorsEnum.White, "The Standard"),
                new Colors(ColorsEnum.Gray, ColorsEnum.DarkGreen, "Zen"),
                new Colors(ColorsEnum.DarkGray, ColorsEnum.Cyan, "Cyborg"),
                new Colors(ColorsEnum.DarkBlue, ColorsEnum.Yellow, "Banana Split"),
                new Colors(ColorsEnum.Red, ColorsEnum.White, "Modern Art"),
                new Colors(ColorsEnum.Blue, ColorsEnum.Green, "Under the Sea"),
                new Colors(ColorsEnum.DarkYellow, ColorsEnum.Magenta, "Berry Blaze"),
                new Colors(ColorsEnum.DarkMagenta, ColorsEnum.DarkCyan, "Northen Lights"),
                new Colors(ColorsEnum.DarkRed, ColorsEnum.Black, "Halloween"),
            };
            foreach (Colors color in colors)
            {
                Index = color.ListColors(Index);
                Index++;
            }
            OptionsAvailible = colors.Count;
            Console.WriteLine("Choose your preferred color theme:");
            UserInput = getValidOption(OptionsAvailible, 1);

            colors[Convert.ToInt32(UserInput) - 1].ApplyColors();
        }
        private void setConsoleTitle(string title)
        {
            Console.Title = title;
        }
        private void endGame()
        {

            setConsoleTitle("Wizards Home");
            Console.WriteLine($@"
                 ,
                /|
               /*|
              /.+| 
             /* .|
             |:+.:\
             /+.:*.\
            |:.*.:+|
           /+.---.Z\
         ,(((/O^O\))\     {"I sensed your success, thank you. Your reward, you wonder? It's letting you live!!!"}
        (())) ' > ()))
        )(())(/~\))))(
       /((()'`))((()(\)
      /::)).&& (()))():\
     /:*::)'||.   /\+:::\
    /:::::( || \ / |:/:::)
    \:::+/-'L|, &  |::*:/
     |::(|_  _'   _\+::|
     |*::\ `-'   //,):/\
     |:::+| || 
");
            Console.WriteLine("Press any key to run");
            Console.ReadKey();
        }
        public void Start()
        {
            setUserInterface();
            titleScreen();
            getPlayerName();
            giveProlouge();
            while (!garden.IsFlourishing())
            {
                setConsoleTitle("Wizards Home");
                Console.Clear();
                Console.WriteLine(@"
                                   /\
                              /\  //\\
                       /\    //\\///\\\        /\
                      //\\  ///\////\\\\  /\  //\\
         /\          /  ^ \/^ ^/^  ^  ^ \/^ \/  ^ \
        / ^\    /\  / ^   /  ^/ ^ ^ ^   ^\ ^/  ^^  \
       /^   \  / ^\/ ^ ^   ^ / ^  ^    ^  \/ ^   ^  \       *
      /  ^ ^ \/^  ^\ ^ ^ ^   ^  ^   ^   ____  ^   ^  \     /|\
     / ^ ^  ^ \ ^  _\___________________|  |_____^ ^  \   /||o\
    / ^^  ^ ^ ^\  /______________________________\ ^ ^ \ /|o|||\
   /  ^  ^^ ^ ^  /________________________________\  ^  /|||||o|\
  /^ ^  ^ ^^  ^    ||___|___||||||||||||___|__|||      /||o||||||\
 / ^   ^   ^    ^  ||___|___||||||||||||___|__|||          | |
/ ^ ^ ^  ^  ^  ^   ||||||||||||||||||||||||||||||oooooooooo| |ooooooo
ooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo");

                Console.WriteLine(Environment.NewLine + $"What would you like to do {player.Name}?");
                displayMenu();

                UserInput = getValidOption(OptionsAvailible, 1);
                switch (Convert.ToInt16(UserInput))
                {
                    case 1:
                        locationsMenu();
                        break;
                    case 2:
                        enterGreenhouse();
                        break;
                    case 3:
                        player.DisplayInventory();
                        break;
                    case 4:
                        break;

                }
                garden.IsFlourishing();
            }
            Console.Clear();
            endGame();
            Console.ReadKey();
        }
        private void locationsMenu()
        {
            List<string> locationMenu = garden.returnLocations();
            locationMenu.Add("Back to Menu");

            bool travel = true;
            while (travel)
            {
                Console.Clear();
                Console.WriteLine(@"
    .                  .-.    .  _   *     _   .
           *          /   \     ((       _/ \       *    .
         _    .   .--'\/\_ \     `      /    \  *    ___
     *  / \_    _/ ^      \/\'__        /\/\  /\  __/   \ *
       /    \  /    .'   _/  /  \  *' /    \/  \/ .`'\_/\   .
  .   /\/\  /\/ :' __  ^/  ^/    `--./.'  ^  `-.\ _    _:\ _
     /    \/  \  _/  \-' __/.' ^ _   \_   .'\   _/ \ .  __/ \
   /\  .-   `. \/     \ / -.   _/ \ -. `_/   \ /    `._/  ^  \
  /  `-.__ ^   / .-'.--'    . /    `--./ .-'  `-.  `-. `.  -  `.
@/        `.  / /      `-.   /  .-'   / .   .'   \    \  \  .-  \%
@&8@%@@@%% @)&@&(88&@.-_=_-=_-=_-=_-=_.8@% &@&&8(8%@%8)(8@%8 8%@)%
@88:::&(&8&&8:::::%&`.~-_~~-~~_~-~_~-~~=.'@(&%::::%@8&8)::&#@8::::
`::::::8%@@%:::::@%&8:`.=~~-.~~-.~~=..~'8::::::::&@8:::::&8:::::'
 `::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::.'");
                Index = 1;
                OptionsAvailible = locationMenu.Count;

                Console.WriteLine("\nWhat location would you like to visit?");
                foreach (string option in locationMenu)
                {
                    Console.WriteLine($"{Index} - {option}");
                    Index++;
                }

                UserInput = getValidOption(OptionsAvailible, 1);

                if (Convert.ToInt32(UserInput) == OptionsAvailible)
                {
                    Console.WriteLine("Following the wind back to the Garden . . .");
                    Thread.Sleep(3000);
                    travel = false;
                }
                else
                {
                    Location location = garden.Areas[Convert.ToInt32(UserInput) - 1];

                    Console.WriteLine($"\nFollowing the trail to the {location.Name}. . .");
                    Thread.Sleep(3000);

                    locationSubMenu(location);
                }
            }
        }
        private void enterGreenhouse()
        {
            List<string> plantOptions = new List<string>
            {
                "Check Plant Requirments",
                "Fertilize",
                "Harvest",
                "Exit the Greenhouse"
            };


            Console.WriteLine("\nMaking your way into the Greenhouse . . .");
            Thread.Sleep(2000);

            bool stay = true;
            while (stay)
            {
                setConsoleTitle(garden.Name);
                OptionsAvailible = plantOptions.Count;
                Console.Clear();
                Index = 1;

                Console.WriteLine($"\nYou're in the Greenhouse what will you do?");
                foreach (String option in plantOptions)
                {
                    Console.WriteLine($"{Index} - {option}");
                    Index++;
                }

                UserInput = getValidOption(OptionsAvailible, 1);

                if (Convert.ToInt32(UserInput) == OptionsAvailible)
                {
                    Console.WriteLine("\nLeaving the Greenhouse");
                    Thread.Sleep(2000);
                    stay = false;
                }
                else
                {
                    switch (UserInput)
                    {
                        case "1":
                            checkPlantRequirments();
                            break;
                        case "2":
                            fertilize();
                            break;
                        case "3":
                            harvest();
                            break;
                        case "4":
                            stay = false;
                            break;
                    }
                }
            }
        }
        private void checkPlantRequirments()
        {
            bool check = true;
            while (check)
            {
                setConsoleTitle("Checking Plants");
                Console.Clear();
                List<string> plantsMenu = new List<string>();
                foreach (Plant plant in garden.Plants)
                {
                    plantsMenu.Add(plant.Name);
                }
                plantsMenu.Add("Back to Options");

                OptionsAvailible = plantsMenu.Count;
                Index = 1;

                Console.WriteLine("\nWhich plant are you checking out?");
                foreach (string option in plantsMenu)
                {
                    Console.WriteLine($"{Index} - {option}");
                    Index++;
                }

                UserInput = getValidOption(OptionsAvailible, 1);
                if (Convert.ToInt32(UserInput) == OptionsAvailible)
                {
                    check = false;
                }
                else
                {
                    garden.CheckPlantRequirments(garden.Plants[Convert.ToInt32(UserInput) - 1], player);
                }
            }
        }
        private void fertilize()
        {
            bool fertilize = true;
            while (fertilize)
            {
                setConsoleTitle("Fertilizing");
                Console.Clear();
                List<string> plantsMenu = new List<string>();
                foreach (Plant plant in garden.Plants)
                {
                    if (!plant.IsFlourishing)
                    {
                        plantsMenu.Add(plant.Name);
                    }
                }
                plantsMenu.Add("Back to Options");

                OptionsAvailible = plantsMenu.Count;
                Index = 1;

                Console.WriteLine("\nWhich plant will you feed?");
                foreach (string option in plantsMenu)
                {
                    Console.WriteLine($"{Index} - {option}");
                    Index++;
                }

                UserInput = getValidOption(OptionsAvailible, 1);
                if (Convert.ToInt32(UserInput) == OptionsAvailible)
                {
                    fertilize = false;
                }
                else
                {
                    bool flourish = player.Fertilize(garden.Plants[Convert.ToInt32(UserInput) - 1]);
                    if (flourish)
                    {
                        garden.FlourishingPlants();
                    }
                }
            }
        }
        private void harvest()
        {
            bool harvest = true;
            while (harvest)
            {
                setConsoleTitle("Harvesting");
                Console.Clear();
                List<string> flourishedPlants = new List<string>();
                foreach (Plant plant in garden.FlourishedPlants)
                {
                    flourishedPlants.Add(plant.Name);
                }
                flourishedPlants.Add("Back to Options");

                OptionsAvailible = flourishedPlants.Count;
                Index = 1;
                Console.WriteLine("\nWhich plant will you try to harvest from?");
                foreach (string option in flourishedPlants)
                {
                    Console.WriteLine($"{Index} - {option}");
                    Index++;
                }

                UserInput = getValidOption(OptionsAvailible, 1);
                if (Convert.ToInt32(UserInput) == OptionsAvailible)
                {
                    harvest = false;
                }
                else
                {
                    player.Harvest(garden.FlourishedPlants[Convert.ToInt32(UserInput) - 1]);
                }
            }
        }
        private void displayMenu()
        {
            List<String> menu = new List<String>
            {
                "Visit a location",
                "Tend to Plants",
                "Check Inventory",
            };

            Index = 1;
            OptionsAvailible = menu.Count;

            foreach (String option in menu)
            {
                Console.WriteLine($"{Index} - {option}");
                Index++;
            }
        }
        private void locationSubMenu(Location location)
        {
            List<String> visitLocationSubMenu = new List<String>
            {
                "Explore",
                "Talk to Spirit",
                "Turn in or use Item",
                "exit area"
            };

            bool stay = true;

            while (stay)
            {
                setConsoleTitle(location.Name);
                Console.Clear();

                Index = 1;
                OptionsAvailible = visitLocationSubMenu.Count;

                Console.WriteLine($"\nYou're at {location.Name}. What action would you like to take?");
                foreach (String option in visitLocationSubMenu)
                {
                    Console.WriteLine($"{Index} - {option}");
                    Index++;
                }

                UserInput = getValidOption(OptionsAvailible, 1);

                if (Convert.ToInt32(UserInput) == OptionsAvailible)
                {
                    Console.WriteLine("Going back up the trail . . .");
                    Thread.Sleep(3000);
                    stay = false;
                }
                else
                {
                    switch (UserInput)
                    {
                        case "1":
                            location.Explore();
                            break;
                        case "2":
                            talkToASpirit(location);
                            break;
                        case "3":
                            collectOrTurnIn(location);
                            break;
                        case "4":
                            stay = false;
                            break;
                    }
                }
            }
        }
        private void collectOrTurnIn(Location location)
        {
            List<String> list = new List<String>
            {
               "Collect Items",
               "Solve a spirits puzzle",
               "Back to options"
            };

            bool decide = true;
            while (decide)
            {
                setConsoleTitle("Deciding");
                Console.Clear();
                Index = 1;
                OptionsAvailible = list.Count;
                Console.WriteLine("\nwhich are you doing?");
                foreach (String option in list)
                {
                    Console.WriteLine($"{Index} - {option}");
                    Index++;
                }

                UserInput = getValidOption(OptionsAvailible, 1);

                switch (UserInput)
                {
                    case "1":
                        collectItems(location);
                        break;
                    case "2":
                        turnInItem(location);
                        break;
                    case "3":
                        decide = false;
                        break;
                }
            }
        }
        private void turnInItem(Location location)
        {
            bool turnIn = true;
            while (turnIn)
            {
                setConsoleTitle("Turning In");
                Console.Clear();
                List<String> spiritsMenu = new List<String>();
                foreach (Spirit Spirit in location.Spirits)
                {
                    spiritsMenu.Add(Spirit.Name);
                }
                spiritsMenu.Add("Back");

                Index = 1;
                OptionsAvailible = spiritsMenu.Count;

                Console.WriteLine("\nWhat spirit do you wish to approach?");
                foreach (string option in spiritsMenu)
                {
                    Console.WriteLine($"{Index} - {option}");
                    Index++;
                }

                UserInput = getValidOption(OptionsAvailible, 1);

                if (Convert.ToInt32(UserInput) == OptionsAvailible)
                {
                    Console.WriteLine("I see eyes watching from a distance.");
                    Thread.Sleep(1000);
                    turnIn = false;
                }
                else
                {
                    bool hasItem = location.Spirits[Convert.ToInt32(UserInput) - 1].TurnInItem(player);
                    if (hasItem)
                    {
                        location.Spirits.RemoveAt(Convert.ToInt32(UserInput) - 1);
                    }
                }
            }
        }
        private void talkToASpirit(Location location)
        {
            List<String> spiritsMenu = new List<String>();
            foreach (Spirit Spirit in location.Spirits)
            {
                spiritsMenu.Add(Spirit.Name);
            }
            spiritsMenu.Add("Return to options");

            bool talk = true;
            while (talk)
            {

                setConsoleTitle("Talking");
                Console.Clear();
                Index = 1;
                OptionsAvailible = spiritsMenu.Count;

                Console.WriteLine("\nWhat spirit would you like to talk to");
                foreach (string option in spiritsMenu)
                {
                    Console.WriteLine($"{Index} - {option}");
                    Index++;
                }
                UserInput = getValidOption(OptionsAvailible, 1);

                if (Convert.ToInt32(UserInput) == OptionsAvailible)
                {
                    if (spiritsMenu.Count == 1)
                    {
                        Console.WriteLine("\nSomething stares but it's not the spirits.");
                        Thread.Sleep(4000);
                    }
                    else
                    {
                        Console.WriteLine("\nAs you walk away the spirits stare . . .");
                    Thread.Sleep(2000);
                    }
                    talk = false;
                }
                else
                {
                    location.Spirits[Convert.ToInt32(UserInput) - 1].Interact();
                }
            }
        }
        private void collectItems(Location location)
        {
            bool turnIn = true;
            while (turnIn)
            {
                setConsoleTitle("Collecting");
                Console.Clear();
                List<string> itemsMenu = new List<string>();
                foreach (List<Item> item in location.Items)
                {
                    itemsMenu.Add(item[0].Name);
                }
                itemsMenu.Add("Back");

                Index = 1;
                OptionsAvailible = itemsMenu.Count;

                Console.WriteLine("\nWhat are you trying to collect?");
                foreach (string option in itemsMenu)
                {
                    Console.WriteLine($"{Index} - {option}");
                    Index++;
                }

                UserInput = getValidOption(OptionsAvailible, 1);
                if (Convert.ToInt32(UserInput) == OptionsAvailible)
                {
                    Console.WriteLine("\nSome items can be collected without tools . . .");
                    Thread.Sleep(2000);
                    turnIn = false;
                }
                else
                {
                    player.Interact(location, Convert.ToInt32(UserInput) - 1);
                }
            }
        }
        private string getValidOption(int max, int min = 0)
        {
            int optionPicked = 0;
            validInput = false;

            while (!validInput)
            {
                Console.WriteLine($"\nEnter a number between {min} and {max}:");
                UserInput = Console.ReadLine();
                UserInput = UserInput.Trim();

                if (int.TryParse(UserInput, out optionPicked) && isNumber(UserInput))
                {
                    if (optionPicked <= max && optionPicked >= min)
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine($"Pick a number between the range {min} and {max}!");
                    }
                }
                else
                {
                    Console.WriteLine("That's not a valid option. Please enter a number!");
                }
            }
            return UserInput;
        }
        private bool isNumber(string input)
        {
            foreach (Char letter in input)
            {
                if (!char.IsNumber(letter))
                {
                    return false;
                }
            }
            return true;
        }
        private bool isString(string input)
        {
            foreach (Char letter in input)
            {
                if (!char.IsLetter(letter) && !char.IsWhiteSpace(letter))
                {
                    Console.WriteLine("\nNames should only contain letters or spaces. Please try again!!!");
                    return false;
                }
            }
            return true;
        }
    }
}
