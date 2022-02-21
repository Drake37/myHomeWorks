using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;
using System.Globalization;

namespace homeWorks
{
    public delegate double Func(double x);
    class Functions
    {
        public static double F(double x)
        {
            return x * x - 50 * x + 10;
        }
        public static double Sqrt(double x) {return Math.Sqrt(x); }
        public static double Cos(double x) { return Math.Cos(x); }


        public static double Sdeg(double x) { return x * x; }
        public static double Sin(double x) { return Math.Sin(x); }

        public static void SaveFunc(string fileName, double startPoint, double endPoint, double step, Func func)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);

            while (startPoint <= endPoint)
            {
                bw.Write(func(startPoint));
                startPoint += step;
            }
            bw.Close();
            fs.Close();
        }
        public static double[] Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double[] ar = new double[fs.Length/sizeof(double)];
            min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return ar;
        }

        public static int GetNum(int maxNum)
        {
            while (true)
                if (!int.TryParse(ReadLine(), out int x) || x > maxNum)
                    Write($"Повторите ввод (от 0 до {maxNum}): ");
                else return x;
        }
        public static void GetInterval(out double startPoint, out double endPoint)
        {
            string[] interval = ReadLine().Split(' ');
            // читаем независимо от региона и языка
            startPoint = double.Parse(interval[0], CultureInfo.InvariantCulture);
            endPoint = double.Parse(interval[1], CultureInfo.InvariantCulture);
        }
        public static void Print(double argStart, double argEnd, double step, double[] values)
        {
            WriteLine("===== X ===== Y =====");
            int index = 0;
            while (argStart <= argEnd)
            {
                WriteLine("| {0,8:0.000} | {1,8:0.000} ", argStart, values[index]);
                argStart += step;
                index++;
            }
            WriteLine("============================");
        }
    }
}
