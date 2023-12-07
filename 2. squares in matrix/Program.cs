using System.Runtime.ExceptionServices;

namespace _2._squares_in_matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int rows = size[0];
            int cols = size[1];

            char[,] matrix = new char[rows, cols];
            bool positive = false;
            int sum = 0;

            for (int i = 0; i < rows; i++) 
            {
                char[] row = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int j = 0; j < cols; j++) 
                {
                    matrix[i, j] = row[j];
                }
            }

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if ((matrix[row, col] == matrix[row + 1, col]) && (matrix[row, col] == matrix[row, col + 1]) && (matrix[row, col] == matrix[row + 1, col + 1]))

                    { sum++; }
                }
            }
            
            Console.WriteLine(sum);
        }
    }
}