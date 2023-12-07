namespace _1._Diagonal_diff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                int[] row = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int j = 0; j < row.Length; j++)

                {
                    matrix[i, j] = row[j];

                }

            }

            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < size; i++) { sum1 += matrix[i, i]; }
            for (int i = 0; i < size; i++) { sum2 += matrix[i, size - 1 - i]; }

            int diff = Math.Abs(sum1 - sum2);

            Console.WriteLine(diff);

            //Console.WriteLine(sum1 + ", " + sum2);

            // foreach (int row in matrix) { Console.Write(row + " "); }

        }
    }
}