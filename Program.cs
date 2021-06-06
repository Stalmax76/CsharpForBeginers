using System;

namespace ConsoleApp1
{
    class Program
    {
      /// <summary>
      /// Ветвления
      /// </summary>
      /// <param name="args"></param>
        static void Main(string[] args)
        {
            string str = "Hello Vasyl";
            foreach (var item in str)
            {
                Console.WriteLine(item);
            }
        }

    }
}
