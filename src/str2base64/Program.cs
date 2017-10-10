using System;
using System.IO;
using System.Text;

namespace str2base64
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This tool converts the bytes of a UTF8 string to its base-64 representation.");

            Console.WriteLine("Enter/past string: ");
            var str = Console.ReadLine();
            //var str = String.Empty;
            //using (var inStream = new StreamReader(Console.OpenStandardInput()))
            //{
            //    while (true)
            //    {
            //        var key = Console.ReadKey(intercept: true);
            //        if (key.Key == ConsoleKey.Escape)
            //        {
            //            break;
            //        }
            //    }
            //    str = inStream.ReadToEnd();
            //}
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Result: ");
            Console.WriteLine(Convert.ToBase64String(Encoding.UTF8.GetBytes(str)));
            Console.ReadLine();
        }
    }
}
