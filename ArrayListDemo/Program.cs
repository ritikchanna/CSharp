using System;
using System.Collections;


namespace ArrayListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            bool temp;

            char exit = 'n';
            do
            {     
                Console.WriteLine("Enter element value");
                list.Add(Console.ReadLine());
                Console.WriteLine("Enter element(y/n)");
                temp = char.TryParse(Console.ReadLine(), out exit);

            } while (exit == 'y' || exit == 'Y');
            Console.WriteLine("Enter element to be searched: ");
            String check = Console.ReadLine();
            check = check.Trim();
            if (list.Contains(check))
                Console.WriteLine("Element Found at " + list.LastIndexOf(check));
            else
                Console.WriteLine("Element Not Found");
            Console.ReadKey();
        }
    }
}
