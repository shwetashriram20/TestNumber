namespace TestNumber
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find the Max Num of 3 Variables Program ");
            int X = 5;
            int Y = 23;
            int Z = 40;

            int obj = FindMaximum<int>.MaxOfString(X, Y, Z);
            Console.WriteLine("The greater Int Num is " + obj);

            float A = 2.5F;
            float B = 4.4F;
            float C = 8.5F;

            float val = FindMaximum<float>.MaxOfString(A, B, C);
            Console.WriteLine("The greater Float Num  is " + val);


            string H = "Apple";
            string I = "Peach";
            string J = "Banana";

            string val7 = FindMaximum<string>.MaxOfString(H, I, J);
            Console.WriteLine("The greater String is " + val7);
        }
    }
}

