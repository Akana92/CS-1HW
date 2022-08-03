using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Раскомментируйте методы нужных задач - Ыбыраев Канат 
            //У меня не всегда бывает время из-за работы, по этому не судите строго в будущем пожалуйста если не буду успевать)
            //Anketa();//метод задания #1
            //IMT(); //2 задание
            //Coordinate(); //метод задания #3
            //Variables(); //метод задания #4
            PrintProgram();
            
        }

        static void Anketa()
        {
            Console.WriteLine("Задание 1 - Анкета.");
            Console.WriteLine("Введите ваше имя: ");
            String name = Console.ReadLine();

            Console.WriteLine("Введите вашу фамилию: ");
            String surname = Console.ReadLine();

            Console.WriteLine("Введите ваш возраст: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите ваш рост: ");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите ваш вес: ");
            int weight = int.Parse(Console.ReadLine());

            String result1 = "Склейка -> Имя: " + name + " Фамилия: " + surname + " возраст: " + age + " рост: " + height + " вес: " + weight;
            String result3 = $"Со знаком $ -> Имя: {name} Фамилия: {surname} возраст: {age} рост: {height} вес: {weight}";

            Console.WriteLine(result1);
            Console.WriteLine("Форматирование -> Имя: {0} Фамилия: {1} возраст: {2} рост: {3} вес: {4}", name, surname, age, height, weight);
            Console.WriteLine(result3);
        }

        static void IMT()
        {
            Console.WriteLine("Введите ваш Рост в метрах");
            double Weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите ваш Вес");
            double Height = double.Parse(Console.ReadLine());

            double I = (Height / (Weight * Weight));

            Console.WriteLine("Ваш ИМТ равен: " + I + " (Не знаю че это за цифры, но воть)");
        }

        private static void Coordinate()
        {
            Console.WriteLine("Программа которая подсчитывает расстояние между точками с координатами:");
            Console.WriteLine("Введите координату x1:");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату y1:");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату x2:");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату y2:");
            double y2 = double.Parse(Console.ReadLine());

            double r;

            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine(string.Format("Результат равен: {0:F2}", r));
        }

        private static void Variables()
        {
            int first = 1;
            int second = 2;
            int third;

            Console.WriteLine("C тремя переменными");
            Console.WriteLine("Значения до");
            Console.WriteLine("Первая переменная " + first);
            Console.WriteLine("Вторая переменная " + second);

            Console.WriteLine("Значения после");
            third = first;
            first = second;
            second = third;
            Console.WriteLine("Первая переменная " + first);
            Console.WriteLine("Вторая переменная " + second);

            Console.WriteLine("C двумя переменными. Значения в данный момент first = 2, second = 1 после первой замены.");
            Console.WriteLine("Результат:");
            first = first + second;
            second = second - first;
            second = -second;
            first = first - second;
            Console.WriteLine("Первая переменная " + first);
            Console.WriteLine("Вторая переменная " + second);
        }

        static void PrintProgram()
        {
            Console.WriteLine("Введите имя");
            String name = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            String surname = Console.ReadLine();
            Console.WriteLine("Введите город в котором проживаете");
            String town = Console.ReadLine();

            Console.WriteLine("Введите координату х для вывода в консоли");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату y для вывода в консоли");
            int y = int.Parse(Console.ReadLine());

            Print("Вывод в центре: ", name, surname, town, 100, 100);
            Print("Вывод по вашим координатам: ", name, surname, town, x, y);
        }

        static void Print(String desc, String name, String surname, String town, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine($"{desc} {name} {surname} из {town}");
        }
    }
}
