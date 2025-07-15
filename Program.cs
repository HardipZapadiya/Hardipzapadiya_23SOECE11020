using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardipzapadiya_23SOECE11020
{
    internal class Program
    {
        public static void Main(string []arg)
        {
            // Questions.printtable(10);
            //int a = 5;
            //Console.WriteLine(a++);


           // TwoD_Array ary = new TwoD_Array(2, 2);
           // ary.add(1, 1, 100);
          //  ary.add(1, 2, 200);
          //  ary.print_Array();

            int[,] arr1= new int[2, 2] { { 1, 1 }, { 1, 1 } };
            int[,] arr2 = new int[2, 2] { { 2,2 }, { 2,2} };


            int[,] sumarray = TwoD_Array.add_array(arr1,arr2, 2, 2);
            TwoD_Array.printArray(arr1);
            TwoD_Array.printArray(arr2);
            TwoD_Array.printArray(sumarray);

        }
    }
}
