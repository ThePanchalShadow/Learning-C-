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
        //Test of Phase 1
        //Print Diamond pattern like below at a given number of lines.

        int n;
        //TO get input for N
        Console.Write("Enter Size of Diamond:- ");
        n = Convert.ToInt32(Console.ReadLine());

        //n=n/2;

        //To print pyramid and reverse pyramid which will togather become Diamond
        for (int i = 0; i <= n; i++)
        {
            int k = n+1;
            //To print Pyramid
            if(i<n/2)
            {
                for (int j = 0; j <= n; j++)
                {
                    if(j>=(n-i))
                    {
                        Console.Write(k);
                    }
                    else Console.Write(" ");
                    k--;
                }
                k++;
                for (int j = 0; j < i; j++)
                {   
                    k++;
                    if(j>=j-i)
                    {
                        Console.Write(k);
                    }
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
            //To Print reverse pyramid
            if(i>n/2)
            {
                k = n+1;
                for (int j = 0; j <= n; j++)
                {
                    if(j>=i)
                    {
                        Console.Write(k);
                    }
                    else Console.Write(" ");
                    k--;
                }
                k++;
                for (int j = 0; j < n; j++)
                {
                    k++;
                    if(j<(n-i))
                    {
                        Console.Write(k);
                    }
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        // To stop terminal from closing
        Console.ReadLine();
    }
}