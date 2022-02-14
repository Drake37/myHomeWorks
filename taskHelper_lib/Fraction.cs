using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskHelper_lib
{
    /// <summary>
    /// Дроби
    /// </summary>
    public class Fraction
    {
        int numerator;
        int denominator;
        readonly int sign;
        public int Num { get => numerator; set { numerator = value; } }
        public int DeNom
        {
            get => denominator;
            set
            {
                if (value != 0) denominator = value;
                else WriteLine("Знаменатель не должен быть 0");
            }
        }
        public double Decimal => numerator / denominator;

        public Fraction(int num, int denom)
        {
            try
            {
                if (denom == 0) throw new ArgumentException("Знаменатель не должен быть ноль", "denom");
                denominator = Math.Abs(denom);
                numerator = Math.Abs(num);
                sign = num * denom > 0 ? 1 : -1;
            }
            catch (ArgumentException e)
            {
                WriteLine($"Ошибка: {e.Message}");
            }


        }
        /// <summary>
        /// Находит НОД
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private static int GetGreatestCommonDivisor(int a, int b)
        {
            while (b != 0)
            {
                int c = b;
                b = a % b;
                a = c;
            }
            return a;
        }
        /// <summary>
        /// Находит НОК
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private static int GetLeastCommonMultiple(int a, int b) => a * b / GetGreatestCommonDivisor(a, b);

        /// <summary>
        /// дает дробь, результат сложения или вычитания, зависит от операции
        /// </summary>
        /// <param name="a">дробь а</param>
        /// <param name="b">дробь b</param>
        /// <param name="operation"></param>
        /// <returns></returns>
        private static Fraction PerformOperation(Fraction a, Fraction b, Func<int, int, int> operation)
        {
            int leastCommonMultiple = GetLeastCommonMultiple(a.denominator, b.denominator);
            int addMul1 = leastCommonMultiple / a.denominator; // доп множитель для первой
            int addMul2 = leastCommonMultiple / b.denominator; // доп множитель для второй
            int res = operation(a.numerator * addMul1 * a.sign, b.numerator * addMul2 * b.sign);
            return new Fraction(res, a.denominator * addMul1);

        }

        public static Fraction operator +(Fraction a, Fraction b) => PerformOperation(a, b, (int x, int y) => x + y);
        public static Fraction operator -(Fraction a, Fraction b) => PerformOperation(a, b, (int x, int y) => x - y);
        public static Fraction operator *(Fraction a, Fraction b) => new Fraction(a.numerator * a.sign * b.numerator * b.sign,
            a.denominator * b.denominator);
        /// <summary>
        /// возврат обратной дроби
        /// </summary>
        /// <returns></returns>
        private Fraction GetReverse() => new Fraction(this.denominator * this.sign, this.numerator);
        public static Fraction operator /(Fraction a, Fraction b) => a * b.GetReverse();

        /// <summary>
        /// сокращение
        /// </summary>
        /// <returns></returns>
        public Fraction Reduce()
        {
            Fraction res = this;
            int greatestCommonDivisor = GetGreatestCommonDivisor(this.numerator, this.denominator);
            res.numerator /= greatestCommonDivisor;
            res.denominator /= greatestCommonDivisor;
            return res;
        }

        /// <summary>
        /// вывод в строку
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (this.numerator == 0) return "0";
            string res;
            res = this.sign < 0 ? "-" : "";          

            if (this.numerator == this.denominator) return res + "1";
            if (this.denominator == 1) return res + this.numerator;
            
            return res + this.numerator + "/" + this.denominator;
        }
    }
}
