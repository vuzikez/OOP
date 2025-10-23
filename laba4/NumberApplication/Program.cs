using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Text.RegularExpressions;
using NumStrLibrary;

namespace NumberApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<StringBuilder> list = new List<StringBuilder>();
            var lib = new StrNumLib();

            var stringBuilder = new StringBuilder();
            try
            {
                while (true)
                {
                    if (lib.CreateStringNum(stringBuilder))
                    {
                        list.Add(stringBuilder);
                        foreach (var item in list)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    Console.WriteLine("Введите строку: ");
                    string? str = Console.ReadLine();
                    var (count, symbols) = lib.GetDiffSymbolsStr(str);
                    Console.WriteLine(count);
                    foreach (char c in symbols)
                        Console.Write(c);
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
