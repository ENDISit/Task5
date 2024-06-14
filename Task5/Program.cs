using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string action;
            float num;
            float num2;
            Console.WriteLine("1:Сложение  2:Вычитание  3:Умножение  4:Деление");
            Console.Write("Введите номер операции:");
            action = Console.ReadLine();

            Console.WriteLine("Введите первое число: ");
            num = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            num2 = Convert.ToSingle(Console.ReadLine());

            switch (action)
            {
                case "1":
                    float result = num + num2;
                    Console.WriteLine($"Слоложение: {num} + {num2} = {result}");
                    break;
                case "2":
                    float result2 = num - num2;
                    Console.WriteLine($"Вычитание: {num} - {num2} = {result2}");
                    break;
                case "3":
                    float result3 = num * num2;
                    Console.WriteLine($"Умножение: {num} * {num2} = {result3}");
                    break;
                case "4":
                    float result4 = num / num2;
                    Console.WriteLine($"Деление: {num} : {num2} = {result4}");
                    break;
                    default:
                    Console.WriteLine("Ошибка");
                    break;
                
            }

            Console.ReadKey();
        }
    }
}
