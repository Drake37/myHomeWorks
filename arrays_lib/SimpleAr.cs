using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_lib
{
    public class SimpleAr
    {
        /// <summary>
        /// словарь частот, ключ = элемент, значение = частота вхождения
        /// </summary>
        private Dictionary<int,int> _dic = new Dictionary<int,int>();
        private int[] a;
        private double sum = 0;
        
        public double GetSum
        {
            get
            {
                foreach (int el in a)
                    sum += el;
                return sum;
            }
        }

        private int maxCnt;

        public int MaxCount
        {
            get
            {
                int elMax = a.Max();
                foreach (int el in a)
                    if (el == elMax) maxCnt++;
                return maxCnt;
            }
        }

        public int this[int i] { get { return a[i]; } set { a[i] = value; } }

        public SimpleAr(int elCnt, int elFirst, int step)
        {
            a = new int[elCnt];
            for (int i = 0, el = elFirst; i < elCnt; i++, el+=step)
                a[i] = el; 
        }

        public int[] Inverse()
        {
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
                b[i] = -a[i];
            return b;
        }

        public void Multi(int n)
        {
            for (int i = 0; i < a.Length; i++)
                a[i] *= n;
        }

        public void Print()
        {
            Console.WriteLine(string.Join(" ", a));
        }

        public void CountElements()
        {
            foreach (int el in a)
                _dic[el] = _dic.ContainsKey(el) ? _dic[el] +1 : 1 ;
        }

        public void PrintDic()
        {
            foreach (var el in _dic)
                Console.WriteLine($"el {el.Key}  cnt: {el.Value}");
        }

    }
}
