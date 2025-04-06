using System;
using System.Collections.Generic;
namespace CourseAssignments
{
    public class Reader
    {
        public string ReadString()
        {
            string? input1 = Console.ReadLine()?.Trim().ToUpper();

            if (input1 == null)
            {
                Console.WriteLine("Invalid input.");
                return "";
            }

            return input1;
        }

        public string ReadNumber()
        {
            string? input1 = Console.ReadLine();

            if (input1 == null)
            {
                Console.WriteLine("Invalid input.");
                return "";
            }

            return input1;
        }
    }
}
