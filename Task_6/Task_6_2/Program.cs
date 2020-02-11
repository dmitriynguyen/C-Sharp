using System;

namespace Task_6_2
{
    class Program
    {
        static void Main()
        {
            var p = new Books("Potter", "Rouling", "" );
            var c = new Catalog();
            c["1234567891123"] = p;
            Console.WriteLine(c["123-4-56-789112-3"]);
            Console.ReadLine();
        }
    }
}
