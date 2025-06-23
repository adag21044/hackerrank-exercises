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
     * Complete the 'migratoryBirds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int migratoryBirds(List<int> arr)
    {
        if(arr.Count < 5) return -1; 
        
        int[] possibleIDs = {1, 2, 3, 4, 5};
        int[] frequencies = {0, 0, 0, 0, 0};
        
        Dictionary<int, int> dict = new Dictionary<int, int>(5);
        
        foreach(int i in arr)
        {
            if(i == possibleIDs[0]) frequencies[0]++;
            else
            if(i == possibleIDs[1]) frequencies[1]++;
            else
            if(i == possibleIDs[2]) frequencies[2]++;
            else
            if(i == possibleIDs[3]) frequencies[3]++;
            else
            if(i == possibleIDs[4]) frequencies[4]++;
        }
        
        for(int i = 0; i < 5; i++)
        {
            dict.Add(possibleIDs[i], frequencies[i]);
        }
        
        int wanted = dict.Values.Max();
        
        foreach (var kv in dict)
        {
            if (kv.Value == wanted)
                return kv.Key;  
        }
        
        return -1;  
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
