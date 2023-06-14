namespace GenericsMaxMin
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics!\n");

            int result = FindMaximum.FindMax(23, 25, 27);
            Console.WriteLine("Max Integer is:" + result);
        }
    }
}