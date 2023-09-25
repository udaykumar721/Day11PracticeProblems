using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11PracticeProblems
{
    internal class PatternClass1
    {
        public void  Pattren(int input)
        {
            for(int i = 0; i < input; i++)
            {
                for(int j = input; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

    }
}
