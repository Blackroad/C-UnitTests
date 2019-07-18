using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainModule
{
    public class MyArray
    {
        private int[] b;

        public MyArray(int[] a)
        {
            b = a;
        }

        public int FindMax()
        {
            if (b == null)
                throw new NullReferenceException("No massive");

            int max = b[0];
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] > max)
                    max = b[i];
            }
            return max;
        }

    }
}
