using System.Text;
using System.Text.RegularExpressions;

namespace StrBuilderIPv4
{
    /// <summary>
    /// Предоставляет методы для работы с IPv4 адресами в строковом представлении
    /// </summary>
    public class StrBuilderIP
    {
        /// <summary>
        /// Сортирует IPv4 адреса по классам и возвращает словарь с отсортированными списками адресов для каждого класса
        /// </summary>
        /// <param name="str">StringBuilder содержащий текст с IPv4 адресами</param>
        /// <returns>Словарь, где ключ - класс IP-адреса (A, B, C, D, E, U), значение - отсортированный список адресов этого класса</returns>
        public Dictionary<char, List<string>> SortIpv4(StringBuilder str)
        {
            Dictionary<char, List<string>> result = new Dictionary<char, List<string>>
            {
                {'A', new List<string>()},
                {'B', new List<string>()},
                {'C', new List<string>()},
                {'D', new List<string>()},
                {'E', new List<string>() },
                {'U', new List<string>()}
            };
            string Ipv4Pattern = @"^(\d{1,3}\.){3}\d{1,3}$";
            string[] parts = str.ToString().Split();
            for (int i = 0; i < parts.Length; i++)
            {
                if (Regex.IsMatch(parts[i], Ipv4Pattern) && IsValid(parts[i]))
                {
                    result[GetIpClass(parts[i])].Add(parts[i]);
                }
            }
            foreach (var kvp in result)
            {
                kvp.Value.Sort();
            }
            return result;
        }

        /// <summary>
        /// Проверяет валидность IPv4 адреса
        /// </summary>
        /// <param name="str">Строка с IPv4 адресом для проверки</param>
        /// <returns>True если все октеты адреса находятся в диапазоне от 0 до 255, иначе False</returns>
        private bool IsValid(string str)
        {
            string[] parts = str.Split('.');
            foreach (string part in parts)
            {
                int number = int.Parse(part);
                if (number < 0 || number > 255)
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Создает StringBuilder из строки, введенной пользователем
        /// </summary>
        /// <returns>StringBuilder с введенной пользователем строкой</returns>
        /// <exception cref="Exception">Выбрасывается когда введена пустая строка или null</exception>
        public StringBuilder CreateStr()
        {
            Console.WriteLine("Введите строку с IPv4 адресом: ");
            string? str = Console.ReadLine();
            if (string.IsNullOrEmpty(str))
                throw new Exception("Строка не может быть пустой или null");
            return new StringBuilder(str);
        }

        /// <summary>
        /// Определяет класс IPv4 адреса
        /// </summary>
        /// <param name="ip">IPv4 адрес для классификации</param>
        /// <returns>
        /// Символ, обозначающий класс адреса:
        /// 'A' - класс A (1-126),
        /// 'B' - класс B (128-191), 
        /// 'C' - класс C (192-223),
        /// 'D' - класс D (224-239),
        /// 'E' - класс E (240-255),
        /// 'U' - неизвестный класс
        /// </returns>
        private char GetIpClass(string ip)
        {
            string[] parts = ip.Split('.');
            int first = int.Parse(parts[0]);

            if (first >= 1 && first <= 126) 
                return 'A';
            if (first >= 128 && first <= 191) 
                return 'B';
            if (first >= 192 && first <= 223) 
                return 'C';
            if (first >= 224 && first <= 239) 
                return 'D';
            if (first >= 240 && first <= 255) 
                return 'E';
            return 'U';
        }
    }
}