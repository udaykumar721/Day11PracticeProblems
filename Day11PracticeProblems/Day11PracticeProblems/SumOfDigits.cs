using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11PracticeProblems
{
    internal class SumOfDigits
    {
        public void SumOfAllDigits()
        {
            Console.WriteLine("Enter A Number To Find Its Sum Of Digits");
            int num = int .Parse(Console.ReadLine());
            int remainder , sum = 0;
            while(num != 0)
            {
                remainder = num % 10;
                sum += remainder;
                num = num / 10;
            }
            Console.WriteLine("The Sum Of The Its Digits In The Number is :{0} ", sum);
        }
    }
}
