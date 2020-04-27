using System;
using System.IO;
namespace LABA33
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader fromFile = new StreamReader("F:\\C#\\LABA33\\input.txt");

            string sentence = fromFile.ReadLine();
            fromFile.Close();

            string[] words = sentence.Split(new char[] { ' ', ':', ';', '.', ',', '?', '!', '(', ')', '{', '}', '[', ']', '@', '#', '№', '$', '^', '%', '&', '*' }, StringSplitOptions.RemoveEmptyEntries);

            string maxLength ="";

            foreach (string word in words)
            {
                if (word.Length >= maxLength.Length)
                {
                    maxLength = word;
                }
            }
            File.WriteAllText("F:\\C#\\LABA33\\output.txt", string.Join(" ", maxLength));

        }
    }
}

