using System;

namespace Task2
{
    class Program
    {
        static bool IsPalindrom(string str)
        {
            if (str == null) throw new ArgumentNullException(str);
            str = str.ToLower().Replace(" ", string.Empty);
            return IsPalindromInternal(str);
        }

        static bool IsPalindromInternal(string str)
        {
            if (str.Length == 1 || string.IsNullOrEmpty(str)) return true;
            if (!str[0].Equals(str[str.Length - 1])) return false;
            return IsPalindromInternal(str.Substring(1, str.Length - 2));
        }

        static void Main(string[] args)
        {
            var str = "А розаупала на   лапу Азора";
            var str2 = "Лазер Боре хе* обрезал";

            Console.WriteLine(IsPalindrom(str));
            Console.WriteLine(IsPalindrom(str2));
            Console.ReadKey(true);
        }
    }
}
