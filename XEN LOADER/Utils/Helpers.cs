using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XEN_LOADER.Utils
{
    internal class Helpers
    {
        public static void ConsoleExWriteLine(string Message)
        {
            Console.SetCursorPosition((Console.WindowWidth - Message.Length) / 2, Console.CursorTop);
            Console.WriteLine(Message);
        }

        public static void ConsoleExWrite(string Message)
        {
            Console.SetCursorPosition((Console.WindowWidth - Message.Length) / 2, Console.CursorTop);
            Console.Write(Message);
        }

        public static void ConsoleExSpace()
        {
            Console.WriteLine("");
        }

        public static Random random = new Random();

        public static string Generate(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
