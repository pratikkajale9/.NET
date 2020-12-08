using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5AssignmentQ2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the number Batches:");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number Students:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Enter the Marks for Batch number {0} of Student {1} :", i, j);
                    
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            foreach (int x in arr)
            {
                Console.WriteLine("Marks of Students {0}:", x);

            }
            Console.ReadLine();
        }
    }
}


