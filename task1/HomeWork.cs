using System;
using static System.Console;
using taskHelper_lib;
using System.Collections.Generic;
using System.Diagnostics;

namespace homeWorks
{
    internal class HomeWork
	{
		private static double height;
		private static double weight;
				
		static void Main()
		{
			// домашка 2
			Title = "MyHomeWork";
			Printer.PrintHeader(2);
			int taskNumber;
			do
			{
				taskNumber = TaskHelper.GetTaskNumber(7);
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
					case 7:
						Task7();
						break;
				}
			}
			while (taskNumber != 0);
		}        

		static void Task1()
		{
			// some indian code without any validation
			Write("Введите первое число: ");
			int a = int.Parse(ReadLine());
			Write("Введите второе число: ");
			int b = int.Parse(ReadLine());
			Write("Введите третье число: ");
			int c = int.Parse(ReadLine());
			// case 1
			int x = Math.Min(a, b);
			WriteLine("Минимальное число: {0}", x < c ? x : c);
			// case 2
			WriteLine("Минимальное число: {0}", a < b ? a < c ? a : c : b < c ? b : c);
		}

		static void Task2()
		{
			Write("Введите целое число: ");
			var x = TaskHelper.SplitIntToDigits(int.Parse(ReadLine()));
			WriteLine($"Количество цифр = {x.Count}");
		}
						
		static void Task3()
		{
			// quick simle without validation
			var numbersList = new List<int>();
			int num = 1;
			int sum = 0;
			while(num > 0)
            {
				Write("Введите любое целое число, ноль для выхода: ");
				num = int.Parse(ReadLine());
				if (num > 0 && num % 2 != 0) numbersList.Add(num);
                
			}
			if (numbersList.Count > 0)
				foreach (int i in numbersList)
					sum += i;
			if (sum > 0) WriteLine($"Сумма чисел равна {sum}");
			
		}

		static void Task4()
		{
			int i = 3;
			string login;
			string password;
			while(i > 0)
            {
				Write("Введите логин: ");
				login = ReadLine();
				Write("Введите пароль: ");
				password = ReadLine();
				if (TaskHelper.SignIn(login, password))
				{
					WriteLine("Вы успешно залогинились.");
					break;
				}
				else
				{
					i--;
					WriteLine($"Неверные данные, попробуйте снова. Осталось попыток: {i}");
				}
            }

		}

		static void Task5()
		{
			string msg;
			weight = double.Parse(TaskHelper.AskUserAbout("Ваш вес, кг: "));
			height = double.Parse(TaskHelper.AskUserAbout("Ваш рост, м: "));
			double weightIndex = (double)(weight / Math.Pow(height, 2));
			double normalWeight = 18.5 * Math.Pow(height, 2);
			if (weightIndex < 18.5)
			{
				msg = $"Недостаточный вес, вам надо набрать {normalWeight - weight} кг";
			}
			else if (weightIndex > 18.5 && weightIndex < 26)
			{
				msg = "Все ОК";
			}
			else msg = $"Избыточный вес, вам надо похудеть на {weight - normalWeight} кг";

			WriteLine(msg);
		}

		static void Task6()
		{
			//DateTime startTime = DateTime.Now;
			Stopwatch startTime = Stopwatch.StartNew(); // это лучше
			int count = 0;
			for (int i = 1; i <= 2000000; i++)
            {
				if (i % TaskHelper.SumDigitsLinq(i) == 0) count++;
            }
			//DateTime endTime = DateTime.Now;
			//TimeSpan takenTime = endTime.Subtract(startTime);
			//double takenTimeInMs = takenTime.TotalMilliseconds;
			startTime.Stop();
			double takenTimeInMs = startTime.Elapsed.TotalMilliseconds;
			WriteLine($"Кол-во хороших чисел равно {count}, время выполнения {takenTimeInMs} мс");
		}

		static void Task7()
        {
			WriteLine("");
			Printer.PrintNumbers(1, 10);
			WriteLine($"\n{TaskHelper.SumNumbers(1, 5)}");
			
		}
	}
}
