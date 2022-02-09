using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs_and_enums_005
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Accauntant.AskForBonus(Workers.Junior,21));
            Console.WriteLine(Accauntant.AskForBonus(Workers.Middle, 24));
            Console.WriteLine(Accauntant.AskForBonus(Workers.Senior, 50));
            Console.WriteLine(Accauntant.AskForBonus(Workers.TeamLead, 50));
            Console.ReadKey();
        }
    }
}
