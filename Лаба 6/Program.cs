using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = "Классы StringBuilder и String предоставляют достаточную функциональность для работы со строками. Однако .NET предлагает еще один мощный инструмент - регулярные выражения." +
            //    " Регулярные выражения представляют эффективный и гибкий метод по обработке больших текстов, позволяя в то же время существенно уменьшить объемы кода по сравнению с использованием стандартных операций со строками." +
            //    "\r\n\r\nОсновная функциональность регулярных выражений в .NET сосредоточена в пространстве имен System.Text.RegularExpressions. А центральным классом при работе с регулярными выражениями является класс Regex." +
            //    " Например, у нас есть некоторый текст и нам надо найти в нем все словоформы какого-нибудь слова. С классом Regex это сделать очень просто:";
            //Regex regex = new Regex(@"пре(\w*)");
            //MatchCollection matches = regex.Matches(s);
            //if (matches.Count > 0)
            //{
            //    foreach (Match match in matches)
            //        Console.WriteLine(match.Value);

            //}
            //else
            //{
            //    Console.WriteLine("Совпадений не найдено");
            //}
            //Console.WriteLine(matches.Count);

            //string[] strings =
            //{
            //    "Также можно задать диапазон для алфавитных символов",
            //    "Можно также указать отдельные значения",
            //    "Нередко возникает задача проверить корректность данных",
            //    "Это может быть проверка электронного адреса",
            //    "Можно сделать"
            //};

            //for (int i = 0; i < strings.Length; i++)
            //{

            //    Regex regex = new Regex(@"^можно(\w*)");
            //    MatchCollection matches = regex.Matches(strings[i]);

            //    if (matches.Count > 0)
            //    {
            //        foreach (Match match in matches)
            //            Console.WriteLine(strings[i]);
            //    }
            //}


            //string[] strings =
            //{
            //    "Также можно задать диапазон для алфавитных символов",
            //    "Можно также указать отдельные значения",
            //    "Нередко возникает задача символов проверить корректность данных",
            //    "Это может быть проверка электронного адреса",
            //    "Можно сделать"
            //};

            //for (int i = 0; i < strings.Length; i++)
            //{
            //    Regex regex = new Regex(@"\w*символов$");
            //    MatchCollection matches = regex.Matches(strings[i]);

            //    if (matches.Count > 0)
            //    {
            //        foreach (Match match in matches)
            //            Console.WriteLine(strings[i]);
            //    }
            //}


            //string phoneNumber = "+1(876)-234-12-98";
            //string pattern = @"\D";
            //string target = "";
            //Regex regex = new Regex(pattern);
            //string result = regex.Replace(phoneNumber, target);
            //Console.WriteLine(result);

            //string phoneNumber = "+1(876      )-23   4-12    -98     ";
            //string pattern = @"\s";
            //string target = "";
            //Regex regex = new Regex(pattern);
            //string result = regex.Replace(phoneNumber, target);
            //Console.WriteLine(result);
        }
    }
}
