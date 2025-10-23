using System;

namespace StringApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите строку: ");
                string? str = Console.ReadLine();
                var (count, symbols) = GetDiffSymbols(str);
                Console.WriteLine(count);
                foreach (char c in symbols)
                    Console.Write(c);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
