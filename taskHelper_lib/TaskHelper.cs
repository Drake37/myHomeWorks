using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace taskHelper_lib
{
    public class TaskHelper
    {
        public static void Pause(int seconds)
        {
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(seconds));
        }

        public static int GetTaskNumber(int maxTaskNumber = 6)
        {
            Write($"\n" +
                $"==========================\n" +
                $"Введите номер задачи от 1 до {maxTaskNumber} для выполнения, 0 для выхода: ");
            
            //int taskNumber = Convert.ToInt32(input); // todo: почитать про конверт
            bool result;
            int taskNumber;

            do
            {
                result = int.TryParse(ReadLine(), out taskNumber);

                if (!result || taskNumber > maxTaskNumber || taskNumber < 0)
                    Write("Неверный номер задачи, повторите ввод: ");
                else break;
            }
            while (!result || taskNumber > maxTaskNumber || taskNumber < 0);
            return taskNumber;
        }
        public static string AskUserAbout(string question)
        {
            Write(question);
            return ReadLine();
        }
        /// <summary>
        /// Подсчет расстояния между двумя точками
        /// </summary>
        /// <returns>Расстояние</returns>
        public static double GetDistanceBetweenTwoDots()
        {
            Write("Введите координату X первой точки: ");
            double x1 = double.Parse(ReadLine());
            Write("Введите координату Y первой точки: ");
            double y1 = double.Parse(ReadLine());
            Write("Введите координату X второй точки: ");
            double x2 = double.Parse(ReadLine());
            Write("Введите координату Y второй точки: ");
            double y2 = double.Parse(ReadLine());

            return (double)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public static List<int> SplitIntToDigits(int i)
        {
            i = Math.Abs(i);
            var digits = new List<int>();
            while (i > 0)
            {
                int digit = i % 10;
                i /= 10;
                digits.Add(digit);
            }

            return digits;
        }

        public static bool SignIn(string login, string password)
        {
            if (login != "root" && password != "GeekBrains") return false;
            return true;
        }

        public static int SumDigitsLinq(int num)
        {
            return SplitIntToDigits(num).Sum();
        }

        public static int SumNumbers(int numFrom, int numTo)
        {
            if (numFrom <= numTo)
            {
                return numFrom += SumNumbers(++numFrom, numTo);
            }
            else return 0;
        }
    }
}
