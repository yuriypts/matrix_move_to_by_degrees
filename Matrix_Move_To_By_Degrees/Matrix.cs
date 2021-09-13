using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Matrix_Move_To_By_Degrees
{
    public class Matrix
    {
        public readonly int[][] arr =
        {
            new int [] { 1, 2, 3, 4, 7 },
            new int [] { 4, 3, 2, 5, 8 },
            new int [] { 5, 2, 1, 5, 4 },
            new int [] { 6, 5, 3, 1, 9 },
            new int [] { 2, 6, 1, 8, 3 },
        };

        public int[][] MoveByDegrees(int[][] arr)
        {
            int[][] copiedArr = new int[arr.Length][];

            for (int i = 0; i < arr.Length; i++)
            {
                copiedArr[i] = new int[arr[i].Length];
                int indexX = arr[i].Length - 1;

                for (int j = 0; j < arr[i].Length; j++)
                {
                    copiedArr[i][j] = arr[indexX][i];
                    indexX--;
                }
            }

            return copiedArr;
        }

        public List<List<int>> MoveByDegreesWithListType(List<List<int>> arr)
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
