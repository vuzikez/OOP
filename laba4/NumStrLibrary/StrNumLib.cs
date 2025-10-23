using System.Text;
using System.Text.RegularExpressions;

namespace NumStrLibrary
{
    public class StrNumLib
    {
        public bool CreateStringNum(StringBuilder str)
        {
            string patternTime = @"^([0-9]|1[0-9]|2[0-3])-([0-5][0-9])$";
            string patternNumber = @"^\+375(29|33|44|25)\d{7}$";
            Console.WriteLine("Введите номер телефона: ");
            string? number = Console.ReadLine();
            Console.WriteLine("Введите время звонка(формат чч-мм, не больше 23 часов и 59 минут): ");
            string? timeStamp = Console.ReadLine();
            Console.WriteLine("Введите время в минутах: ");
            string? timePeriod = Console.ReadLine();
            bool isSuccses = false;
            if (string.IsNullOrEmpty(number) || string.IsNullOrEmpty(timeStamp) || string.IsNullOrEmpty(timePeriod))
                throw new ArgumentNullException();
            if (Regex.IsMatch(timeStamp, patternTime) && Regex.IsMatch(number, patternNumber))
            {
                str.AppendFormat("{0}, {1}, {2}", number, timeStamp, timePeriod);
                isSuccses = true;
            }
            else
                Console.WriteLine("Формат времени должен быть чч-мм и номер телефона +375 и 9 цифр");
            return isSuccses;
        }

        public (int count, List<char> symbols) GetDiffSymbolsStr(string str)
        {
            if (str is null)
            {
                throw new Exception();
            }
            List<char> list = new List<char>();
            if (str.Length == 0)
                return (0, list);
            list.Add(str[0]);
            for (int i = 1; i < str.Length; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[j] != str[i])
                    {
                        if (list.Exists(c => c == str[i]))
                            break;
                        list.Add(str[i]);
                    }
                }

            }
            return (list.Count, list);
        }
    }
}
