using System;
using static System.Console;
using taskHelper_lib;
using arrays_lib;
using System.Collections.Generic;
using System.Diagnostics;

namespace homeWorks
{
    internal class HomeWork
	{
		static void Main()
		{
			// домашка 4
			Title = "MyHomeWork";
			Printer.PrintHeader(4);
			int taskNumber;
			do
			{
				taskNumber = TaskHelper.GetTaskNumber(5);
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
			int[] ar = new int[20];
			Random r = new Random();
			for (int i = 0; i < 20; i++)
				ar[i] = r.Next(-10000, 10000);

			WriteLine(StaticClass.GetPairCount(ar));
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
	}
}
