using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs_and_enums_002
{
    class Program
    {
        static void Main(string[] args)
        {
            Train[] trains = new Train[5];
            for (int i = 0; i < trains.Length; i++)
            {
                trains[i] = new Train();
                Console.WriteLine("Enter the destination");
                trains[i].Destination = Console.ReadLine();
                Console.WriteLine("Enter the number of train");
                trains[i].Number = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Departure time ");
                trains[i].DepTime = Console.ReadLine();
            }
            Console.WriteLine();
            foreach (var item in trains)
            {
                Console.WriteLine($"{item.Number} - {item.Destination} - {item.DepTime}");
            }
            Console.WriteLine("Enter number of your train");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < trains.Length; i++)
            {
                if (trains[i].Number==num)
                {
                    Console.WriteLine($"{trains[i].Number} - {trains[i].Destination} - {trains[i].DepTime}");
                }
            }
            Console.ReadLine();
        }
    }
    struct Train
    {
        public string Destination { get; set; }
        public int Number { get; set; }
        public string DepTime { get; set; }
    }
}
