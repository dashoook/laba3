using System;

namespace LABA31
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string[] a = s.Split(' ');
            char[] c = s.ToCharArray();
            for (int i = 0; i < a.Length; i += 2)
            {
                Console.Write(a[i] + " ");
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (c[i] == ' ')
                {
                    if (c[0] == c[i - 1])
                    {
                        for (int j = 0; j < i; j++)
                        {
                            c[j] = ' ';

                        }
                        break;
                    }
                }

            }
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (c[i] == ' ')
                {
                    if (c[i + 1] == c[s.Length - 1])
                    {
                        for (int j = s.Length - 1; j > i; j--)
                        {
                            c[j] = ' ';
                        }
                    }
                    break;
                }

            }
            for (int i = 0; i < s.Length; i++)
            {
                if (c[i] == ' ')
                {
                    for (int j = i + 1; j < s.Length; j++)
                    {
                        if (c[j] == ' ')
                        {
                            if (c[i + 1] == c[j - 1])
                            {
                                for (int k = i + 1; k < j; k++)
                                {
                                    c[k] = ' ';
                                }
                            }
                            break;
                        }
                    }
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine(c);
            

        }
    }

}
 