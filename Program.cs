﻿using System.CodeDom.Compiler;
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



class Solution
{
    public static void Main(string[] args)
    {
         //Day5: Loops Quiz; 

         int n = Convert.ToInt32(Console.ReadLine().Trim());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{n} x {i} = {n*i}");
        }

        Console.ReadLine(); 


         

        
    }

    public static void staircase(int n)
    {
       // Staircase Quiz;

        for (int i = 1; i <= n; i++)
        {
            StringBuilder jump = new StringBuilder();


            jump.Append('#', i);

            Console.WriteLine(jump);
        }
        Console.ReadLine();
    }

}
