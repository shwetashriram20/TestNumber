namespace TestNumber
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find the Max Num of 3 Variables Program ");
            int num = FindMaximum<int>.MaxNumber(75, 30, 22);
            Console.WriteLine("The greater Integer number is : " + num);

        }
    }
}