using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter a number:");
            String input = System.Console.ReadLine();
            int size = 0;
            Int32.TryParse(input, out size);

            int[][] matrix = new int[size][];
            int buf = 0;

            for (int m = 0; m < size; m++)
            {
                matrix[m] = new int[size];
                System.Console.WriteLine();
                for (int n = 0; n < size; n++)
                {
                    matrix[m][n] = buf++;
                    System.Console.Write(matrix[m][n] + " ");
                }
                System.Console.WriteLine();
            }

            System.Console.WriteLine("Please enter first index of the element (max is "+ (size-1) + "): ");
            String input1 = System.Console.ReadLine();
            int firstIndex = 0;
            Int32.TryParse(input1, out firstIndex);

            System.Console.WriteLine("Please enter second index of the element (max is " + (size-1) + "): ");
            String input2 = System.Console.ReadLine();
            int secondIndex = 0;
            Int32.TryParse(input1, out secondIndex);

            matrix[firstIndex][secondIndex]++;
            for (int m = 0; m < size; m++)
            {
                System.Console.WriteLine();
                for (int n = 0; n < size; n++)
                {
                    System.Console.Write(matrix[m][n] + " ");
                }
                System.Console.WriteLine();
            }

            System.Console.ReadLine();
        }
    }
}
