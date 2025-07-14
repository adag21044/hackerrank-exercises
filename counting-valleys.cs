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
     * Complete the 'countingValleys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER steps
     *  2. STRING path
     */

    public static int countingValleys(int steps, string path)
    {
        List<int> sampledLocations = new List<int>();
        sampledLocations.Add(0);
        
        int pathLength = path.Length; //UD => 2
        int result = 0;
        bool isInValley = false;
        
        for(int i = 0; i < pathLength; i++)
        {
            if(path[i] == 'D') sampledLocations.Add(sampledLocations[i] - 1);
            else if(path[i] == 'U') sampledLocations.Add(sampledLocations[i] + 1);
        }
        
        for(int i = 1; i < sampledLocations.Count; i++) 
        {
            if(sampledLocations[i-1] == -1 && sampledLocations[i] == 0)
            {
                result++; 
            }
        }

        
        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int steps = Convert.ToInt32(Console.ReadLine().Trim());

        string path = Console.ReadLine();

        int result = Result.countingValleys(steps, path);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
