using System;
using System.IO;
namespace LABA322
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            Console.WriteLine("Enter amount of numbers in first file: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter amount of numbers in second file: ");
            m = int.Parse(Console.ReadLine());
            float[] a = new float[n];
            float[] b = new float[m];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Numbers for first file: a[" + i + "]" + ": ");
                a[i] = float.Parse(Console.ReadLine());

            }
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("Numbers for second file: b[" + i + "]" + ": ");
                b[i] = float.Parse(Console.ReadLine());
            }
            File.WriteAllText("F:\\C#\\LABA322\\one.txt", string.Join(" ", a));
            File.WriteAllText("F:\\C#\\LABA322\\second.txt", string.Join(" ", b));
            float[] c = new float[m+n];
            int q = 1;
            for (int k = 1; k < n; k++)
             {
                c[k+q] = a[k];
                q++;
                 
             }
            int w = 2;
            for (int k = 1; k < m; k++)
            {
                c[k + w] = b[k];
                w++;
            }
            c[0] = a[0];
            c[1] = b[0];

            File.WriteAllText("F:\\C#\\LABA322\\third.txt", string.Join(" ", c));

        }
    }
}
