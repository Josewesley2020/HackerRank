using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    static int simpleArraySum(int[] ar) {
        int soma = 0;
        
        for (int i = 0; i < ar.Length; i++){ 
            
            soma +=ar[i];
        }
         
        return soma;
    }

    static void Main(string[] args) {
       TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arCount = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = simpleArraySum(ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
