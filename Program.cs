namespace TestNumber
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find the Max Num of 3 Variables Program ");
            int X = 10;
            int Y = 30;
            int Z = 60;

            int val = FindMaximum<int>.MaxIntNumber(X, Y, Z);
            Console.WriteLine("The greater num is " + val);
        }
    }
    
}
