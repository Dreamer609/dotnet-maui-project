using System;
using AndGate;

namespace TestProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            And_Gate math = new And_Gate(5, 3);

            Console.WriteLine($"Sum: {math.Add()}");
            Console.WriteLine($"Product: {math.Multiply()}");
        }
    }

}


