using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMininArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[100];
            int n, i;
            int max = 0, min = 0;


            Console.Write("\n\nMax and Min element of an array:\n");
            Console.Write("----------------------------------------------------\n");

            Console.Write("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            //max in array
            //min in array
            max = arr1[0];
            min = arr1[0];
            for (i = 1; i < n; i++)
            {
                if (arr1[i] > max)
                {
                    max = arr1[i];
                }

                if (arr1[i] < min)
                {
                    min = arr1[i];
                }
            }
           

       

            Console.WriteLine("Max is {0}", max);
            Console.WriteLine("Min is {0}", min);
            Console.ReadLine();
        }
    }
}
