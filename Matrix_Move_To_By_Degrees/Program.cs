using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Matrix_Move_To_By_Degrees
{
    class Program
    {
        public static readonly int[][] arr1 =
        {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 },
            new int[] { 7, 8, 9 },
        };

        public static readonly int[][] arr =
        {
            new int [] { 1, 2, 3, 4, 7 },
            new int [] { 4, 3, 2, 5, 8 },
            new int [] { 5, 2, 1, 5, 4 },
            new int [] { 6, 5, 3, 1, 9 },
            new int [] { 2, 6, 1, 8, 3 },
        };

        public static readonly List<List<int>> arrWithList = new List<List<int>>
        {
            new List<int> { 1, 2, 3, 4, 7 },
            new List<int> { 4, 3, 2, 5, 8 },
            new List<int> { 5, 2, 1, 5, 4 },
            new List<int> { 6, 5, 3, 1, 9 },
            new List<int> { 2, 6, 1, 8, 3 },
        };

        static void Main(string[] args)
        {
            //Matrix matrix = new Matrix();

            //ShowInConsole(arr);

            //Console.WriteLine("----------------------");

            //var updatedArr = matrix.MoveByDegrees(arr);

            //ShowInConsole(updatedArr);

            //Console.ReadKey();

            BenchmarkRunner.Run<ProgramBenchmarks>();
        }

        static void ShowInConsole(int[][] arr) 
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + ", ");
                }

                Console.WriteLine("");
            }
        }
    }
}
