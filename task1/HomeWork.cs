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
			// домашка 4
			Title = "MyHomeWork";
			Printer.PrintHeader(3);
			int taskNumber;
			do
			{
				taskNumber = TaskHelper.GetTaskNumber(3);
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

            Complex complex1;
            complex1.re = 1;
			complex1.im = 1;

            Complex complex2;
            complex2.re = 2;
			complex2.im = 2;

			Complex result = complex1.Plus(complex2);
			WriteLine(result.ToStr);
			result = complex1.Multi(complex2);
			WriteLine(result.ToStr);
			result = complex2.Minus(complex1);
			WriteLine(result.ToStr);
			WriteLine("------class-------");
			
			Ccomplex c1 = new Ccomplex(1,1);
			Ccomplex c2 = new Ccomplex(2,2);
            Ccomplex res;
			string input;
			do
			{
				Write("Enter method (+,-,*) or [0] to exit: ");
				input = ReadLine();
				switch (input)
				{
					case "+": res = c1.Plus(c2); WriteLine(res.ToStr); break;
					case "-": res = c1.Minus(c2); WriteLine(res.ToStr); break;
					case "*": res = c1.Multiply(c2); WriteLine(res.ToStr); break;

				}
			}
			while (input != "0");
		}

		static void Task2()
		{
			var numbersList = new List<int>();
			int sum = 0;
            bool res;
			string input = "";
			while (input != "exit")
			{
				Write("Введите любое целое число, 'exit' для выхода: ");
				input = ReadLine();
				res = int.TryParse(input, out int num);
				if (num > 0 && num % 2 != 0) numbersList.Add(num);
			}

			if (numbersList.Count > 0) numbersList.ForEach(i => sum += i);
			string output;
			if (sum > 0) output = $"Сумма чисел равна {sum}\nЧисла: {string.Join(", ", numbersList)}";
			else output = "Не найдено подходящих чисел для операции.";
			WriteLine(output);
		}

		static void Task4()
		{
			bool res;
			int num;
			int denom;
			do
			{
				WriteLine("числитель: ");
				res = int.TryParse(ReadLine(), out num);
				if (!res) Write("еще раз ");

			}
			while (!res);
			do
			{
				WriteLine("знаменатель: ");
				res = int.TryParse(ReadLine(), out denom);
				if (!res || denom == 0) Write("еще раз ");

			}
			while (!res || denom == 0);

			Fraction x = new Fraction(num, denom);
			WriteLine("\nОперация ('+', '-', '*', '/'):");
			string oper = ReadLine();
			do
			{
				WriteLine("числитель: ");
				res = int.TryParse(ReadLine(), out num);
				if (!res) Write("еще раз ");

			}
			while (!res);
			do
			{
				WriteLine("знаменатель: ");
				res = int.TryParse(ReadLine(), out denom);
				if (!res || denom == 0) Write("еще раз ");

			}
			while (!res || denom == 0);

			Fraction y = new Fraction(num, denom);
			Fraction r;
			switch (oper)
            {
				case "+":
					r = x + y;
					WriteLine(r.Reduce().ToString());
					break;
				case "-":
					r = x - y;
					WriteLine(r.Reduce().ToString());
					break;
				case "*":
					r = x * y;
					WriteLine(r.Reduce().ToString());
					break;
				case "/":
					r = x / y;
					WriteLine(r.Reduce().ToString());
					break;
			}
			
		}

		static void Task6()
		{
			//DateTime startTime = DateTime.Now;
			Stopwatch startTime = Stopwatch.StartNew(); // это лучше
			int count = 0;
			for (int i = 1; i <= 1e9; i++)
            {
				if (i % TaskHelper.SumDigitsLinq(i) == 0) count++;
            }
			//DateTime endTime = DateTime.Now;
			//TimeSpan takenTime = endTime.Subtract(startTime);
			//double takenTimeInMs = takenTime.TotalMilliseconds;
			startTime.Stop();
			WriteLine($"Кол-во хороших чисел равно {count}, время выполнения {startTime.Elapsed}");
		}

		static void Task7()
        {
			WriteLine("");
			Printer.PrintNumbers(1, 10);
			WriteLine($"\n{TaskHelper.SumNumbers(1, 5)}");
			
		}
	}
}
