using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Генератор_чисел
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //генератор случайных чиел
            Random c = new Random();
            int b = c.Next(1, 100);
            int a;
            Console.WriteLine("Введите загаданное число от 1 до 100 и введите Enter");

            a = Convert.ToInt32(Console.ReadLine());

            //условие - число которое загадал комп и число ввел пользователь равны
            while (a != b)
            {
                //тело цикла
                if (a > b)
                {
                    Console.WriteLine("Загаданное число меньше, попробуйте снова");
                    a = Convert.ToInt32(Console.ReadLine());
                }
                if (a < b)
                {
                    Console.WriteLine("Загаданное число больше, попробуйте снова");
                    a = Convert.ToInt32(Console.ReadLine());
                }
            }
            if (a == b)
            {
                Console.WriteLine("Поздравляем, в угадали число");
            }
        }
    }
}
