namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(addition(2, 2));
            //Console.ReadKey();
        }
        static int addition(int numberOne, int numberTwo)
        {
            int sum = numberOne + numberTwo;
            return sum;
        }
    }
}
