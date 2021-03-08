using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the timeConversion function below.
     */
    static int separaHour(string s) {
        string[] timeStart = s.Split(':');
        int hour = Int32.Parse(timeStart[0]);
        return hour;
    }
   
    static string separaMinutes (string s) {
        string[] timeStart = s.Split(':');
        string minutes = s.Remove(0,2);
        return minutes;
    }
    
    static string timeConversion(string s) {
       
       string correctTime = s;
       int hour = separaHour(s);
       string minutes = separaMinutes(s);
       
       
       if (hour != 12 && s.Contains("PM")) {  
           
               hour += 12 ; 
               correctTime =$"{hour}{minutes}";
       } else if (hour == 12 && s.Contains("AM")) {
               string hour1 = "00"; 
               correctTime =$"{hour1}{minutes}";
               
       }
       
        return correctTime.Remove(8,2);
      

    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}
