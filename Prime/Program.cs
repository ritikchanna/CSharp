using System;


namespace Prime
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Input a postive number");
            int num = Convert.ToInt32(Console.ReadLine());
           bool isPrime = checkPrime(num,num/2);
            if (isPrime)
                Console.Write(num+" is Prime");
            else
                Console.WriteLine(num+" is not Prime");
            Console.ReadKey();
        }

        static bool checkPrime(int num, int x)
        {
            if (x == 1)
            {
                return true;
            }
            else
            {
                if (num%x == 0)
                    return false;
                else
                    return checkPrime(num,x-1);
            }
        }
    }
}
