using System;
using static System.Console;
using taskHelper_lib;
using arrays_lib;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

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

		}

		static void Task2()
		{
			int[] ar = new int[20];
			Random r = new Random();
			for (int i = 0; i < 20; i++)
			    ar[i] = r.Next(-10000, 10000);

			WriteLine(Arr.GetPairCount(ar));

            int[] ar2 = Arr.BuildArFromFile();
            for (int i = 0; i < ar2.Length; i++)
                WriteLine(ar2[i]);

        }

		static void Task3()
		{
			SimpleAr myAr = new SimpleAr(10, -4, 2);
			
			int[] inverseAr = myAr.Inverse();
			WriteLine(string.Join(" ", inverseAr));
			myAr.Print();

			//myAr.Multi(2);
			//myAr.Print();

			myAr[1] = 42;
			myAr[2] = 42;
			WriteLine(myAr.MaxCount);
			myAr.CountElements();
			myAr.PrintDic();
		
		}

		static void Task4()
		{
			string f = @"C:\Users\Drake\source\repos\homeWork01\task1\TextFile2.txt";
			Sauth x = new Sauth(f);
			int cnt = 4;
			string answer;
			while(--cnt > 0 && !x.IsDataValid())
            {
				WriteLine($"Invalid data, attempts left: {cnt}\nChange data and press [y]");
				answer = ReadLine();
				if (answer == "y") x.SetData(f);
				else break;
            }

		}

		static void Task5()
		{
			C2dArr c2DArr = new C2dArr(@"C:\Users\Drake\source\repos\homeWork01\arrays_lib\2dArr.txt");
			WriteLine(c2DArr.Ar[0, 0]);
			WriteLine(c2DArr.Ar[2, 4]);

			c2DArr.Log(c2DArr.Ar[0, 4].ToString(), @"C:\Users\Drake\source\repos\homeWork01\arrays_lib\log.txt");
		}

		static void Task6()
		{
		}

		static void Task7()
        {
		}
	}

	



}
