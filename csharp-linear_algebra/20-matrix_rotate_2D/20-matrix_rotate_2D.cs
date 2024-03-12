using System;
class MatrixMath{
    public static double[,] Rotate2D(double[,] matrix, double angle){
        double[,] rotationMatrix = {
            { Math.Cos(angle), Math.Sin(angle)},
            { -(Math.Sin(angle)), Math.Cos(angle)}
        };

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if(rows == cols && rows == 2 && cols == 2){
         
         double[,] result = new double[rows,rows];

         for (int col = 0; col < cols; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                    result[row, col] = 0;
                    for (int k = 0; k < rows; k++)
                    {
                        result[row, col] += Math.Round( rotationMatrix[row, k] * matrix[k, col] , 2);
                    }
                }
            }

            return result;
        }

        return new double[,]{{-1}};
       
    }
  
}