using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khaibaomang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "Huy", "Nam", "Trung", "Viet", "Tung", "Duc" };

            Console.WriteLine("Enter a name's student: ");

            string input_name = Console.ReadLine();

            bool isExist = true;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Equals(input_name))
                {
                    Console.WriteLine("Position of students in the list " + input_name + " is: " + (i + 1));
                    isExist = false;
                    break;
                }
            }
            if (isExist)
            {
                Console.WriteLine("Not Found " + input_name + " int the list.");

            }
            Console.ReadKey();
        }
        
    }
}
