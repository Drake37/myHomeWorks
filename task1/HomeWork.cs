using System;
using static System.Console;
using taskHelper_lib;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork_1
{
    internal class HomeWork
    {
        private static string name;
        private static string surname;
        private static int age;
        private static int height;
        private static int weight;
        private static string city;
        
        static void Main()
        {
            Printer.PrintHeader(1);
            int taskNumber;
            do
            {
                taskNumber = TaskHelper.GetTaskNumber(6);
                switch (taskNumber)
                {
                    case 1:
                        Task1();
                        break;
                    case 0:
                        Printer.PrintFooter();
                        break;
                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
                        break;
                    case 4:
                        Task4();
                        break;
                    case 5:
                        Task5();
                        break;
                    case 6:
                        Task6();
                        break;
                }
            }
            while (taskNumber != 0);
        }        

        static void Task1()
        {
            name = TaskHelper.AskUserAbout("Ваше имя: ");
            surname = TaskHelper.AskUserAbout("Ваша фамилия: ");
            age = int.Parse(TaskHelper.AskUserAbout("Ваш возраст: "));
            height = int.Parse(TaskHelper.AskUserAbout("Ваш рост: "));
            weight = int.Parse(TaskHelper.AskUserAbout("Ваш вес: "));

            WriteLine("Ваши данные:");
            WriteLine("Имя: " + name + ", Фамилия: " + surname + ", Возраст: " + age +
                ", Рост: " + height + ", Вес: " + weight);
            WriteLine("Имя: {0}, Фамилия: {1}, Возраст: {2}, Рост: {3}, Вес: {4}", name, surname, age,
                height, weight);
            WriteLine($"Имя: {name}, Фамилия: {surname}, Возраст: {age}, Рост: {height}," +
                $" Вес: {weight}");
        }

        static void Task2()
        {
            weight = int.Parse(TaskHelper.AskUserAbout("Ваш вес, кг: "));
            height = int.Parse(TaskHelper.AskUserAbout("Ваш рост, м: "));
            WriteLine($"Индекс массы тела равен {weight / Math.Pow(height, 2)}");
        }
        
        static void Task3()
        {
            WriteLine("Расстояние равно {0:F2}", TaskHelper.GetDistanceBetweenTwoDots());
        }

        static void Task4()
        {
            WriteLine(
                "int x = 1;\n" +
                "int y = 2;\n" +
                "int z = x;\n" +
                "x = y; y = z;"
            );
            
            // without z
            WriteLine(
                "int x = 2;\n" +
                "int y = 4;\n" +
                "x += y;\n" +
                "y = x - y;\n" +
                "x -= y;"
            );
            int x = 2;
            int y = 4;
            x += y;
            y = x - y;
            x -= y;
            Write($"{x}, {y}");

        }

        static void Task5()
        {
            name = TaskHelper.AskUserAbout("Ваше имя: ");
            surname = TaskHelper.AskUserAbout("Ваша фамилия: ");
            city = TaskHelper.AskUserAbout("Ваш город: ");
            string text = $"{name} {surname}, г.{city}";
            int centerByX = (WindowWidth/2) - (text.Length / 2);
            int centerByY = (WindowHeight/2) - 1;
            SetCursorPosition(centerByX, centerByY);
            WriteLine(text);
        }
        static void Task6()
        {
            WriteLine("Пауза 3 сек");
            TaskHelper.Pause(3);
        }
    }
}
