using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardipzapadiya_23SOECE11020
{
    internal class Arraypractice1
    {
        public static void arrayss()
        {
            //taking array size from user
            Console.WriteLine("Enter the size of the array:");
            int size = Convert.ToInt32(Console.ReadLine());

            //declaring array
            int[] arr = new int[size];

            //taking array elements from user
            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write("Element " + (i + 1) + ": ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //sorting array
            int min;
            for (int i = 0; i < size; i++)
            {
                min = arr[i];
                for (int j = i+1; j < size; j++)
                {
                    if (min > arr[j])
                    {
                        min = arr[j];

                    }
                }
                arr[i] = min;
            }
            //print sorted array
            Console.WriteLine("Sorted array");
            foreach(int ite in arr)
            {
                Console.Write(ite + ": ");
            }

        }
    }
}

