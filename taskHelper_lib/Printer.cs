using static System.Console;

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

        public static void PrintError()
        {
            WriteLine("Введено неверное значение, повторите ввод");
        }

    }
    
}
