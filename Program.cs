namespace TestNumber
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find the Max Num of 3 Variables Program ");
            float X = 5.0F;
            float Y = 18.3F;
            float Z = 10.1F;

            float val = FindMaximum<float>.MaxFloatNumber(X, Y, Z);
            Console.WriteLine("The greater num is " + val);
        }
    }
}
