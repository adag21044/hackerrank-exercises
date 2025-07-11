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
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

    public static List<int> gradingStudents(List<int> grades)
    {
        List<int> result = new List<int>(grades.Count);
        int size = grades.Count;
        
        for(int i = 0; i < size; i++)
        {
            if(grades[i] < 38 )
            {
                result.Add(grades[i]);
            }
            else
            {
                result.Add(Closest5k(grades[i]));
            }
        }
        
        return result;
    }
    
    public static int Closest5k(int grade)
    {
        int[] FinalGrades = {40, 45, 50, 55, 60, 65, 70, 75, 80, 85, 90, 95, 100};

        for (int i = 0; i < FinalGrades.Length; i++)
        {
            if (grade < FinalGrades[i])
            {
                int diff = FinalGrades[i] - grade;

                if (diff < 3)
                    return FinalGrades[i]; 
                else
                    return grade; 
            }
        }

        return grade;
    }


}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            grades.Add(gradesItem);
        }

        List<int> result = Result.gradingStudents(grades);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
