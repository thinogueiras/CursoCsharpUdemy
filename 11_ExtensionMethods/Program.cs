using System;

namespace ExtensionMethods
{
    public class Program
    {
        public static void Main()
        {
            var dt = new DateTime(2021, 03, 03, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            var s1 = "\nGood morning dear students!";
            Console.WriteLine(s1.Cut(10));

            Console.ReadLine();
        }
    }
}
