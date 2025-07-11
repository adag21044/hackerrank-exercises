using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the getMoneySpent function below.
     */
    static int getMoneySpent(int[] keyboards, int[] drives, int b) 
    {
        List<int> costs = new List<int>();
        
        int keyboardCount = 0;
        int driveCount = 0;
        int sortedCount = 0;
        
        List<int> sortedKeyboards = keyboards.ToList();
        sortedKeyboards.Sort();
        keyboardCount = sortedKeyboards.Count;
        
        List<int> sortedDrives = drives.ToList();
        sortedDrives.Sort();
        driveCount = sortedDrives.Count;
                
        foreach (int k in keyboards)
        {
            foreach (int d in drives)
            {
                if (k + d <= b)
                {
                    costs.Add(k + d);
                }
            }
        }

        List<int> sortedCosts = costs.ToList();
        sortedCosts.Sort();
        sortedCount = sortedCosts.Count;
        
        if (costs.Count == 0)
            return -1;

        return costs.Max(); 

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] bnm = Console.ReadLine().Split(' ');

        int b = Convert.ToInt32(bnm[0]);

        int n = Convert.ToInt32(bnm[1]);

        int m = Convert.ToInt32(bnm[2]);

        int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp));

        int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp));
        /*
         * The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
         */

        int moneySpent = getMoneySpent(keyboards, drives, b);

        textWriter.WriteLine(moneySpent);

        textWriter.Flush();
        textWriter.Close();
    }
}
