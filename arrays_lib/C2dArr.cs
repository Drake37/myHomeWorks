using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace arrays_lib{

    public class C2dArr
    {
        int[,] _ar;
        public int[,] Ar => _ar;
        int _minEl;
        int _maxEl;

        public C2dArr(int d1Len =10, int d2Len=10, int min=-50, int max=50)
        {
            _ar = new int[d1Len, d2Len];
            Random r = new Random();
            for (int i = 0; i < d1Len; i++)
                for (int j = 0; i < d2Len; j++)
                    _ar[i,j] = r.Next(min, max);
        }
        public C2dArr(string file)
        {
            try
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    int r = 0;
                    string[] row;
                    _ar = new int[int.Parse(sr.ReadLine()), int.Parse(sr.ReadLine())];
                    while(!sr.EndOfStream)
                    {
                        row  = sr.ReadLine().Split(',');
                        for(int j = 0; j < row.Length; j++)
                            _ar[r, j] = int.Parse(row[j]);
                        r++;
                    }
                    
                    sr.Close();
                    

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public int Sum()
        {
            int sum = 0;
            for (int i = 0;i < _ar.GetLength(0);i++)
                for (int j = 0; j < _ar.GetLength(1); j++)
                    sum += _ar[i,j];
            return sum;
        }

        public int Sum(int max)
        {
            int sum = 0;
            for (int i = 0; i < _ar.GetLength(0); i++)
                for (int j = 0; j < _ar.GetLength(1); j++)
                    if(_ar[i,j] > max) sum += _ar[i, j];
            return sum;
        }

        public int MinEl
        {
            get
            {
                _minEl = _ar[0, 0];
                for (int i = 0; i < _ar.GetLength(0); i++)
                    for (int j = 0; j < _ar.GetLength(1); j++)
                        if(_ar[i,j] < _minEl) _minEl = _ar[i,j];
                return _minEl;
            }
        }
        public int MaxEl
        {
            get
            {
                _maxEl = _ar[0, 0];
                for (int i = 0; i < _ar.GetLength(0); i++)
                    for (int j = 0; j < _ar.GetLength(1); j++)
                        if (_ar[i, j] > _maxEl) _maxEl = _ar[i, j];
                return _maxEl;
            }
        }
        public void GetMaxElIndex(out int i, out int j)
        {
            i = 0; j = 0;
            int max = _ar[0, 0];
            for (int n = 0; n < _ar.GetLength(0); n++)
                for (int m = 0; m < _ar.GetLength(1); m++)
                    if (_ar[n, m] > max)
                    {
                        i = n; j = m;
                    }

        }
        public void Log(string data, string file)
        {
            try
            {
                using(StreamWriter sw = new StreamWriter(file))
                {
                    sw.WriteLine(data);
                    sw.Close();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
