using System;

class MatrixMath {
   
    public static double Determinant(double[,] matrix) {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != cols) {
            return -1;
        }

        if (rows == 2) {
            return Math.Round(matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0], 2);
        }
        else if (rows == 3) {
            double determinant = 0;
            determinant += matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]);
            determinant -= matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]);
            determinant += matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
            return Math.Round(determinant, 2);
        }
        else {
            return -1;
        }
    }
}