using System;
using static System.Console;
using taskHelper_lib;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Globalization;

namespace homeWorks
{
    public class HomeWork
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
			WriteLine("Таблица функции MyFunc:");
			Table(new Fun1(MyFunc), -2, 2);
			WriteLine("Таблица функции MyFunc2:");
			Table(new Fun1(MyFunc2), -2, 2);
		}

		static void Task2()
        {
			List<Func> functions = new List<Func> {
				new Func(Functions.Sqrt)
				, new Func(Functions.Cos)
				, new Func(Functions.Sin)
				, new Func(Functions.Sdeg)
			};

			WriteLine("Найти минимум функции");
			WriteLine("Выберите функцию:");
			WriteLine("1 -- f(x) = y^1/2 (кв корень)");
			WriteLine("2 -- f(x) = cos(y)");
			WriteLine("3 -- f(x) = sin(y)");
			WriteLine("4 -- f(x) = y^2 (квадрат)");
			int input = Functions.GetNum(functions.Count);

			WriteLine("Задайте интервал, формата 'х1 х2':");

			double startPoint = 0;
			double endPoint = 0;
			Functions.GetInterval(out startPoint, out endPoint);
			WriteLine("Задайте шаг: ");
			double step = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
			Functions.SaveFunc("data.bin", startPoint, endPoint, step, functions[input - 1]);
			double min = double.MaxValue;
			WriteLine("Значения функции: ");
			Functions.Print(startPoint, endPoint, step, Functions.Load("data.bin", out min));
			WriteLine("Мин. значение: {0:0.00}", min);
		}

		static void SandBox()
		{
			Car car = new Car();
			car.start();
			for (int i = 0; i < 10; i++)
			{
				car.Accelerate(Beep);
			}
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
		static void Beep(int speed)
        {
			WriteLine($"Too fast, speed = {speed}");
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

	public delegate void Alarm(int s);
	
	public class Car
    {
		
		int speed = 0;

        public void start()
        {
			speed = 10;
        }
		public void stop()
        {
			speed = 0;
        }
		public void Accelerate(Alarm alarm)
        {
			speed += 10;
			if (speed > 80) alarm(speed);
        }

    }

	
}
