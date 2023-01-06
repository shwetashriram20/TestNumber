namespace TestNumber
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find the Max Num of 3 Variables Program ");
            string X = "Apple";
            string Y = "Peach";
            string Z = "Banana";

            string val = FindMaximum<string>.MaxOfString(X, Y, Z);
            Console.WriteLine("The greater String is " + val);
        }
    }
}


