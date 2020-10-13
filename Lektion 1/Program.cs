using System;

namespace LanguageBaciscs
{
    class Prorgram

    {
        static void swap(ref int x, ref int y)
        {
            int tmp = x;
            x = y;
            y = tmp;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            var a = 5;
            var b = 6;

            swap(ref a, ref b);
            Console.WriteLine($"a={a} and b = {b}");
        }
    }
}