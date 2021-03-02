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


class Solution {
    
    static List<int> position (int x, int v) {
        
        List<int> position = new List<int>();
        
        
        
        
        for (int i = 0; i < 10000; i++) {
            position.Add(x);
            x += v;
        }
        return position;
    }

    // Complete the kangaroo function below.
    static string kangaroo(int x1, int v1, int x2, int v2) {
        
        string result = "NO"; 
        
        List<int> Kanguroo1 = new List<int>();
        List<int> Kanguroo2 = new List<int>();
        Kanguroo1 = position(x1, v1);
        Kanguroo2 = position(x2, v2);
            
        for (int i = 0; i < Kanguroo1.Count; i++)  {
            if (Kanguroo1[i] == Kanguroo2[i]){
                    result = "YES";
            }

        }
    
        
        return result;


    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] x1V1X2V2 = Console.ReadLine().Split(' ');

        int x1 = Convert.ToInt32(x1V1X2V2[0]);

        int v1 = Convert.ToInt32(x1V1X2V2[1]);

        int x2 = Convert.ToInt32(x1V1X2V2[2]);

        int v2 = Convert.ToInt32(x1V1X2V2[3]);

        string result = kangaroo(x1, v1, x2, v2);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
