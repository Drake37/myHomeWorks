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
        int _numerator;
        int _denominator;
        public int Num { get => _numerator; set { _numerator = value; } }
        public int DeNom { get => _denominator;
            set
            {
                if (value != 0) _denominator = value;
                else WriteLine("Знаменатель не должен быть 0");
            }
        }
        public double Decimal => _numerator / _denominator;
        
        public Fraction(int num, int denom)
        {
            try
            {
                _numerator = num;
                _denominator = denom;
            }
            catch (ArgumentException) when (denom == 0)
            {
                WriteLine("Знаменатель не должен быть ноль");
            }
        }

        void SetDenom(int denom)
        {
            try
            {
                _denominator = denom;
            }
            catch (ArgumentException) when (denom == 0)
            {
                WriteLine("Знаменатель не должен быть ноль");
            }
        }
    }
}
