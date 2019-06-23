using System;
using System.Linq;
using static System.Console;

namespace _005_Csharp_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Подсчитать количество слов во введенном предложении.

            WriteLine("1. exercise");
            WriteLine("Enter a staytment");
            string msg = ReadLine();
            char[] separ = new char[] { ' ', '.', ',', '!', ';', ':', '-' };
            string[] txt = msg.Split(separ, StringSplitOptions.RemoveEmptyEntries);
            WriteLine($"The statment has {txt.Length} words");

            //2. Пользователь вводит строку. Проверить, является ли эта строка палиндромом. Палиндромом называется строка,
            //которая одинаково читается слева направо и справа налево.

            WriteLine("2. exercise");
            WriteLine("Enter a statment");
            string _msg = ReadLine();
            char[] delims = ".,;:!?\n\xD\xA\" ".ToCharArray();
            string[] text = _msg.Split(delims, StringSplitOptions.RemoveEmptyEntries);
            string buf = "";
            foreach (string word in text)
                buf += word;
            char[] str = new char[buf.Length + 1];
            str = buf.ToCharArray();
            Array.Reverse(str);
            string rev = new string(str);
            if (buf==rev)
                WriteLine("It`s palindrome");
            else
                WriteLine("It`snt palindrome ");
        }
    }
}
