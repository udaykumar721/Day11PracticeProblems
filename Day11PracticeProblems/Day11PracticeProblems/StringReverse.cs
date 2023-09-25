using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11PracticeProblems
{
    internal class StringReverse
    {
        public void Reverse()
        {
            Console.WriteLine("Please Enter A String You Want TO Reverse");
            string userName = Console.ReadLine();
            string reversedString = "";
            for(int i = userName.Length-1; i >= 0; i--)
            {
                reversedString += userName[i];
            }
            Console.WriteLine("Reversed String is :" + reversedString);
        }
    }
}
