using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardipzapadiya_23SOECE11020
{
    public class TwoD_Array
    {
        int row;
        int col;
        int[,] arr;
        public TwoD_Array(int row, int col)
        {
            this.row = row;
            this.col = col;
            arr = new int[row, col];
        }
        public bool add(int n, int m, int value)
        {
            arr[n-1, m-1] = value; return true;
        }

        public void print_Array()
        {
            for( int i=0; i< row; i++)
            {
                for(int j= 0; j < col; j++)
                {
                    Console.Write(arr[i,j]+(j==col-1?"  ":" , "));

                }
                Console.WriteLine();
            }

        }

        public static int[,]  add_array(int[,] arr1,int[,] arr2,int r,int c)
        {
            int[,] sum_array=new int[r,c];

            for (int i=0; i< r; i++)
            {
                for (int j= 0;j< c; j++)
                {
                    sum_array[i, j] += arr1[i, j] + arr2[i, j];
                }
            }
            return sum_array;
        }

        public static void printArray(int[,] arr)
        {
            int row = arr.GetLength(0);
            int col = arr.GetLength(1);

            Console.WriteLine("Matrix is :");
            for (int i=0; i< row; i++)
            {

                for (int j=0; j< col; j++)
                {
                    Console.Write(arr[(int)i, (int)j]+ (j==col-1?" ":" , "));
                }
                Console.WriteLine();
            }
        }
    }
}
