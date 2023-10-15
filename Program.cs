namespace Curs6Prob2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul: ");
            bool canConvert = false;
            while (!canConvert)
            {
                canConvert = Int32.TryParse(Console.ReadLine(), out int numar);
                if (!canConvert)
                {
                    Console.WriteLine("Numarul nu este valid. Incercati din nou ");
                }
                else
                {

                    Console.WriteLine($"Primele {numar} numere din secventa Fibonacci sunt:");
                    for (int i = 0; i < numar; i++)
                    {
                        int fibonacciNumber = Fibonacci.FibonacciNumber(i);
                        Console.Write(fibonacciNumber + " ");
                    }
                }
            }
        }
    }
}