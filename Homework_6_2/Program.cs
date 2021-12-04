using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            string OppositeS = "";

            for (int i = S.Length - 1; i >= 0; i--)
            {
                OppositeS += S[i];
            }
            if (S == OppositeS)
                Console.WriteLine("Палиндром");
            else
                Console.WriteLine("Не Палиндром");
            {
                Console.ReadKey();
            }
        }
    }
}
