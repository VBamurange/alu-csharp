using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix = new int[5, 5]; 

        matrix[2, 2] = 1;  

        // Print the array
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + (j < matrix.GetLength(1) - 1 ? " " : "\n"));
            }
        }
    }
}