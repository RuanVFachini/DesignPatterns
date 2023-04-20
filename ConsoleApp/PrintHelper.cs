using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class PrintHelper
    {
        public static void PrintPattern<T>() where T : IExample, new()
        {
            var example = new T();
            PrintLine(typeof(T).Name);
            Console.ForegroundColor = ConsoleColor.White;
            example.Run();
            Console.ForegroundColor = ConsoleColor.Green;
            PrintLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void PrintLine(string? title = "")
        {
            Console.ForegroundColor = ConsoleColor.Green;

            var chars = Console.WindowWidth;
            var line = new string('*', chars);

            if (!string.IsNullOrEmpty(title))
            {
                var middle = chars / 2;
                var prefixLegth = Convert.ToInt32(decimal.Floor(middle - (title.Length / 2)));
                var prefix = line[..prefixLegth];
                var sufixIndex = prefixLegth + title.Length;
                var sufix = line[sufixIndex..];

                line = prefix + title + sufix;
            }

            Console.WriteLine(line);
            Console.WriteLine();
        }
    }
}
