using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace arrays_lib
{
    public static class Arr
    {
        public static int[] A { get; private set; }
        
        public static void Print(int[] x)
        {
            Console.WriteLine(string.Join(" ", x));
        }

        public static int GetPairCount(int[] ar)
        {
            int count = 0;
            for(int i = 0; i < ar.Length -1; i++)
            {
                if (ar[i] % 3 == 0 ^ ar[i + 1] % 3 == 0) count++;
            }
            return count;
        }
        public static int[] BuildArFromFile()
        {
            try
            {
                using (StreamReader sr = new StreamReader(@"C:\Users\Drake\source\repos\homeWork01\task1\TextFile1.txt"))
                {
                    int elCnt = int.Parse(sr.ReadLine());
                    A = new int[elCnt];
                    for (int i = 0; i < elCnt;i++)
                        A[i] = int.Parse(sr.ReadLine());
                    sr.Close();
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return A;
    }
}


}
