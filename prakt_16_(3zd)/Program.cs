using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_16__3zd_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            bool trues = true;
            int mas_razm=1;
            Console.WriteLine("Введите количество элементов массива");
            while (trues)
            {
                try
                {
                    mas_razm = Convert.ToInt32(Console.ReadLine());
                    trues = false;
                }
                catch
                {
                    trues = true;
                    Console.WriteLine("Количетсво элементов массива должно быть числом");
                }
            }
            while (mas_razm <= 0)
            {
                Console.WriteLine($"Введите число больше 0");
                mas_razm = Convert.ToInt32(Console.ReadLine());
            }
            double[] numbs = new double[mas_razm];
            for (int i = 0; i < numbs.Length; i++)
            {
                try
                {
                    Console.WriteLine("Введите " + (i + 1) + " элемент массива");
                    numbs[i] = (double.Parse(Console.ReadLine()));
                }
                catch (Exception)
                {
                    i--;
                    Console.WriteLine("Повторите попытку ввода");
                }
            }
            Console.WriteLine("Числа и их частота (число - частота):");
            Console.WriteLine("\n----------------------------------------------------- ");
            var numbFre = numbs
                .GroupBy(x => x)
                .Select(g => new { Number = g.Key, Count = g.Count() })
                .OrderBy(x => x.Number);
            foreach (var yach in numbFre)
            {
                Console.WriteLine($"{yach.Number} - {yach.Count}");
            }
            Console.WriteLine("\nЧисло Частота (старого массива): ");
            Console.WriteLine("\n----------------------------------------------------- ");
            var newArr = numbs
                .GroupBy(x => x)
                .Select(g => new { Number = g.Key, Count = g.Count() })
                .OrderBy(x => x.Number);
            foreach (var yach in newArr)
            {
                Console.WriteLine($"{yach.Number * yach.Count} - {yach.Count}");
            }
            Console.ReadKey();
        }
    }
}
