using System;
using static System.Console;
using taskHelper_lib;
using System.Collections.Generic;
using System.Diagnostics;

namespace homeWorks
{
    internal class HomeWork
	{
		static void Main()
		{
			// домашка 5
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
			// Так не работает норм, ибо кирилица тоже подходит
			//bool x = TaskHelper.IsCorrectLogin("ШГолыв54");
			//WriteLine(x);

			string login = "RomanV37";
			byte[] arBytes = new byte[192];
			int n = 0;
			for (int i = 0; i < 47; i++)
			{
				arBytes[n] = (byte)i;
				n++;
			}
			for (int i = 58; i < 64; i++)
			{
				arBytes[n] = (byte)i;
				n++;
			}
			for (int i = 91; i < 96; i++)
			{
				arBytes[n] = (byte)i;
				n++;
			}
			for (int i = 123; i < 255; i++)
			{
				arBytes[n] = (byte)i;
				n++;
			}

			char[] arChars = System.Text.Encoding.ASCII.GetChars(arBytes);
			bool f = false;
			for (int i = 0; i < login.Length; i++) {
				f = false;
				n = 0;
				foreach (var el in arChars)
				{
					if (login[i] == el) {
						f = true; n = 0;
						break;
					}
					else if( n == arChars.Length)
                    {
						f = false;
                    }

				}

			}
			
			

			if (login.Length >= 2 && login.Length <= 10 && Char.IsDigit((char)login[0]) == false && f == false)
				WriteLine("логин {0} корректен", login);
			else
				WriteLine("Логин не корректен");
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
