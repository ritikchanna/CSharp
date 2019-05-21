using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxandMin
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = { 1, 2, 3, 4, 5, 6 };


            

            int n;
            bool temp;
            do
            {
                Console.WriteLine("Please input size of the array: ");
                temp = int.TryParse(Console.ReadLine(), out n);
                if (!temp)
                    Console.WriteLine("Not a valid number: ");
            } while (!temp);
            int[] array = new int[n];

            for(int i = 0; i < n; i++)
            {
                temp = false;
                do
                {
                    Console.WriteLine("Please input element "+i);
                    temp = int.TryParse(Console.ReadLine(), out array[i]);
                    if(!temp)
                        Console.WriteLine("Not a valid number: ");

                } while (!temp);
            }





            int max = int.MinValue;
            int min = int.MaxValue;
            for(int i=0; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
                if (array[i] > max)
                    max = array[i];
            }
            Console.WriteLine("Max Value: " + max + " Min Value: " + min);
            Console.ReadKey();
        }
    }
}
