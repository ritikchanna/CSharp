using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1,2,1, 2, 3, 4, 1, 5, 2, 1 ,3,1};



            int n;
            bool v
            bool  = int.TryParse(Console.ReadLine, out n);
            int[] temp = new int[array.Length];
            int index = -1;
            for(int i = 0; i < array.Length; i++)
            {
                


                for(int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j] && (!temp.Contains(array[i])))
                    {
                        temp[++index] = array[i];
                    }
                }
            }

            for(int k = 0; k <= index; k++)
            {
                Console.WriteLine(temp[k]);
            }
            Console.ReadKey();

        }
    }
}
