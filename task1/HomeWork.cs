using System;
using static System.Console;
using taskHelper_lib;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace homeWorks
{
    internal class HomeWork
	{
		static void Main()
		{
			// домашка 6
			Title = "MyHomeWork";
			Printer.PrintHeader(5);
			int taskNumber;
			do
			{
				taskNumber = TaskHelper.GetTaskNumber(2);
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
			WriteLine("Таблица функции MyFunc1:");
			Table(new Fun1(MyFunc), -2, 2);
			WriteLine("Таблица функции MyFunc2:");
			Table(new Fun1(MyFunc2), -2, 2);
		}

		static void Task2()
		{
			
		}

		static void Task3()
		{

		}

		static void Task4()
		{
			
		}

		static void Task5()
		{
			
		}

		static void Task6()
		{
			
		}

		static void Task7()
        {
			
			
		}

		public delegate double Fun(double x);
		public delegate double Fun1(double a, double x);
		
		public static void Table(Fun1 F, double x, double b)
		{
			Console.WriteLine("----- X ----- Y -----");
			while (x <= b)
			{
				Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x,b));
				x += 1;
			}
			Console.WriteLine("---------------------");
		}
		// Создаем метод для передачи его в качестве параметра в Table
		public static double MyFunc(double a, double x)
		{
			return a * x * x;
		}
		public static double MyFunc2(double a, double x)
		{
			return a * Math.Sin(x);
		}

	}
}
