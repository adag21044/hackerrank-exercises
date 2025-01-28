/*
 * You are in charge of the cake for a child's birthday.
 * You have decided the cake will have one candle for each year of their total age.
 * They will only be able to blow out the tallest of the candles.
 * Count how many candles are tallest.
 *
 * Example:
 * candles = [4, 4, 1, 3]
 * The maximum height candles are 4 units high.
 * There are 2 of them, so return 2.
 *
 * Function Description:
 * Complete the function birthdayCakeCandles in the editor below.
 *
 * birthdayCakeCandles has the following parameter(s):
 * - int candles[n]: the candle heights
 *
 * Returns:
 * - int: the number of candles that are tallest
 *
 * Input Format:
 * - The first line contains a single integer, n, the size of candles[].
 * - The second line contains n space-separated integers, where each integer i describes the height of candles[i].
 *
 * Constraints:
 * - 1 ≤ n ≤ 10^6
 * - 1 ≤ candles[i] ≤ 10^7
 *
 * Sample Input 0:
 * 4
 * 3 2 1 3
 *
 * Sample Output 0:
 * 2
 *
 * Explanation 0:
 * Candle heights are [3, 2, 1, 3].
 * The tallest candles are 3 units, and there are 2 of them.
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

    public static int birthdayCakeCandles(List<int> candles)
    {
        int biggestNumInd = 0;
        int total = 0;
        
        for(int i = 0; i < candles.Count; i++)
        { 
            
            
            if(candles[biggestNumInd] < candles[i])
            {
                biggestNumInd = i;
            } 
        }
        
        for(int i = 0; i < candles.Count; i++)
        {
            if(candles[biggestNumInd] == candles[i])
            {
                total++;
            }
        }
        
        return total;
        
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

        int result = Result.birthdayCakeCandles(candles);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
