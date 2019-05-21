using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pallindrome
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Input String to be checked: ");
            string line = Console.ReadLine().Trim();
            bool isPalindrome = IsPalindrome(line);
            if (isPalindrome)
                Console.WriteLine(line + " is Palindrome");
            else
                Console.WriteLine(line + " is not Palindrome");

            Console.ReadKey();
        }
        public static bool IsPalindrome(string line)
        {
            if (line.Length <= 1)
                return true;
            else
            {
                if (line[0] != line[line.Length - 1])
                    return false;
                else
                    return IsPalindrome(line.Substring(1, line.Length - 2));
            }
        }
    }
}
