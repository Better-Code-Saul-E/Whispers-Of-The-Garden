using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhispersOfTheGarden
{
    public enum ColorsEnum
    {
        Black,
        DarkBlue,
        DarkGreen, 
        DarkCyan,
        DarkRed,
        DarkMagenta,
        DarkYellow,
        DarkGray,
        White,
        Blue,
        Green,
        Cyan,
        Red,
        Magenta,
        Yellow,
        Gray
    }
    public class Colors
    {
        public List<ColorsEnum> ColorPair = new List<ColorsEnum>();
        string CombinationName { get; set; }
   
        public Colors(ColorsEnum background, ColorsEnum foreground, string combinationName)
        {
            ColorPair.Add(background);
            ColorPair.Add(foreground);
            CombinationName = combinationName;
        }
        public void ApplyColors()
        {
            string color = Convert.ToString(ColorPair[0]);
            Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color, true);

            color = Convert.ToString(ColorPair[1]);
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color, true);
        }
        public int ListColors(int index)
        {
            ApplyColors();
            Console.WriteLine("-------------------");
            Console.WriteLine($" {index} {CombinationName,15} ");
            Console.WriteLine("-------------------");
            Console.ResetColor();

            return index++;
        }
    }
}