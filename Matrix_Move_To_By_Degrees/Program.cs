using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Matrix_Move_To_By_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new List<List<int>>
            {
                new List<int> { 1, 2, 3, 4, 7 },
                new List<int> { 4, 3, 2, 5, 8 },
                new List<int> { 5, 2, 1, 5, 4 },
                new List<int> { 6, 5, 3, 1, 9 },
                new List<int> { 2, 6, 1, 8, 3 },
            };

            //var arr = new List<List<int>>
            //{
            //    new List<int> { 1, 2, 3 },
            //    new List<int> { 4, 5, 6 },
            //    new List<int> { 7, 8, 9 },
            //};


            ShowInConsole(arr);

            Console.WriteLine("----------------------");

            var updatedArr = MoveByDegrees(arr);

            ShowInConsole(updatedArr);


            Console.ReadKey();
        }

        static void ShowInConsole(List<List<int>> arr) 
        {
            foreach (var item in arr)
            {
                foreach (var index in item)
                {
                    Console.Write(index + ", ");
                }

                Console.WriteLine("");
            }
        }

        static List<List<int>> MoveByDegrees(List<List<int>> arr)
        {
            List<List<int>> copiedArr = JsonSerializer.Deserialize<List<List<int>>>(JsonSerializer.Serialize(arr));

            for (int i = 0; i < arr.Count; i++)
            {
                int indexX = arr[i].Count - 1;

                for (int j = 0; j < arr[i].Count; j++) 
                {
                    copiedArr[i][j] = arr[indexX][i];
                    indexX--;
                }
            }

            return copiedArr;
        }
    }
}
