using System;

namespace JAGGEDARR
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[2][];
            arr[0] = new int[] { 11, 23, 33, 67 };
            arr[1] = new int[] { 45, 56, 88, 99, 23 };
            for(int i=0; i<arr.Length; i++)
            {
                for(int j=0; j<arr.Length; j++)
                {
                    Console.WriteLine(arr[i][j] + " ");
                    
                }
                Console.WriteLine();

            }
               
            
        }
    }
}
