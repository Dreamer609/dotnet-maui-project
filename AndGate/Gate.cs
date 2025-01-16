using System;
using System.IO;

namespace AndGate
{
    public class AndLogicGate
    {
        private int input1;
        private int input2;
        private string ImagePath;  // This should be consistent with the constructor parameter

        // Public constructor to allow instantiation from outside
        public AndLogicGate(int input1, int input2, string ImagePath)
        {
            this.input1 = input1;
            this.input2 = input2;
            this.ImagePath = ImagePath;  // Assign the ImagePath parameter to the class field
            
            // Check inputs and image extension
            if (!validation()) // If validation fails, throw an exception
            {
                throw new ArgumentException("Error occurred: Invalid inputs or image format.");
            }
        }

        // Validation method for inputs and image format
        public bool validation()
        {
            // Validate inputs and image extension
            if (InputCheck(input1, input2) && resourceCheck() == ".png")
            {
                return true; // Valid inputs and image format
            }
            else
            {
                return false; // Invalid inputs or image format
            }
        }

        // Resource extension check
        private string resourceCheck()
        {
            string imageExtensionCheck = Path.GetExtension(ImagePath).ToLower();
            return imageExtensionCheck;
        }

        // Input validation check
        private static bool InputCheck(int input1, int input2)
        {
            // Return true if inputs are valid (0 or 1), false otherwise
            return (input1 == 0 || input1 == 1) && (input2 == 0 || input2 == 1);
        }

        // Logic gate method
        public int LogicGate()
        {
            // Perform AND operation
            int result = this.input1 * this.input2; 
            return result;
        }
    }
}






