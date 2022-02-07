using System;

namespace taskHelper_lib
{
    public struct Complex
    {
        public double im;
        public double re;
        public string ToStr => re + "+" + im + "i";

        //  в C# в структурах могут храниться также действия над данными
        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        //  Пример произведения двух комплексных чисел
        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        
        public Complex Minus(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }
    }
    
    public class Ccomplex
    {
        double _im, _re;
        public double Im {get => _im; set { if (value >= 0) _im = value; } }
        public double Re {get => _re; set { if (value >= 0) _re = value; } }
        public string ToStr => _re + "+" + _im + "i";

        public Ccomplex(double im = 0, double re = 0)
        {
            _im = im;
            _re = re;
        }

        public Ccomplex Plus(Ccomplex x2) => new Ccomplex { _im = x2._im + _im, _re = x2._re + _re };

        public Ccomplex Minus(Ccomplex x2) => new Ccomplex { _im = x2._im - _im, _re = x2._re - _re };

        public Ccomplex Multiply(Ccomplex x2) => new Ccomplex { _im = x2._im * _im, _re = x2._re * _re };

    }

}
