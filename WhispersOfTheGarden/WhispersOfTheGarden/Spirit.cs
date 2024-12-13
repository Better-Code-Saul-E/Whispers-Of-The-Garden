using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WhispersOfTheGarden
{
    public class Spirit : Character
    {
        //public string Name { get; set; }
        public Puzzle Puzzle { get; set; }
        public string ThankYouMessage { get; set; }
        public string  Appearance { get; set; }
        
        public Spirit(string name, string riddle, string thankYouMessaage, string quest, Item toRecieve, Item ToTurnIn, string appearance) : base(name)
        {
            Name = name;
            ThankYouMessage = thankYouMessaage;
            Puzzle = new Puzzle(riddle, quest, toRecieve, ToTurnIn);
            Appearance = appearance;
        }

        public override void Interact()
        {
            Console.Clear();
            Console.WriteLine(Appearance);
            Console.WriteLine($"\n{Name}:");
            Console.WriteLine($"{Puzzle.Riddle}");
            Thread.Sleep(2000);
            Console.WriteLine($"\n{Puzzle.Quest}");

            Console.WriteLine("\nPress any key to walk away");
            Console.ReadKey();
        }
        public bool TurnInItem(Player player)
        {
            Console.Clear();
            bool hasItem = Puzzle.Solve(player);
            if (hasItem)
            {
 Console.WriteLine(Environment.NewLine + $@"
     *            '         *       *.              ''          *.          .       .,
            *          .       '            ,         .      .      *       .   '   .
                   *       '    .           ,       '               '      .    ,.
           '   *                *      ,    *       *           '   ,          .            '
*           '                   .*           '                   . * *          '       *
  {ThankYouMessage}
            '       .       '           *       *       .   '   ..'*        .       *
            *       .    '      '           '                               *               '
       ,           *            *           .       '   *       .   '               ,.
   *   '*               .
           *        '       .       '.          *       ,'  *           '  *       .        '
                *               .'          .           '           '   ,       '    .   .
    ,       .           *           .           ',          ,* ,    *   .   ,           *
               *                '       *       .   .               .           *
                     **                 ',',                .   .   '.          .   '");
            } 

            Console.WriteLine("\nPress any key to continue your journey");
            Console.ReadKey();
           
            return hasItem;
        }
    }
}