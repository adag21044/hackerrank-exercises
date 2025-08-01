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
     * Complete the 'pickingNumbers' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static int pickingNumbers(List<int> a)
    {
        
        int[] count = new int[101];

        
        for (int i = 0; i < a.Count; i++)
        {
            int currentNumber = a[i];
            count[currentNumber]++; 
        }

        
        int maxLength = 0;

        for (int i = 0; i <= 100; i++)
        {
            
            int currentNumberCount = count[i];

            
            int nextNumberCount = 0;
            if (i + 1 <= 100) 
            {
                nextNumberCount = count[i + 1];
            }

        
            int total = currentNumberCount + nextNumberCount;

            
            if (total > maxLength)
            {
                maxLength = total;
            }
        }

        
        return maxLength;
    }


}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.pickingNumbers(a);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
