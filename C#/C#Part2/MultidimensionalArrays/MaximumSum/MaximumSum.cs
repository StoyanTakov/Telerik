using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumSum
{
    class MaximumSum
    {
        // printing the entire matrix, separate color for the max sum cells
        private static void PrintMatrix(int[,] matrix, int maxRow, int maxCol)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    if (rows >= maxRow && rows <= maxRow + 2 && cols >= maxCol && cols <= maxCol + 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }

                    Console.Write("{0,4}", matrix[rows, cols]);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // takes a starting point and calculates the sum in starting cell + 2 cells to the right, starting cell plus 2 cells down
        static int CalcSum(int startRow, int startCol, int[,] matrix)
        {
            int sum = 0;
            for (int row = startRow; row < startRow + 3; row++)
            {
                for (int col = startCol; col < startCol + 3; col++)
                {
                    sum = sum + matrix[row, col];
                }
            }

            return sum;
        }

        static void Main()
        {
            // TODO: 100/ 100 

            // input - Line 1: Rows, Empty, Cols
            string[] Sizes = Console.ReadLine()
                                   .Trim(' ')
                                   .Split(' ');

            // Variables
            byte areaSize = 3;

            short MaxSum;
            short curSum;

            short[][] curSums = new short[areaSize][];

            // Read First 3 Lines
            for (int curRow = 0;
                     curRow < areaSize;
                     curRow++)
            {
                curSums[curRow] = ReadInputLine(areaSize);
            }

            // Find the First Max Sum
            MaxSum = FindMaxSum(curSums);

            // End if just 3 rows if input
            if (int.Parse(Sizes[0]) == 3)
            {
                Console.WriteLine(MaxSum);
                return;
            }

            // if not keep reading rows 

            int RowToWrite = 0;

            for (int Row = 3;
                     Row < int.Parse(Sizes[0]);
                     Row++)
            {
                // Read a new row
                curSums[RowToWrite % areaSize] =
                            ReadInputLine(areaSize);

                // find Max Sum
                MaxSum = (curSum = FindMaxSum(curSums)) > MaxSum ? //FindMaxSum
                          curSum : MaxSum;

                RowToWrite++;
            }

            // output
            Console.WriteLine(MaxSum);
        }

        // Read A line - Working
        // Store each input line
        // as an area of the sum
        // of each 3 elements
        public static short[] ReadInputLine(short areaSize)
        {
            string[] Input = Console.ReadLine()
                                    .Trim(' ')
                                    .Split(' ');

            short[] ArrayOfSums = new short[Input.Length - (areaSize - 1)];

            ArrayOfSums[0] = (short)(short.Parse(Input[0]) +   // manually add
                                     short.Parse(Input[1]) +   // first element
                                     short.Parse(Input[2]));   // to read faster

            for (int curElement = 1;
                     curElement < Input.Length - (areaSize - 1);
                     curElement++)
            {
                ArrayOfSums[curElement] =                                  // 1. Current sum
                        ArrayOfSums[curElement - 1];                       // = previous sum
                                                                           //  
                ArrayOfSums[curElement] -=                                 // 2. Subtract the
                        short.Parse(Input[curElement - 1]);                // previous input 
                                                                           // element
                ArrayOfSums[curElement] +=                                 // 3. Add the next
                        short.Parse(Input[curElement + (areaSize - 1)]);   // input element

            }

            return ArrayOfSums;
        }

        public static short FindMaxSum(short[][] curRows)
        {
            short MaxSum = short.MinValue;
            short curSum = 0;

            for (int curElement = 0;
                     curElement < curRows[0].Length;
                     curElement++)
            {
                curSum = 0;

                for (int Row = 0;
                         Row < curRows.Length;
                         Row++)
                {
                    curSum += curRows[Row][curElement];
                }

                MaxSum = curSum > MaxSum ?
                         curSum : MaxSum;
            }

            return MaxSum;
        }
    }
}
