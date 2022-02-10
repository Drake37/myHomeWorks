using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_lib
{
    public static class StaticClass
    {
        public static int GetPairCount(int[] ar)
        {
            int count = 0;
            for(int i = 0; i < ar.Length -1; i++)
            {
                if (ar[i] % 3 == 0 ^ ar[i + 1] % 3 == 0) count++;
            }
            return count;
        }
    }
}
