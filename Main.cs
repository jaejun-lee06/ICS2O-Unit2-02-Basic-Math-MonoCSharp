// Created by: Jaejun
// Created on: Mar 2022
//
// This program does basic math

using System; 

public class Program 
{

    public static void Main(string[] args) 
    {
        Console.WriteLine(9 + 2);
        Console.WriteLine("7 - 3 = " + (7 - 3));
        Console.WriteLine("4 * 2 = " + (4 * 2));
        Console.WriteLine("4 + 4 ÷ 2 = " + (4 + (4 / 2)));
        Console.WriteLine("5 + 2³ = " + (5 + Math.Pow(2, 3)));

        Console.WriteLine("\nDone.");
    }
}