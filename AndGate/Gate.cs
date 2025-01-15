namespace AndGate
{
    public class And_Gate
    {
        private double A;
        private double B;

        // Constructor to initialize A and B
        public And_Gate(double a, double b)
        {
            A = a;
            B = b;
        }

        // Method to add A and B
        public double Add()
        {
            return A + B;
        }

        // Method to multiply A and B
        public double Multiply()
        {
            return A * B;
        }
    }
}


