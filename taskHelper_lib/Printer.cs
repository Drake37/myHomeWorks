using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskHelper_lib
{
    public static class Printer
    {
        private const string STUDENT = "Ведерников Роман Сергеевич";
        public static void PrintHeader(int homeWorkNumber)
        {
            WriteLine($"Домашняя работа № {homeWorkNumber}.\nСтудент: {STUDENT}");
            WriteLine("--------------------------");
        }        

        public static void PrintFooter()
        {
            WriteLine("Завершение работы");
            TaskHelper.Pause(2);
        }

    }
    
}
