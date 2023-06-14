namespace GenericsMaxMin
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics!\n");

            // -- Maximum Integer using CompareTo

            //int result = FindMaximum.FindMax(23, 25, 27);
            //Console.WriteLine("Max Integer is: " + result);

            // -- Maximum Float using CompareTo

            //float result1 = FindMaximum.FindMaxFloat(22.4f, 23.4f, 21.5F);
            //Console.WriteLine("Max Float is: " + result1);

            // -- Maximum String using CompareTo

            //string result2 = FindMaximum.FindMaxString("Ankush", "Ankita", "Rahul");
            //Console.WriteLine("Max string is: " + result2);

            // -- Using Generics Type Parameter 

            //GenericsMaximum<int> obj = new GenericsMaximum<int>(23, 50, 5);

            //int result = obj.FindMaxUsingGenerics(23, 50, 5);

            //Console.WriteLine(result);
            //Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::");
            //Console.WriteLine("Greatest number among three numbers is :" + result);
            //Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::");

            //GenericsMaximum<float> obj1 = new GenericsMaximum<float>(23.25f, 50.25f, 50.3f);

            //float result2 = obj1.FindMaxUsingGenerics(23.25f, 50.25f, 50.3f);

            //Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::");
            //Console.WriteLine("Greatest number among three numbers is :" + result2);
            //Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::");

            //-- Generics methods with more than 3 parameteres

            GenericsMaximum<string> max = new GenericsMaximum<string>("Apple", "Peach", "Banana","Grapes");
            string maxString = max.GetMax();
            Console.WriteLine(maxString);

        }
    }
}