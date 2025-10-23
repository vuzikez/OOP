using System.Text;
using System.Text.RegularExpressions;
using StrBuilderIPv4;

namespace StrBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StrBuilderIP strb = new StrBuilderIP();
            try
            {
                StringBuilder str = strb.CreateStr();
                var list = strb.SortIpv4(str);
                foreach (var s in list)
                {
                    if (s.Value.Count > 0)
                    {
                        Console.WriteLine(s.Key);
                        foreach (var ip in s.Value)
                            System.Console.WriteLine(ip + " ");
                        System.Console.WriteLine();
                    }
                }
            }
            catch
            {
                Console.WriteLine("String is null!");
            }
            Console.ReadLine();
        }

    }
}
