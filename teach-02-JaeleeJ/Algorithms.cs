﻿using System.Diagnostics;

namespace teach_02;

/*
 * CSE212 
 * (c) BYU-Idaho
 * 02-Teach - Problem 1
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */
public static class Algorithms {
    public static void Run() {
        Console.WriteLine("{0,15}{1,15}{2,15}{3,15}{4,15}{5,15}{6,15}", "n", "alg1-count", "alg2-count", "alg3-count",
            "alg1-time", "alg2-time", "alg3-time");
        Console.WriteLine("{0,15}{0,15}{0,15}{0,15}{0,15}{0,15}{0,15}", "----------");

        for (int n = 0; n < 15001; n += 1000) {
            int count1 = Algorithm1(n);
            int count2 = Algorithm2(n);
            int count3 = Algorithm3(n);
            double time1 = Time(Algorithm1, n, 10);
            double time2 = Time(Algorithm2, n, 10);
            double time3 = Time(Algorithm3, n, 10);
            Console.WriteLine("{0,15}{1,15}{2,15}{3,15}{4,15:0.00000}{5,15:0.00000}{6,15:0.00000}", n, count1, count2,
                count3, time1, time2,
                time3);
        }
    }

    private static double Time(Func<int, int> algorithm, int input, int times) {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < times; ++i) {
            algorithm(input);
        }

        sw.Stop();
        return sw.Elapsed.TotalMilliseconds / times;
    }

    /// <summary>
    /// The count variable is keeping track of the amount
    /// of work done in the function.  When the function is 
    /// done the count is returned.
    /// </summary>
    /// <param name="size">the amount of work to do</param>
    private static int Algorithm1(int size) {
        var count = 0;
        for (var i = 0; i < size; ++i)
            count += 1;

        return count;
    }

    /// <summary>
    /// The count variable is keeping track of the amount
    /// of work done in the function.  When the function is 
    /// done the count is returned.
    /// </summary>
    /// <param name="size">the amount of work to do</param>
    private static int Algorithm2(int size) {
        var count = 0;
        for (var i = 0; i < size; ++i)
            for (var j = 0; j < size; ++j)
                count += 1;

        return count;
    }

    /// <summary>
    /// The count variable is keeping track of the amount
    /// of work done in the function.  When the function is 
    /// done the count is returned.
    /// </summary>
    /// <param name="size">the amount of work to do</param>
    private static int Algorithm3(int size) {
        var count = 0;
        var start = 0;
        var end = size - 1;
        while (start <= end) {
            var middle = (end - start) / 2 + start;
            start = middle + 1;
            count += 1;
        }

        return count;
    }

    /// <summary>
    /// Determine and return the length of the numbers list, the sum
    /// of all the numbers, and the average of the numbers.
    /// </summary>
    /// <returns>Tuple with the sum, count, and average of the supplied numbers</returns>
    private static Tuple<int, int, float> CalculateStats(int[] numbers) {
        var totalSum = 0;
        var count = 0;
        foreach (var number in numbers)
            totalSum += number;
        foreach (var number in numbers)
            count += 1;
        var average = ((float)totalSum) / count;
        return new Tuple<int, int, float>(totalSum, count, average);
    }

    /// <summary>
    /// Print a filled in isosceles triangle to the screen
    /// </summary>
    /// <param name="size">number of characters for the length of the side</param>
    private static void PrintTriangle(int size) {
        for (var i = 0; i < size; ++i) {
            for (var j = 0; j <= i; ++j)
                Console.Write("*");
            Console.WriteLine();
        }
    }

    /// <summary>
    /// Display each letter of each name in the list on a separate line
    /// </summary>
    /// <param name="names">array of names to display</param>
    private static void DisplayLettersInNames(string[] names) {
        foreach (var name in names)
        foreach (var letter in name)
            Console.WriteLine(letter);
    }
}