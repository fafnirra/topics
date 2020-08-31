using System;
using System.Runtime.InteropServices;

namespace Maximumofparametrs3
{
    class Program
    {
        static int MaximumOfArr(int[] b)
        {
            int m = 0;
            int currentm = int.MinValue;
            for (int i = 0; i <= b.Length - 1; i++)
            {
                if (b[i] > currentm)
                {
                    currentm = b[i];
                    m = i;
                }
            }


            return m;
        }

        static void Main(string[] args)
        {
            int[] arr = {12, 6, 5, 2};
            Console.WriteLine(MaximumOfArr(arr));
        }
    }
}
