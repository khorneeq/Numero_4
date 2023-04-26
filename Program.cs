namespace Numero_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = 199;
            Console.WriteLine(CloseEnough(x));
        }
        public static bool CloseEnough(int x)
        {
            return Math.Abs(100 - x) <= 10 || Math.Abs(200 - x) <= 100;
        }
    }
}