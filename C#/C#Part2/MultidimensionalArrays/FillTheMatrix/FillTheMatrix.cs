using System;
using System.Globalization;
 class FillTheMatrix
    {
    private static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j == matrix.GetLength(1) - 1)
                {
                    Console.Write("{0}", matrix[i, j]);
                    continue;
                }
                Console.Write("{0} ", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
    static void Main()
        {
        int matrixSize = int.Parse(Console.ReadLine());
        char matrixArrment = char.Parse(Console.ReadLine());
        matrixArrment =char.ToLower(matrixArrment);
        int counter = 1;
        int[,] matrix = new int[matrixSize, matrixSize];
        if (matrixArrment == 'a')
        {
            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    matrix[col, row] = counter;
                    counter++;
                }
            }
        }
        else if (matrixArrment == 'b')
        {
            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    if (row % 2 == 0)
                    {
                        matrix[col, row] = counter;
                    }

                    // the odd columns will be printed backwards
                    else
                    {
                        matrix[matrixSize - col - 1, row] = counter;
                    }

                    counter++;
                }
            }
        }
        else if (matrixArrment == 'c')
        {
            for (int i = matrixSize - 1; i >= 0; i--)
            {
                int row = i; // rows printed backwards
                int col = 0; // columns - forward
                do
                {
                    matrix[row, col] = counter;
                    col++;
                    row++;
                    counter++;
                } while (row < matrixSize);
            }
            for (int i = 1; i < matrixSize; i++)
            {
                // both rows and columns printed forward
                int col = i;
                int row = 0;
                do
                {
                    matrix[row, col] = counter;
                    col++;
                    row++;
                    counter++;
                } while (col < matrixSize);
            }
        }
        else
        {

        
        int leftColumn = 0; // First unfilled row
        int rightColumn = matrixSize - 1; // Last unfilled row
        int upperRow = 0; // Left unfilled column
        int bottomRow = matrixSize - 1; // Right unfilled column
        int count = 1; // from 1 to N*N
        do
        {
            for (int i = upperRow; i <= bottomRow; i++) // filling the first available column
            {
                matrix[i, leftColumn] = count;
                count++;
            }
            leftColumn++; // we go to the next column

            for (int i = leftColumn; i <= rightColumn; i++) // filling the bottom row
            {
                matrix[bottomRow, i] = count;
                count++;
            }

            bottomRow--; // we go one row up
            for (int i = bottomRow; i >= upperRow; i--) // filling the rightmost column
            {
                matrix[i, rightColumn] = count;
                count++;
            }
            rightColumn--; // we go one column to the left
            for (int i = rightColumn; i >= leftColumn; i--) // filling top available column
            {
                matrix[upperRow, i] = count;
                count++;
            }
            upperRow++; // one row down again
        } while (count <= matrixSize * matrixSize); // and continuing the spiral until count = n*n
            }

        PrintMatrix(matrix);

        }

    }

