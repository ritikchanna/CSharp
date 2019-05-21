using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            //API automation(specflow+RestSharp)
            //web automation(Selenium)



            int n;
            bool temp;
            do
            {
                Console.WriteLine("Please input size of the array: ");
                temp = int.TryParse(Console.ReadLine(), out n);
                if ((!temp) && n > 0)
                    Console.WriteLine("Not a valid size: ");
            } while (!temp);
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                temp = false;
                do
                {
                    Console.WriteLine("Please input element " + i);
                    temp = int.TryParse(Console.ReadLine(), out array[i]);
                    if (!temp)
                        Console.WriteLine("Not a valid number: ");

                } while (!temp);
            }
            int oddsize = 0;
            int evensize = 0;
            for (int j = 0; j < array.Length; j++)
                if (array[j] % 2 == 0)
                    evensize++;
                else
                    oddsize++;

            int[] oddvalues = new int[oddsize];
            int[] evenvalues = new int[evensize];
            oddsize = 0;
            evensize = 0;
            for (int k = 0; k < array.Length; k++)
            {
                if (array[k] % 2 == 0)
                    evenvalues[evensize++] = array[k];
                else
                    oddvalues[oddsize++] = array[k];
            }
            Console.WriteLine("Odd values are ");
            for (int l = 0; l < oddvalues.Length; l++)
                Console.Write(oddvalues[l] + " ");
            Console.WriteLine();
            Console.WriteLine("Even values are ");
            for (int m = 0; m < evenvalues.Length; m++)
                Console.Write(evenvalues[m] + " ");

            Console.ReadKey();


        }
    }
}
