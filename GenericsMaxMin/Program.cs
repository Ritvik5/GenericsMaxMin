namespace GenericsMaxMin
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics!\n");

            // -- Maximum Integers using CompareTo

            int result = FindMaximum.FindMax(23, 25, 27);
            Console.WriteLine("Max Integer is: " + result);

            // -- Maximum Float using CompareTo

            float result1 = FindMaximum.FindMaxFloat(22.4f, 23.4f, 21.5F);
            Console.WriteLine("Max Float is: " + result1);
        }
    }
}