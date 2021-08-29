using System;
using System.Threading;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region startPage
            for (int i = 1; i < 20; i++)
            {
                Console.WriteLine("############");
                Console.WriteLine("****");
                Thread.Sleep(40);
            }
            Console.Clear();
            #endregion
            #region 
            bool game = true;
            Console.WriteLine("Game Started");
            Console.WriteLine("Please type number");
            int number = Convert.ToInt32(Console.ReadLine());
            Random temp = new Random();
            int number2 = temp.Next(0, number);
            #endregion
            #region loop
            while (game == true)
            {
                Console.WriteLine("Guess?");
                Int32 guess = Convert.ToInt32(Console.ReadLine());


                if (guess < number2)
                {
                    Console.WriteLine("Too Lower");
                }
                else if (guess > number2)
                {
                    Console.WriteLine("Too Upper");
                }
                else
                {
                    Console.WriteLine("Well Done");
                    game = false;
                }
            }
            #endregion
        }
    }
}