﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial
{
    class Section3
    {
        /*
         Section 3 - If and Loops
            Multidimensional array
         */

        public void PrintHello()
        {
            Console.WriteLine("S3 Hello World!");
        }


        public void Section3_1()
        {
            //if x > y || y == 20
            //switch and enum
            Types type = Types.myInt;//myInt

            // switch - autogenerated
            switch (type)
            {
                case Types.myInt:
                    Console.WriteLine($"{nameof(type)}, {type}");
                    break;
                case Types.myText:
                    Console.WriteLine($"{nameof(type)}, {type}");
                    break;
                case Types.myDecimal:
                    Console.WriteLine($"{nameof(type)}, {type}");
                    break;
                default:
                    Console.WriteLine($"{nameof(type)}, {type}");
                    break;
            }

            // Array
            int arrayLength = 10;
            int[] myArray = new int[arrayLength];
            myArray[0] = 5;
            Console.WriteLine($"MyArray[0]: {myArray[0]}");

            // Multidimensional array
            int[][] myArray2 = new int[arrayLength][];
            myArray2[0] = new int[2];
            myArray2[0][0] = 7;
            myArray2[1] = new int[5];
            myArray2[1][0] = 3;

            // Prints 10 items for MyArray2
            // Prints 2 items first is 7
            // Prints 5 items first is 3

            Console.WriteLine("");
            Console.WriteLine("Multidimensional array lengths");
            Console.WriteLine($"MyArray2[0] Length: {myArray2.Length}");
            Console.WriteLine($"MyArray2[0][0] Length: {myArray2[0].Length}");
            Console.WriteLine($"MyArray2[1][0] Length: {myArray2[1].Length}");
            Console.WriteLine("");


            int i = 0;
            int j = 0;
            //for each item in array
            Console.WriteLine("Main Array");
            foreach (var A_Item in myArray2)
            {
                if (myArray2[i] != null)
                {
                    Console.WriteLine($"MyArray2[{i}]: {A_Item}");
                }
                else
                    Console.WriteLine($"myArray2[{i}]: null");

                i++;
            }
            i = 0;

            Console.WriteLine("");
            //for each item in array
            //for each item in each array
            Console.WriteLine("Main Array with Sub Arrays");
            foreach (var A_Item in myArray2)
            {
                if (myArray2[i] != null)
                {
                    Console.WriteLine($"MyArray2[{i}]: {A_Item}");
                    foreach (var A_I_Item in myArray2[i])
                    {
                        Console.WriteLine($"MyArray2[{i}][{j}]: {A_I_Item}");
                        j++;
                    }

                }
                else
                    Console.WriteLine($"myArray2[{i}]: null");

                i++;
                j = 0;
            }
        }
        // Types.MyInt, MyText,MyDecimal
        public enum Types
        {
            myInt,
            myText,
            myDecimal
        }

        /* Print grid example
        // Print grid
        //      0       1       2       3      4       5
        //  0   int[]   int[]   0       0      0       0
        //  1   0       0       0       0      0       0
        //  2   0       0       0       0      0       0
        //  3   0       0       0       0      0       0
        //  4   0       0       0       0      0       0
        //  5   0       0       0       0      0       0

        //Console.WriteLine("Print Grid");
        //Console.WriteLine(  "\t 0 \t 1 \t 2  \t 3  \t 4  \t 5 ");
        //Console.WriteLine("0 \t 0 \t 0 \t 0  \t 0  \t 0  \t 0 ");
        //Console.WriteLine("1 \t 0 \t 0 \t 0  \t 0  \t 0  \t 0 ");
        //Console.WriteLine("2 \t 0 \t 0 \t 0  \t 0  \t 0  \t 0 ");
        //Console.WriteLine("3 \t 0 \t 0 \t 0  \t 0  \t 0  \t 0 ");
        //Console.WriteLine("4 \t 0 \t 0 \t 0  \t 0  \t 0  \t 0 ");
        //Console.WriteLine("5 \t 0 \t 0 \t 0  \t 0  \t 0  \t 0 ");
        */
        /// <summary>
        /// Prints a grid from a Multidimensional array
        /// </summary>
        public void Section3_2()
        {
            // Multidimensional array

            int arrayLength = 10;


            int[][] myArray2 = new int[arrayLength][];

            myArray2[0] = new int[2];
            myArray2[0][0] = 7;

            myArray2[1] = new int[6];
            myArray2[1][0] = 3;

            myArray2[3] = new int[4];
            myArray2[3][1] = 12;
            myArray2[3][3] = 10;

            myArray2[7] = new int[2];

            int rowsLength = GetLongestArrayLength(myArray2);



            Console.WriteLine($"Print Grid - Columns: {myArray2.Length} x Rows: {rowsLength}");

            // First line
            Console.Write("\t ");
            for (int line1 = 0; line1 < myArray2.Length; line1++)
            {
                Console.Write($"{line1 + 1} \t ");
            }
            Console.WriteLine("");

            // Each row
            for (int row = 0; row < rowsLength; row++)
            {
                Console.Write($"{row + 1} \t ");

                // Each column of each row
                for (int column = 0; column < myArray2.Length; column++)
                {
                    // when not assigned, put star otherwise put value
                    if (myArray2[column] == null || myArray2[column].Length <= row)// myArray2[1][4] = out of range
                        Console.Write($"* \t "); // null
                    else
                        Console.Write($"{myArray2[column][row]} \t ");
                }
                Console.WriteLine("");
            }
        }
        public int GetLongestArrayLength(int[][] mArray)
        {
            int count = 1;
            foreach (int[] array in mArray)
            {
                if (array != null && array.Length > count)
                    count = array.Length;
            }
            return count;
        }
    }
}
