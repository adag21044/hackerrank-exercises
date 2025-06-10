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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        int hour;
        int minute;
        int seconds; 
        
        string ans = "";
        
        hour = 10 * int.Parse(s[0].ToString()) + int.Parse(s[1].ToString());
        minute = 10 * int.Parse(s[3].ToString()) + int.Parse(s[4].ToString());
        seconds = 10 * int.Parse(s[6].ToString()) + int.Parse(s[7].ToString());
        if (s[8] == 'P')
        {
            if (hour != 12)
                hour += 12;
        }
        else if (s[8] == 'A')
        {
            if (hour == 12)
                hour = 0;
        }
        
        if(hour > 9 && minute > 9 && seconds > 9)
        {
            ans = hour.ToString() + ":" + minute.ToString() + ":" + seconds.ToString();
            return ans;
        }
        else
        if(hour > 9 && minute > 9 && seconds < 10)
        {
            ans = hour.ToString() + ":" + minute.ToString() + ":0" + seconds.ToString();
            return ans;
        }
        else
        if(hour > 9 && minute < 10 && seconds > 9)
        {
            ans = hour.ToString() + ":0" + minute.ToString() + ":" + seconds.ToString();
            return ans;
        }
        else
        if(hour < 10 && minute > 9 && seconds > 9)
        {
            ans = "0" + hour.ToString() + ":" + minute.ToString() + ":" + seconds.ToString();
            return ans;
        }
        else
        if(hour > 9 && minute < 10 && seconds < 10)
        {
           ans = hour.ToString() + ":0" + minute.ToString() + ":0" + seconds.ToString(); 
           return ans;
        }
        else
        if(hour < 10 && minute > 9 && seconds < 10)
        {
            ans = "0" + hour.ToString() + ":" + minute.ToString() + ":0" + seconds.ToString();
            return ans;
        }
        else
        if(hour < 10 && minute < 10 && seconds > 9)
        {
            ans = "0" + hour.ToString() + ":0" + minute.ToString() + ":" + seconds.ToString();
            return ans;
        }
        else
        if(hour < 10 && minute < 10 && seconds < 10)
        {
            ans = "0" + hour.ToString() + ":0" + minute.ToString() + ":0" + seconds.ToString();
            return ans;
        }
        
        
        
        
        return ans;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
