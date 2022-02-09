using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs_and_enums_004
{
    class Program
    {
        static void Main(string[] args)
        {
            MyColor.Print("string", (int)Color.Red);
            MyColor.Print("string", (int)Color.Yellow);
            MyColor.Print("string", (int)Color.Blue);
            Console.ReadKey();
        }
    }
}
