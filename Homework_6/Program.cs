using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Дети подарили маме хризантемы";
            string MaxLengthWord = string.Empty;
            string[] words = s.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > MaxLengthWord.Length)
                    MaxLengthWord = words[i];
            }
            Console.Write("Самое длинное слово: ");
            Console.WriteLine(MaxLengthWord);
            {
                Console.ReadKey();
            }
        }
    }
}
