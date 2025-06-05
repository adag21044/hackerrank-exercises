/*
 * Given five positive integers, find the minimum and maximum values that can be calculated
 * by summing exactly four of the five integers. Then print the respective minimum and maximum
 * values as a single line of two space-separated long integers.
 *
 * Example:
 * Input: 1 2 3 4 5
 * The minimum sum is 1+2+3+4 = 10
 * The maximum sum is 2+3+4+5 = 14
 * Output: 10 14
 *
 * Function Description:
 * Complete the 'miniMaxSum' function with the following parameter:
 * - arr: an array of 5 integers
 * Print:
 * - Two space-separated integers on one line: the min and max sum of 4 out of 5 elements.
 * Note:
 * - Beware of integer overflow! Use a 64-bit integer (long) to store the sums.
 * Input Format:
 * - A single line of five space-separated integers.
 * Constraints:
 * - Each integer is positive and fits within a 32-bit signed integer.
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
    public static void miniMaxSum(List<int> arr)
    {    
        long minSum = 0; 
        long maxSum = 0;
        
        if(arr.Count < 5) Console.WriteLine(-1);
        else
        {
            arr.Sort();
            for(int i = 0; i < 4; i++)
            {
                minSum += arr[i];    
            }
            
            for(int i = 1; i < 5; i++)
            {
                maxSum += arr[i];
            }
        }  
        
        Console.WriteLine(minSum + " " + maxSum);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        Result.miniMaxSum(arr);
    }
}
