using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs_and_enums_001
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook("new model", "Made in Chine", 5);
            notebook.Info();
            Console.ReadKey();
        }
    }
    struct Notebook
    {
        private string model;
        private string creator;
        private decimal price;
        public Notebook(string model, string creator, decimal price)
        {
            this.model = model;
            this.creator = creator;
            this.price = price;
        }
        public void Info() => Console.WriteLine($"model - {model}, creator - {creator}, price - {price}$");
    }
}
