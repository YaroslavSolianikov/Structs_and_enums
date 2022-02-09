using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs_and_enums_003
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass() { Change = "Field from class NOT changed" };
            MyStruct myStruct = new MyStruct() { Change = "Field from struct NOT changed" };

            Console.WriteLine(myClass.Change);
            Console.WriteLine(myStruct.Change);

            ClassTaker(myClass);
            StructTaker(myStruct);

            Console.WriteLine(myClass.Change);
            Console.WriteLine(myStruct.Change);
            Console.ReadKey();
        }
        static void ClassTaker(MyClass myClass)
        {
            myClass.Change = "Field from class changed";
        }
        static void StructTaker(MyStruct myStruct)
        {
            myStruct.Change = "Field from struct changed"; 
        }
    }
    class MyClass
    {
        public string Change { get; set; }
    }
    struct MyStruct
    {
        public string Change { get; set; }
    }
}
