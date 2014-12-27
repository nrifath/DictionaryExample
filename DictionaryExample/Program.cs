using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> courses = new Dictionary<string, string>();
            courses.Add("cse-001","Computer Fundamental");
            courses.Add("cse-002", "Structured Programming");


            foreach (var course in courses)
            {
                Console.Write(course.Key);
                Console.Write(": ");
                Console.WriteLine(course.Value);
            }

            Console.WriteLine("Enter Course Code: ");
            string courseCode = Console.ReadLine();
            Console.WriteLine("Enter Course Title");
            string courseTitle = Console.ReadLine();

            if (courses.ContainsKey(courseCode))
            {
                Console.WriteLine("Course Code Already Exist");
            }
            else
            {
                courses.Add(courseCode,courseTitle);
                Console.WriteLine("Course Inserted Successfully");
            }



            Console.ReadKey();
        }
    }
}
