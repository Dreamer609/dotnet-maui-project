using System;
using System.Drawing; // For loading images (System.Drawing.Common package is required for cross-platform)

namespace LogicGateSimulator
{
    public class LogicGateSimulator
    {
        // Property to store the image resource (for visual representation of the gate)
        public Image GateImage { get; private set; }

        // Constructor to load an image from a given path
        public LogicGateSimulator(string imagePath)
        {
            LoadImage(imagePath);
        }

        // Function to load an image from the specified path
        private void LoadImage(string imagePath)
        {
            try
            {
                GateImage = Image.FromFile(imagePath);  // Load image
                Console.WriteLine("Image loaded successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading image: {ex.Message}");
            }
        }

        // AND Gate Logic
        public bool AndGate(bool input1, bool input2)
        {
            return input1 && input2;
        }

        // OR Gate Logic
        public bool OrGate(bool input1, bool input2)
        {
            return input1 || input2;
        }

        // NOT Gate Logic
        public bool NotGate(bool input)
        {
            return !input;
        }

        // Function to display the gate image
        public void DisplayGateImage()
        {
            if (GateImage != null)
            {
                // Assuming you have a method to display the image on the UI or a form
                Console.WriteLine("Displaying the gate image...");
                // Actual image display code would go here in a graphical environment.
                // For now, we just simulate with a message.
            }
            else
            {
                Console.WriteLine("No image loaded.");
            }
        }

        // Example: Multi-Gate Combination Function
        public bool AndOrCombination(bool input1, bool input2, bool input3)
        {
            bool andResult = AndGate(input1, input2);
            return OrGate(andResult, input3);
        }
    }
}
