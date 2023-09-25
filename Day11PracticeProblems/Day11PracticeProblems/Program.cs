using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11PracticeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PatternClass1 pat = new PatternClass1();
            Console.WriteLine("Enter The Number Of Rows You Want");
            int input = Convert.ToInt32(Console.ReadLine());
            pat.Pattren(input);
            Console.ReadLine();
        }
    }
}
