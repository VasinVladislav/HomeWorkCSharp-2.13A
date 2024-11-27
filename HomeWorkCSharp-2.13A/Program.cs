using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCSharp_2._13A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.13А. Даны два числа. Найти среднее арифметическое и среднее геометрическое их  модулей.
            Console.WriteLine("Программа для вычисления среднего арифметического и среднего геометрического числа по модулям двух чисел.");
            Console.Write("Введите первое число: ");
            double X = Convert.ToDouble(Console.ReadLine());
            double modX = Math.Abs(X);
            Console.Write("Введите второе число: ");
            double Y = Convert.ToDouble(Console.ReadLine());
            double modY = Math.Abs(Y);
            double A = (modX + modY) / 2;
            double G = Math.Sqrt(modX * modY);
            Console.WriteLine($"Модули чисел |{X}| и |{Y}| = {modX} и {modY} соответственно\nСреднее арифметическое по модулям = {A.ToString("#.##")}" +
                $"\nСреднее геометрическое по модулям = {G.ToString("#.##")}");
        }
    }
}
