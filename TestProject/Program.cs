using System;
using System.Collections.Generic;  // Required for List<T>
using AndGate;

namespace TestProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Provide the required inputs to the constructor
            int input1 = 1;  // Example input
            int input2 = 1;  // Example input
            string ImagePath = "./ImageResource/example.png";  // Example image file name

            // Create a list to store AndLogicGate objects
            List<AndLogicGate> AndGate = new List<AndLogicGate>();

            // Instantiate the AndLogicGate and add it to the list
            AndGate.Add(new AndLogicGate(input1, input2, ImagePath));

            // Now retrieve the added AndLogicGate instance and output relevant details
            foreach (var item in AndGate)
            {
                Console.WriteLine(item.validation());
            }
        }
    }
}




