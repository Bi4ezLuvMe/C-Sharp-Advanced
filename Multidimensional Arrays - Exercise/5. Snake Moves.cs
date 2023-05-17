using System;
using System.Linq;
 
namespace Snake_in_the_grass
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = ReadArrayFromConsole();
 
            char[,] matrix = new char[sizes[0], sizes[1]];
 
            int x = -1;
 
            var array = Console.ReadLine();
 
            for (int i = 0; i <sizes[0]; i++)
            {
 
                if (i%2 == 0)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (x == array.Length - 1)
                        {
                            x = -1;
                        }
                        x++;
                        matrix[i, j] = array[x];
                    }
                }
                else
                {
                    for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
                    {
 
                        if (x == array.Length - 1)
                        {
                            x = -1;
                        }
                        x++;
                        matrix[i, j] = array[x];
                    }
                }
            }
 
            PrintMatrix(matrix);
 
 
        }
 
        private static void PrintMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
 
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
 
        private static int[] ReadArrayFromConsole()
        {
            return Console.ReadLine().
                Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
 