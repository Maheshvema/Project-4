using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********STUDENTS********");
            Console.WriteLine("Enter the number of students:");
            int numberOfStudents = int.Parse(Console.ReadLine());
            Student[] students = new Student[numberOfStudents];

            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine("Enter student name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter class:");
                int cls = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter section:");
                char section = char.Parse(Console.ReadLine());
                students[i] = new Student(name, cls, section);
               
            }
                Console.WriteLine("----------------------------------");

                Console.WriteLine("*******TEACHERS************");
                Console.WriteLine("Enter the number of teachers:");
                int numberOfTeachers = int.Parse(Console.ReadLine());
                Teachers[] teachers = new Teachers[numberOfTeachers];

                for (int i = 0; i < numberOfTeachers; i++)
                {
                    Console.WriteLine("Enter teacher name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter subject name:");
                    string subject = Console.ReadLine();
                    teachers[i] = new Teachers(name, subject);
                    
                }
                Console.WriteLine("----------------------------------");

                Console.WriteLine("*********SUBJECTS***********");
                Console.WriteLine("Enter the number of subjects:");
                int numberOfSubjects = int.Parse(Console.ReadLine());
                Subject[] subjects = new Subject[numberOfSubjects];

                for (int i = 0; i < numberOfSubjects; i++)
                {
                    Console.WriteLine("Enter subject name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter subject code:");
                    string code = Console.ReadLine();
                    subjects[i] = new Subject(name, code);
                    
                }
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("****************PRINTING DETAILS OF STUDENTS********************");
                foreach (var item in students)
                {
                    Console.WriteLine($"Name : {item.Name}");
                    Console.WriteLine($"Class : {item.Class}");
                    Console.WriteLine($"Section : {item.Section}");
                  
                }

                Console.WriteLine("********************PRINTING DETAILS OF TEACHERS*****************");
                foreach (var item in teachers)
                {
                    Console.WriteLine($"Name : {item.Name}");
                    Console.WriteLine($"Subject : {item.Subject}");
                   
                }

                Console.WriteLine("***************PRINTING DETAILS OF SUBJECTS***************************");
                foreach (var item in subjects)
                {
                    Console.WriteLine($"Name : {item.Name}");
                    Console.WriteLine($"Subject Code : {item.SubCode}");
                   
               
                }
            Console.ReadKey();
        }
    }
 }

