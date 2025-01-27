/*
 * Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero.
 * Print the decimal value of each fraction on a new line with 6 places after the decimal.
 *
 * Note: This challenge introduces precision problems. The test cases are scaled to six decimal places,
 * though answers with absolute error of up to 10^-4 are acceptable.
 *
 * Example:
 * arr = [1, 1, 0, -1, -1]
 * 
 * There are n = 5 elements: two positive, two negative, and one zero.
 * Their ratios are:
 * - Positive: 2/5 = 0.400000
 * - Negative: 2/5 = 0.400000
 * - Zero: 1/5 = 0.200000
 * Results are printed as:
 * 0.400000
 * 0.400000
 * 0.200000
 *
 * Function Description:
 * Complete the 'plusMinus' function below.
 * - The function accepts INTEGER_ARRAY arr as parameter.
 * - It calculates the ratios of positive, negative, and zero values in the array.
 * - Each value is printed on a separate line with 6 decimal places.
 * - The function does not return a value.
 *
 * Input Format:
 * - The first line contains an integer, n, the size of the array.
 * - The second line contains n space-separated integers that describe arr[n].
 *
 * Constraints:
 * - 0 < n ≤ 100
 * - -100 ≤ arr[i] ≤ 100
 *
 * Output Format:
 * Print the following 3 lines, each to 6 decimals:
 * 1. Proportion of positive values
 * 2. Proportion of negative values
 * 3. Proportion of zeros
 *
 * Sample Input:
 * 5
 * 1 1 0 -1 -1
 *
 * Sample Output:
 * 0.400000
 * 0.400000
 * 0.200000
 *
 * Explanation:
 * There are 2 positive numbers, 2 negative numbers, and 1 zero in the array.
 * The proportions are:
 * - Positive: 2/5 = 0.400000
 * - Negative: 2/5 = 0.400000
 * - Zero: 1/5 = 0.200000
 */

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

    public static void plusMinus(List<int> arr)
    {
        int length = arr.Count;
        
        //counts
        float zeros = 0;
        float positives = 0;
        float negatives = 0;
        
        //ratios
        float r_zeros = 0;
        float r_positives = 0;
        float r_negatives = 0;
        
        
        
        foreach(int i in arr)
        {
            if(i == 0) zeros++;
            else
            if(i > 0) positives++;
            else 
            if(i < 0) negatives++;
        }
        
        
        
        r_zeros = zeros / length;
        r_positives =  positives / length;
        r_negatives = negatives / length;
        
        Console.WriteLine(r_positives.ToString("F6"));
        Console.WriteLine(r_negatives.ToString("F6"));
        Console.WriteLine(r_zeros.ToString("F6"));

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
