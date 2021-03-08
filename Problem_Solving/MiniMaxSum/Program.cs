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

    // Complete the miniMaxSum function below.
    static void miniMaxSum(int[] arr) {
        long somaTotal = 0;
        long maiorElemento = arr[0];
        long menorElemento = arr[0];
        
        for (int i = 0; i < arr.Length; i++) {
            somaTotal += arr[i];
        }
        
        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] > maiorElemento) {
                maiorElemento = arr[i];
            }
            if (arr[i] < menorElemento) {
                menorElemento = arr[i];
            }
            
        }
            
            
        
        long maxSum = somaTotal - menorElemento;
        long minSum = somaTotal - maiorElemento; 
        
        Console.WriteLine($"{minSum} {maxSum}");

    }

    static void Main(string[] args) {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        miniMaxSum(arr);
    }
}
