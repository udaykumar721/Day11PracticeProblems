using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11PracticeProblems
{
    internal class MatrixRowSum
    {
        int i, j, r, c;
        int[,] arr = new int[100,100];
        public void Matrix()
        {
            Console.WriteLine("Enter Number Of Rows You Want In A Matrix ");
            r = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number Of Columns You Want In A Matrix ");
            c = int.Parse(Console.ReadLine());
            for ( i = 0; i < r; i++)
            {
                for ( j = 0; j < c; j++)
                {
                    arr[i , j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("The Matrix Created By User Is");
            for( i = 0; i < r; i++)
            {
                for( j = 0; j < c; j++)
                {
                    Console.Write("\t{0}", arr[i , j]);
                }
                Console.WriteLine();
            }
        }
        public void Rowsum()
        {
            int sum;
            for(i= 0; i < r;i++)
            {
                sum = 0;
                for(j=0; j < c; j++)
                {
                    sum += arr[i , j];
                }
                Console.WriteLine("{0} ROW SUM IS {1} :", i+1 ,sum);
            }
        }
    }
}
