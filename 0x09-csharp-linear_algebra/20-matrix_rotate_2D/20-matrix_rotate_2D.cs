using System;

/// <summary>Class operations with matrices</summary>
class MatrixMath
{
    /// <summary>Method that rotates a matrix</summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        // double angleR = (Math.PI / 180) * angle;
        // double angleCos = Math.Cos(angleR);
        // double angleSin = Math.Sin(angleR);
        double angleCos = Math.Cos(angle);
        double angleSin = Math.Sin(angle);
        double[,] notPossible = {{-1}, {-1}};

        if (matrix.GetLength(0) != 2)
        {
            return notPossible;
        }

        for (int x = 0; x < matrix.GetLength(0); x++)
        {
            for (int y = 0; y < 1; y++)
            {
                // Console.WriteLine(matrix[x, y] + "===" + matrix[x, y+1]);
                // Console.WriteLine((matrix[x, y] * angleCos) + "===" + (matrix[x, y + 1] * (angleSin)));
                matrix[x, y] = Math.Round((matrix[x, y] * angleCos) - (matrix[x, y + 1] * (angleSin)), 2);
                matrix[x, y + 1] = Math.Round((matrix[x, y] * angleSin) + (matrix[x, y + 1] * (angleCos)), 2);
                // matrix[x, y] = (matrix[x, y] * (angleCos)) - (matrix[x, y + 1] * (angleSin));
                // matrix[x, y + 1] = (matrix[x, y] * (angleSin)) + (matrix[x, y + 1] * (angleCos) + 1);
            }
        }
        return matrix;
    }
}