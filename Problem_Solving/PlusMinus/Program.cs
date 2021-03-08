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

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr) {
        
        int qtdNegativos = 0;
        int qtdPositivos = 0;
        int qtdZeros = 0;
        int n = arr.Length;
        
        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] < 0){
                qtdNegativos ++;
            } else if (arr[i] > 0) {
                qtdPositivos ++;
            } else {
                qtdZeros ++;
            }
        }   
        
        double propNegativos = (double)qtdNegativos/n;
        double propPositivos = (double)qtdPositivos/n;
        double propZeros = (double)qtdZeros/n;
            
        Console.WriteLine(propPositivos.ToString("N6"));
        Console.WriteLine(propNegativos.ToString("N6"));
        Console.WriteLine(propZeros.ToString("N6"));
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}
