namespace _5.SnakeMoves
{
    internal class Program
    {
        static void FillMatrix(string text, int row, int col)

        {
            char[] textInChars = text.ToCharArray();

            Queue<char> allCharsInMatrix = new Queue<char>();

            int count = 0;
            
            for (int i = 0; i <= Math.Ceiling((double)(row*col/textInChars.Length)); i++)
            {
                for (int j = 0; j < textInChars.Length; j++) 
                {
                    if (count == row * col)
                    {
                        break;
                    }
                    else
                    {
                        allCharsInMatrix.Enqueue(textInChars[j]);
                        count++;
                    }
                }
            }
            char[,] matrix = new char[row, col];

            for (int i = 0; i < row; i ++) 
            {
                if (i % 2 ==0) 
                { for (int j = 0; j < col; j++) matrix[i, j] = allCharsInMatrix.Dequeue(); }

                else 
                { for (int j = col-1; j >= 0; j--) matrix[i, j] = allCharsInMatrix.Dequeue(); }
              
            }
           for (int i=0; i < row; i++) 
            { for (int j = 0; j < col; j++) { Console.Write($"{matrix[i,j]}"); } Console.WriteLine(); }     
        }

        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int row = size[0];
            int col = size[1];  

            char[,] matrix = new char[row, col];
            
            string word = Console.ReadLine();

            FillMatrix(word, row, col);

        }
    }
}