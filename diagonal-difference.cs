// Problem Description:
// Given a square matrix, calculate the absolute difference between the sums of its diagonals.

// For example:
// Input Matrix:
// 1 2 3
// 4 5 6
// 9 8 9
//
// Primary Diagonal: 1, 5, 9 -> Sum = 15
// Secondary Diagonal: 3, 5, 9 -> Sum = 17
// Absolute Difference: |15 - 17| = 2
//
// Input Format:
// - The first line contains a single integer, n (size of the square matrix).
// - The next n lines contain n space-separated integers (matrix rows).
//
// Output:
// - Return the absolute difference between the sums of the diagonals.
//
// Constraints:
// - Matrix is always square (n x n).

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */
    public static int diagonalDifference(List<List<int>> arr)
    {
        int n = arr.Count; // Number of rows and columns in the square matrix

        // Ensure the matrix is square
        if (arr.Any(row => row.Count != n))
        {
            throw new ArgumentException("The matrix must be square (n x n).");
        }

        int dia1 = 0; // Sum of the primary diagonal
        int dia2 = 0; // Sum of the secondary diagonal

        for (int i = 0; i < n; i++)
        {
            dia1 += arr[i][i]; // Primary diagonal (left-to-right)
            dia2 += arr[i][n - i - 1]; // Secondary diagonal (right-to-left)
        }

        // Return the absolute difference between the two diagonals
        return Math.Abs(dia1 - dia2);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
