/*
 * Alice and Bob each created one problem for HackerRank.
 * A reviewer rates the two challenges, awarding points on a scale from 1 to 100 
 * for three categories: problem clarity, originality, and difficulty.
 *
 * The rating for Alice's challenge is in triplet a = (a[0], a[1], a[2]).
 * The rating for Bob's challenge is in triplet b = (b[0], b[1], b[2]).
 *
 * The task is to find their comparison points by comparing:
 * - a[0] with b[0]
 * - a[1] with b[1]
 * - a[2] with b[2]
 *
 * Scoring:
 * - If a[i] > b[i], then Alice receives 1 point.
 * - If a[i] < b[i], then Bob receives 1 point.
 * - If a[i] == b[i], neither person receives a point.
 *
 * The function should return a list with two elements:
 * - The first element is Alice's total score.
 * - The second element is Bob's total score.
 *
 * Example:
 * Input:
 * a = [5, 6, 7]
 * b = [3, 6, 10]
 * 
 * - a[0] > b[0] → Alice gets 1 point.
 * - a[1] == b[1] → No points awarded.
 * - a[2] < b[2] → Bob gets 1 point.
 *
 * Output:
 * [1, 1]
 *
 * Function Description:
 * Complete the 'compareTriplets' function below.
 *
 * Parameters:
 * - List<int> a: Alice's challenge ratings
 * - List<int> b: Bob's challenge ratings
 *
 * Returns:
 * - List<int>: The first element is Alice's score, and the second is Bob's score.
 *
 * Input Format:
 * - The first line contains 3 space-separated integers (Alice's ratings).
 * - The second line contains 3 space-separated integers (Bob's ratings).
 *
 * Constraints:
 * - 1 ≤ a[i] ≤ 100
 * - 1 ≤ b[i] ≤ 100
 *
 * Output Format:
 * - Print a list with two integers: [Alice's score, Bob's score].
 *
 * Sample Input 1:
 * 6 7 8
 * 3 6 10
 *
 * Sample Output 1:
 * 1 1
 *
 * Explanation:
 * - Alice gets 1 point for a[0] > b[0].
 * - No points for a[1] == b[1].
 * - Bob gets 1 point for a[2] < b[2].
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

    

    public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        int aliceScore = 0;
        int bobScore = 0;
        
        for(int i = 0; i < 3; i++)
        {
            if(a[i] > b[i])
            {
                aliceScore++;
            }
            else
            if(b[i] > a[i])
            {
                bobScore++;
            }    
        }
        
        List<int> result = new List<int>{ aliceScore, bobScore };
        
        return result;
        
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        List<int> result = Result.compareTriplets(a, b);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
