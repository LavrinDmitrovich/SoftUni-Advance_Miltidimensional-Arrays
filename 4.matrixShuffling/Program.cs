using System.Security.Cryptography;

namespace _4.matrixShuffling
{
    internal class Program
    {


        static void PrintMatrix(int[,] a)
        {

            for (int row = 0; row < a.GetLength(0); row++)
            {
                for (int col = 0; col < a.GetLength(1); col++)
                {
                    Console.Write(a[row, col] + " ");
                }
                Console.WriteLine();
            }
        }



        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int rows = size[0];
            int cols = size[1];

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                int[] row = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            string word = Console.ReadLine();
            while (true)
            {

                string[] cmd = word.Split(" ");
                string cmddo = cmd[0];
                int row1 = int.Parse(cmd[1]);
                int col1 = int.Parse(cmd[2]);
                int row2 = int.Parse(cmd[3]);
                int col2 = int.Parse(cmd[4]); 

                if (word == "END") { break; }
                else if (cmddo !="swap") { Console.WriteLine("Invalid input!"); word = Console.ReadLine(); continue; }
                else
                {
                    

                    Queue<int> numbersToChange = new Queue<int>();
                    numbersToChange.Enqueue(matrix[row1, col1]);
                    numbersToChange.Enqueue(matrix[row2, col2]);

                    matrix[row2, col2] = numbersToChange.Dequeue();
                    matrix[row1, col1] = numbersToChange.Dequeue();

                   
                }
                PrintMatrix(matrix);
                word = Console.ReadLine();
            }
        }




    }

}

