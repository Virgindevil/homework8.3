using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            HashSet<int> numbers = new HashSet<int>();

            while (true)
            {
                try
                {
                    Console.Write("Введите число:");
                    int number = int.Parse(Console.ReadLine());
                    if (numbers.Contains(number))
                    {
                        Console.WriteLine("Число уже было введено.");
                    }
                    else
                    {
                        numbers.Add(number);
                        Console.WriteLine("Число успешно добавлено!");
                    }
                }
                catch (Exception)
                {
                    return;
                }
            }  
        }
    }
}
